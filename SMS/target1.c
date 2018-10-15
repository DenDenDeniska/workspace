#include <reg52.h>

void Delay(unsigned int t);

void main(void)
{
	unsigned char i;
	while(1)
		{
		for (i = 0; i<8; ++i)
			{
				P1 = ~(1 << i);
				Delay(30000);
			}
			for (i = 8; i>0; --i)
			{
				P1 = ~(1 << (i-1));
				Delay(30000);
			}
		}
}
	


void Delay(unsigned int t)
{
	while(--t);
}