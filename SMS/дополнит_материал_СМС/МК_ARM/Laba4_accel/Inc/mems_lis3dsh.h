/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MEMS_LIS3DSH_H
#define __MEMS_LIS3DSH_H

/* Includes ------------------------------------------------------------------*/
#include "stm32f4xx_hal.h"
#include "stdbool.h"

/* Private define ------------------------------------------------------------*/
// MEMS SPI
#define SPI_CS_PORT 	GPIOE
#define SPI_CS_BIT   	GPIO_PIN_3
// SPI Chip Select defines
#define SPI_CS_ON  	HAL_GPIO_WritePin(SPI_CS_PORT, SPI_CS_BIT, GPIO_PIN_RESET)
#define SPI_CS_OFF	HAL_GPIO_WritePin(SPI_CS_PORT, SPI_CS_BIT, GPIO_PIN_SET)
//------------------------------------------------
#define ABS(x)         (x < 0) ? (-x) : x
//------------------------------------------------
#define DUMMY_BYTE ((uint8_t)0x00)
//------------------------------------------------
#define LIS3DSH_WHO_AM_I_ADDR 0x0F
//------------------------------------------------
#define READWRITE_CMD ((uint8_t)0x80)
//#define MULTIPLEBYTE_CMD ((uint8_t)0x40)
//------------------------------------------------
#define LIS3DSH_CTRL_REG4_ADDR               0x20
#define LIS3DSH_CTRL_REG5_ADDR               0x24
#define LIS3DSH_CTRL_REG6_ADDR               0x25
//------------------------------------------------
#define LIS3DSH_ADD_INC											 ((uint8_t)0x10)
//------------------------------------------------
#define LIS3DSH_DATARATE_POWERDOWN           ((uint8_t)0x00)  /* Power Down Mode*/
#define LIS3DSH_DATARATE_3_125               ((uint8_t)0x10)  /* 3.125 Hz Normal Mode */
#define LIS3DSH_DATARATE_6_25                ((uint8_t)0x20)  /* 6.25  Hz Normal Mode */
#define LIS3DSH_DATARATE_12_5                ((uint8_t)0x30)  /* 12.5  Hz Normal Mode */
#define LIS3DSH_DATARATE_25                  ((uint8_t)0x40)  /* 25    Hz Normal Mode */
#define LIS3DSH_DATARATE_50                  ((uint8_t)0x50)  /* 50    Hz Normal Mode */
#define LIS3DSH_DATARATE_100                 ((uint8_t)0x60)  /* 100   Hz Normal Mode */
#define LIS3DSH_DATARATE_400                 ((uint8_t)0x70)  /* 400   Hz Normal Mode */
#define LIS3DSH_DATARATE_800                 ((uint8_t)0x80)  /* 800   Hz Normal Mode */
#define LIS3DSH_DATARATE_1600                ((uint8_t)0x90)  /* 1600  Hz Normal Mode */
//------------------------------------------------
#define LIS3DSH_X_ENABLE                     ((uint8_t)0x01)
#define LIS3DSH_Y_ENABLE                     ((uint8_t)0x02)
#define LIS3DSH_Z_ENABLE                     ((uint8_t)0x04)
#define LIS3DSH_XYZ_ENABLE                   ((uint8_t)0x07)
//------------------------------------------------
#define LIS3DSH_SERIALINTERFACE_4WIRE        ((uint8_t)0x00)
#define LIS3DSH_SERIALINTERFACE_3WIRE        ((uint8_t)0x01)
//------------------------------------------------
#define LIS3DSH_SELFTEST_NORMAL              ((uint8_t)0x00)
#define LIS3DSH_SELFTEST_P                   ((uint8_t)0x02)
#define LIS3DSH_SELFTEST_M                   ((uint8_t)0x04)
//------------------------------------------------
#define LIS3DSH_FULLSCALE_2                  ((uint8_t)0x00)  /* 2 g  */
#define LIS3DSH_FULLSCALE_4                  ((uint8_t)0x08)  /* 4 g  */
#define LIS3DSH_FULLSCALE_6                  ((uint8_t)0x10)  /* 6 g  */
#define LIS3DSH_FULLSCALE_8                  ((uint8_t)0x18)  /* 8 g  */
#define LIS3DSH_FULLSCALE_16                 ((uint8_t)0x20)  /* 16 g */
#define LIS3DSH__FULLSCALE_SELECTION         ((uint8_t)0x38)
//------------------------------------------------
#define LIS3DSH_FILTER_BW_800                ((uint8_t)0x00)  /* 800 Hz */
#define LIS3DSH_FILTER_BW_40                 ((uint8_t)0x08)  /* 40 Hz  */
#define LIS3DSH_FILTER_BW_200                ((uint8_t)0x10)  /* 200 Hz */
#define LIS3DSH_FILTER_BW_50                 ((uint8_t)0x18)  /* 50 Hz  */
//------------------------------------------------
#define LIS3DSH_SENSITIVITY_0_06G            0.06  /* 0.06 mg/digit*/
#define LIS3DSH_SENSITIVITY_0_12G            0.12  /* 0.12 mg/digit*/
#define LIS3DSH_SENSITIVITY_0_18G            0.18  /* 0.18 mg/digit*/
#define LIS3DSH_SENSITIVITY_0_24G            0.24  /* 0.24 mg/digit*/
#define LIS3DSH_SENSITIVITY_0_73G            0.73  /* 0.73 mg/digit*/
//------------------------------------------------
#define LIS3DSH_OUT_X_L_ADDR                 0x28
#define LIS3DSH_OUT_X_H_ADDR                 0x29
#define LIS3DSH_OUT_Y_L_ADDR                 0x2A
#define LIS3DSH_OUT_Y_H_ADDR                 0x2B
#define LIS3DSH_OUT_Z_L_ADDR                 0x2C
#define LIS3DSH_OUT_Z_H_ADDR                 0x2D
//------------------------------------------------

/* Interface -----------------------------------------------------------------*/
// Initialize and enable MEMS chip
bool MEMS_Init(void);
// Read X-axis value from MEMS
uint16_t MEMS_Get_X_Axis_Value( void );
// Read Y-axis value from MEMS
uint16_t MEMS_Get_Y_Axis_Value( void );
// Read Z-axis value from MEMS
uint16_t MEMS_Get_Z_Axis_Value( void );
/// Set handler for MEMS Error occured
void MEMS_Set_Error_Handler( void (*_mems_error_handler)(void) );
/// Recalculate sensor axis value to acceleration in g, m/s^2
float MEMS_Recalc_to_g_Accel( uint16_t axis_value );

#endif /* __MEMS_LIS3DSH_H */
/*****END OF FILE****/
