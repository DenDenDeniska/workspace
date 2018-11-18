#include <REG52.H>

sbit LED_BLINK = P1^0; 
sbit BUTTON = P3^3;
unsigned int counter;

void Init_Timer0(void);

void Timer0(void) interrupt 1 
{
	TF0 = 0;
	counter--;
	//if(BUTTON == 0){
		if(counter == 0)
		{
			counter = 200;
		
				LED_BLINK = ~LED_BLINK;
		
		}
	//}
	TH0 = 0xD8;
	TL0 = 0x9E;
}

void Init_Timer0(void) 
{

	TMOD = 0x01; 
	
	EA = 1;	
	ET0 = 1;	
	TH0 = 0xD8;	
	TL0 = 0x9E;	
	
				
	TR0 = 1; 	

}
	

void main(void)
{
	Init_Timer0(); 	
	counter = 200;
	P1 = 0xFE;

	while(1)
	{
		
	};
}