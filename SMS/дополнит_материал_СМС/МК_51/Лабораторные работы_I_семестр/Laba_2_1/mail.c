 
#include<reg52.h> 

sbit P22 = P2^2;
unsigned char code Data[10]={0xc0,0xf9,0xa4,0xb0,0x99,0x92,0x82,0xf8,0x80,0x90};
// 0123456789


void Delay(unsigned int t); 

void main (void)
{
while (1)        
  {

  }	  
}

void Delay(unsigned int t)
{
 while(--t);
}
