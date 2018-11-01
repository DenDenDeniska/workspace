#include "mems_lis3dsh.h"

//------------------------------------
extern SPI_HandleTypeDef hspi1;
/* Private variables ---------------------------------------------------------*/
void (*mems_error_handler)(void) = NULL;
//------------------------------------


//--------------------------------------
void MEMS_Set_Error_Handler( void (*_mems_error_handler)(void) )
{
	mems_error_handler = _mems_error_handler;
}
//--------------------------------------
/// Error handler: called on unexpected behavior
static void MEMS_Error(void)
{
	if ( mems_error_handler != NULL )
	{
		(*mems_error_handler)();
	}
}
//--------------------------------------
uint8_t SPIx_WriteRead(uint8_t Byte)
{
	uint8_t receivedbyte = 0;
	if(HAL_SPI_TransmitReceive(&hspi1,(uint8_t*) &Byte,(uint8_t*) &receivedbyte, 1, 0x1000) != HAL_OK)
	{
		MEMS_Error();
	}
	return receivedbyte;
}

//--------------------------------------
// Read one byte from address
uint8_t MEMS_Read_Byte( uint8_t address )
{
	uint8_t data = 0;
	
	address |= READWRITE_CMD;  // Set to read
	SPI_CS_ON;  // Packet start
	SPIx_WriteRead( address );
	data = SPIx_WriteRead( DUMMY_BYTE );
	SPI_CS_OFF;  // Packet end
	
	return data;
}

//--------------------------------------
// Write one byte to address
void MEMS_Write_Byte( uint8_t address, uint8_t data )
{
	SPI_CS_ON;  // Packet start
	SPIx_WriteRead( address );
	SPIx_WriteRead( data );
	SPI_CS_OFF;  // Packet end
}

//--------------------------------------
// Read two bytes from address offset
uint16_t MEMS_Read_16bit_Value( uint8_t address )
{
	uint16_t read_value = 0;
	
	// Work only when auto address increment
	address |= READWRITE_CMD;  // Set to read
	SPI_CS_ON;  // Packet start
	SPIx_WriteRead( address );
	read_value = SPIx_WriteRead( DUMMY_BYTE );  // read LSByte
	read_value |= ( SPIx_WriteRead( DUMMY_BYTE )  << 8 );  // read MSByte
	SPI_CS_OFF;  // Packet end

	return read_value;
}


//--------------------------------------
float MEMS_Get_Sensitivity( void )
{
	float sensitivity = LIS3DSH_SENSITIVITY_0_06G;
	uint8_t address = LIS3DSH_CTRL_REG5_ADDR;  // 0x24 - Control Register 5 Address 
	uint8_t ctrl_reg_5 = MEMS_Read_Byte( address ); 
	
	switch ( ctrl_reg_5 & LIS3DSH__FULLSCALE_SELECTION)
	{
		case LIS3DSH_FULLSCALE_2:
    sensitivity = LIS3DSH_SENSITIVITY_0_06G;
    break;
  case LIS3DSH_FULLSCALE_4:
    sensitivity = LIS3DSH_SENSITIVITY_0_12G;
    break;
  case LIS3DSH_FULLSCALE_6:
    sensitivity = LIS3DSH_SENSITIVITY_0_18G;
    break;
  case LIS3DSH_FULLSCALE_8:
    sensitivity = LIS3DSH_SENSITIVITY_0_24G;
    break;
  case LIS3DSH_FULLSCALE_16:
    sensitivity = LIS3DSH_SENSITIVITY_0_73G;
    break;
  default:
    break;                
	}
	return sensitivity;
}

//--------------------------------------
float MEMS_Recalc_to_g_Accel( uint16_t axis_value )
{
	float sensitivity = MEMS_Get_Sensitivity();
	return axis_value * sensitivity * 0.01F;	// TODO: remove hardcoded 0.1F -> read from sensor
}
//--------------------------------------
uint16_t MEMS_Get_Axis_Value( uint8_t address )
{
	return (MEMS_Read_16bit_Value( address ));
}

//--------------------------------------
// Read X-axis value from MEMS
uint16_t MEMS_Get_X_Axis_Value( void )
{
	uint8_t address = LIS3DSH_OUT_X_L_ADDR;  // 0x28 - register's address for X-asis
	return MEMS_Get_Axis_Value( address );
}

//--------------------------------------
// Read Y-axis value from MEMS
uint16_t MEMS_Get_Y_Axis_Value( void )
{
	uint8_t address = LIS3DSH_OUT_Y_L_ADDR;  // 0x2A - register's address for Y-asis
	return MEMS_Get_Axis_Value( address );
}

//--------------------------------------
// Read Z-axis value from MEMS
uint16_t MEMS_Get_Z_Axis_Value( void )
{
	uint8_t address = LIS3DSH_OUT_Z_L_ADDR;  // 0x2C - register's address for Z-asis
	return MEMS_Get_Axis_Value( address );
}

//--------------------------------------
// Read MEMS chip ID value
// return 'true' when MEMS enabled
bool MEMS_Read_ID( void )
{
	uint8_t address = LIS3DSH_WHO_AM_I_ADDR;  // ID register's address in chip = 0x0F
	uint8_t read_id = MEMS_Read_Byte( address );  
	// check read value	
	if (read_id == 0xFF)
	{	// Unable to read
		MEMS_Error();
	}
	else if (read_id == 0x3F)  // LIS3DSH chip should have ID == 0x3F
	{	// MEMS enabled
		return true;
	}
	return false;
}

//--------------------------------------
bool MEMS_Init(void)
{
	HAL_Delay(1000);
	// check ID
	if ( MEMS_Read_ID() )
	{	// ID OK
		// Output data rate = 100 Hz; Enable all axis - X, Y and Z
		MEMS_Write_Byte( LIS3DSH_CTRL_REG4_ADDR, LIS3DSH_DATARATE_100 | LIS3DSH_XYZ_ENABLE );
		// Use 4-wire SPI; Self-test disabled; Full-scale = 2g; Anti-aliasing filter bandwidth = 800 Hz
		MEMS_Write_Byte( LIS3DSH_CTRL_REG5_ADDR, LIS3DSH_SERIALINTERFACE_4WIRE | LIS3DSH_SELFTEST_NORMAL | LIS3DSH_FULLSCALE_2 | LIS3DSH_FILTER_BW_800 );
		// Enable register address automatically incremented during a multiple byte access with a serial interface 
		MEMS_Write_Byte( LIS3DSH_CTRL_REG6_ADDR, LIS3DSH_ADD_INC );
		return true;
	}
	return false;
}

//--------------------------------------
