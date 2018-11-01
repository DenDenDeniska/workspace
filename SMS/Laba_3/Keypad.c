#include<reg52.h> 

#define KeyPort P3

void Delay(unsigned char t)
{
	while(--t);
}

void main (void)
{
	while (1)
	{
		KeyPort= 0x0f;
		if (KeyPort != 0x0f)
		{
			Delay(10);
			if (KeyPort != 0xf0)
			{
				KeyPort = 0x7f;
				if (KeyPort != 0x7f)
					switch(KeyPort)
					{
						case 0x77: P1=0xfe; break;	 
						case 0x7b: P1=0xfd; break;
						case 0x7d: P1=0xfb; break;
						case 0x7e: P1=0xf7; break;
						
						
					}
				while (KeyPort != 0x7f);
			}
		}
	P1=0xff;
	}
}