
#include<reg52.h> 
#include<intrins.h>

sbit RS = P2^4;   
sbit RW = P2^3;
sbit EN = P2^2;
sbit P20=P2^0;
sbit P21=P2^1;
sbit P35 = P3^5;

#define DataPort P1

void DelayUs2x(unsigned char t)
{   
 while(--t);
}

void DelayMs(unsigned char t)
{
 while(t--)
 {
    DelayUs2x(245);
	DelayUs2x(245);
 }
}

 void LCD_Write_Com(unsigned char com) 
 {  
	RS = 0; 
	RW = 0; 
	EN = 1; 
	DataPort = com; 
	DelayMs(1);
	EN = 0;
 }


 void LCD_Write_Data(unsigned char Data) 
 { 
	RS = 1; 
	RW = 0; 
	EN = 1; 
	DataPort = Data; 
	DelayMs(1);
	EN = 0;
 }

 void LCD_Clear(void) 
 { 
	LCD_Write_Com(0x01); 
	DelayMs(5);
 }

 void LCD_Init(void) 
 {
    LCD_Write_Com(0x38);   
    DelayMs(200); 
    LCD_Write_Com(0x0f);   
    DelayMs(200); 
     
 }
 
 void WritSymbol(long Adr)
 {
		LCD_Write_Com(64);
	 LCD_Write_Data(0);
	 LCD_Write_Data(0);
	 LCD_Write_Data(0);
	 
		LCD_Write_Com(72);
		LCD_Write_Data(4);
		LCD_Write_Data(4);
		LCD_Write_Data(31);
		LCD_Write_Data(4);
		LCD_Write_Data(6);
		LCD_Write_Data(12);
		LCD_Write_Data(4);
	 
		LCD_Write_Com(Adr);
		LCD_Write_Data(0x00);
	 LCD_Write_Com(Adr);
		LCD_Write_Data(1);
	 }
 
 
 void WriteSomething()
 {
	 long Adr = 128;
		while(1)
		{
			
			while(Adr != 143)
			{
				
				WritSymbol(Adr);
				LCD_Write_Com(Adr+1);
				//DelayMs(1);
				LCD_Write_Data ('A');
				//DelayMs(100);
				LCD_Write_Com(Adr+2);
				//DelayMs(1);
				LCD_Write_Data ('M');
				//DelayMs(100);
				LCD_Write_Com(Adr+3);
				//DelayMs(1);
				LCD_Write_Data (0xa5);
				//DelayMs(100);
				LCD_Write_Com(Adr+4);
				//DelayMs(1);
				LCD_Write_Data ('H');
				LCD_Write_Com(Adr+5);
				//DelayMs(1);0xE2
				LCD_Write_Data (0xad);
				WritSymbol(Adr+6);
				
				DelayMs(1000);
				LCD_Clear();
				
				Adr++;
			}
			
			Adr = 128;
		}
 }
 
void main(void) 
{ 
	P1=0x00;
	P20=0; 
	P21=0; 
	P35=0; 
	P1=0xFF;
   
  LCD_Init(); 
  LCD_Clear();
	
	WriteSomething();
/*
	while (1) 
	{  
		LCD_Write_Com(0x80);
		DelayMs(5);
		LCD_Write_Data ('O');
		DelayMs(5);
		LCD_Write_Com(0x88);
		DelayMs(5);
		LCD_Write_Data ('k');
		DelayMs(5);
		
		while(1);
	}
*/
} 



