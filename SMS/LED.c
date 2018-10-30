#include<reg52.h> 

sbit LATCH1=P2^0;
sbit LATCH2=P2^1;

sbit SEG = P1; 

unsigned char code Data[10]={0xc0,0xf9,0xa4,0xb0,0x99,0x92,0x82,0xf8,0x80,0x90};
// 0123456789  
unsigned char code Zn_data[]={0x1,0x2,0x4,0x8,0x10,0x20,0x40,0x80};
// 


void Delay (unsigned int t)
{   
 while(--t);
}
void main (void)
{
while (1)        
  {
		unsigned k = 0;
		unsigned int i = 1;
			while(i != 8){
				LATCH1 = 1;
				P1=Data[i];
				LATCH1 = 0;
				
				LATCH2 = 1;
				P1 = Zn_data[k];
				LATCH2 = 0;
				Delay(25000);
				
				i++;
				k++;
			}
			while(i != 1){
				LATCH1 = 1;
				P1=Data[i];
				LATCH1 = 0;
				
				LATCH2 = 1;
				P1 = Zn_data[k];
				LATCH2 = 0;
				Delay(25000);
				
				i--;
				k--;
			}
			
  }
}