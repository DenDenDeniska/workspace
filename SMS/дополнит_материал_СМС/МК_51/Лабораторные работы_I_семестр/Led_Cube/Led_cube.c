#include<reg52.h> 

sbit P20 = P2^0;
sbit P21 = P2^1;
sbit P35 = P3^5;
sbit LED0=P1^0;
sbit LED1=P1^1;
sbit LED2=P1^2;
sbit LED3=P1^3;
sbit LED4=P1^4;
sbit LED5=P1^5;
sbit LED6=P1^6;
sbit LED7=P1^7;
sbit LED8=P3^0;
sbit LINE1 = P3^2;
sbit LINE2 = P3^3;
sbit LINE3 = P3^4;

void del( int x )
{
	while( x-- ); 
}

void main()
{
	int i;
	
	P1 = 0x00;
	P20 = 0;
	P21 = 1;
	P35 = 1;
	P1 = 0xFF;	

	P1 = 0xFF;
	LED8 = 1;

	while (1)
	{
		P1 = 0xff;
		LED8 = 1;
	
		LINE1 = 0;
		del(200000);
		LINE1 = 1;
		del(200000);		

		LINE2 = 0;
		del(200000);
		LINE2 = 1;
		del(200000);

		LINE3 = 0;
		del(200000);
		LINE3 = 1;
	    del(200000);	

		P1 = 0x01;
		LINE1 = 0;
		del(200000);
				
		for (i = 0; i < 8; i++)
		{
		P1 = P1<<1;
		LINE1 = 0;
		del(200000);
		LINE1 = 1;
		}	
					
		LINE3 = 0;
		P1 = 0x01;
		del(10000);
		for( i = 0; i < 8; i++ )
		{
			P1 = P1 << 1;
			del(10000);
		}
		LINE3 = 1;	  
	}	
}	   	 
