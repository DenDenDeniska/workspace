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
	
	//Delay (3);

}

unsigned char KeyScan(void)
{
unsigned char KeyCode;
unsigned char tmp;
KeyPort = 0x0f;
tmp = KeyPort;
	
	if (KeyPort != 0x0f)
	{	
		Delay (10);
		if (KeyPort != 0x0f)
		{
			KeyPort = 0x7f;
			if(tmp != 0x7f)
			{
				switch(KeyPort)
				{
					case 0x77: KeyCode = 0; break;
					case 0x7b: KeyCode = 1; break;
					case 0x7d: KeyCode = 2; break;
					case 0x7e: KeyCode = 3; break;
				
				}
				while (KeyPort !=0x7f);
				KeyPort = 0xff; //-----
				//return KeyCode;
			}
			KeyPort = 0xbf;
			if(KeyPort != 0xbf)
			{
				switch(KeyPort)
				{
					case 0xb7: KeyCode = 4; break;
					case 0xbb: KeyCode = 5; break;
					case 0xbd: KeyCode = 6; break;
					case 0xbe: KeyCode = 7; break;
				}
				while (KeyPort !=0xbf);
				KeyPort = 0xff; //-----
				//return KeyCode;
			}
			KeyPort = 0xdf;
			if(KeyPort != 0xdf)
			{
				switch(KeyPort)
				{
					case 0xd7: KeyCode = 8; break;
					case 0xdb: KeyCode = 9; break;
					//case 0xdd: KeyCode = 2; break;
					//case 0xde: KeyCode = 3; break;
				}
				while (KeyPort !=0xdf);
				KeyPort = 0xff; //-----
				//return KeyCode;
			}
			KeyPort = 0xef;
			if(KeyPort != 0xef)
			{
				switch(KeyPort)
				{
					case 0xe7: KeyCode = 0; break;
					case 0xeb: KeyCode = 1; break;
					case 0xed: KeyCode = 2; break;
					case 0xee: KeyCode = 3; break;
				}
				while (KeyPort !=0xef);
				KeyPort = 0xff; //-----
				//return KeyCode;
			}
			
		}
	}
	
	
	return KeyCode;
} 

