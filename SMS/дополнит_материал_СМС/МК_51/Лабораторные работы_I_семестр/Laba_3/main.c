#include<reg52.h> 
#define KeyPort P3

#define DataPort P1
sbit LATCH1=P2^0;
sbit LATCH2=P2^1;

unsigned char code Data[10]={0xc0,0xf9,0xa4,0xb0,0x99,0x92,0x82,0xf8,0x80,0x90};
// 0123456789
unsigned char code Zn_Data[]={0x1,0x2,0x4,0x8,0x10,0x20,0x40,0x80};
unsigned char TempData[8]={0XFF,0XFF,0XFF,0XFF,0XFF,0XFF,0XFF,0XFF,}; 
unsigned char num = 0;
unsigned char zn = 0;

void Delay(unsigned int t)
{   
 while(--t);
}				

unsigned char KeyScan(void);
void Display();

void main (void)
{
while (1)
	{
		num = KeyScan();
		Display();
	}	
}

void Display()
{
   	P1 = 0xff;
	LATCH1 = 1;
	LATCH1 = 0;	
	
	P1 = Zn_Data[zn];
	LATCH2 = 1;
	LATCH2 = 0;
	
	P1 = Data[num];
	LATCH1 = 1;
	LATCH1 = 0;
	
//	Delay (3);

}

unsigned char KeyScan(void)
{
unsigned char KeyCode;
unsigned char tmp;
P3 = 0x???;
tmp = P3;
	if (tmp != 0x???)
	{	Delay (10);
		if (tmp !=0x???)
		{
		  switch(tmp)
		  {
		  case 0x???: KeyCode = 0; break;
		  case 0x???: KeyCode = 1; break;
		  case 0x???: KeyCode = 2; break;
		  case 0x???: KeyCode = 3; break;
		  }
		  while (P3 !=0x7f);
		}
	}
	return KeyCode;
} 

