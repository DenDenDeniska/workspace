
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
	_nop_(); 
	EN = 0;
 }

 void LCD_Write_Data(unsigned char Data) 
 { 
	RS = 1; 
	RW = 0; 
	EN = 1; 
	DataPort = Data; 
	_nop_();
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
    DelayMs(25); 
    LCD_Write_Com(0x38); 
    DelayMs(25); 
    LCD_Write_Com(0x38); 
	DelayMs(25); 
    LCD_Write_Com(0x38);   
    LCD_Write_Com(10);   
    LCD_Write_Com(0x38);    
    DelayMs(5); 
    LCD_Write_Com(0x0c);   
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
 while (1) 
 {  
    LCD_Write_Com(0x87);
	DelayMs(5);
    LCD_Write_Data ('O');
	DelayMs(5);
    LCD_Write_Com(0x88);
	DelayMs(5);
    LCD_Write_Data ('k');
	DelayMs(5);

    LCD_Write_Com(0xC1);
	DelayMs(5);
    LCD_Write_Data ('H');
	DelayMs(5);
    LCD_Write_Com(0xC2);
	DelayMs(5);
    LCD_Write_Data ('e');
	DelayMs(5);
    LCD_Write_Com(0xC3);
	DelayMs(5);
    LCD_Write_Data ('l');
	DelayMs(5);
    LCD_Write_Com(0xC4);
	DelayMs(5);
    LCD_Write_Data ('l');
	DelayMs(5);
    LCD_Write_Com(0xC5);
	DelayMs(5);
    LCD_Write_Data ('o');
	DelayMs(5);
    LCD_Write_Com(0xC6);
	DelayMs(5);
    LCD_Write_Data ('!');  
	DelayMs(5);
				  
 
    while(1);
 }
} 

