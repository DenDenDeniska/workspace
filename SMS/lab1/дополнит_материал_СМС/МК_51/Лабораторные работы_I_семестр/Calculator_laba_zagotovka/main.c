	
#include<reg52.h> 

#define DataPort P1 
#define KeyPort  P3

sbit LATCH1=P2^0;
sbit LATCH2=P2^1;

unsigned char code DATA[10]={0xc0,0xf9,0xa4,0xb0,0x99,0x92,0x82,0xf8,0x80,0x90};
// 0123456789
unsigned char code ZN_DATA[]={0x1,0x2,0x4,0x8,0x10,0x20,0x40,0x80};

unsigned char DisplayData[8]={0XFF,0XFF,0XFF,0XFF,0XFF,0XFF,0XFF,0XFF}; 

void DelayUs2x(unsigned char t);
void DelayMs(unsigned char t); 
void Display(unsigned char FirstBit,unsigned char Num);
void DisplayNumber(int number);

unsigned char KeyPro(void);
void Init_Timer0(void);
unsigned char Calc( unsigned char symb);

void Delay(unsigned int t)
{
 	while(--t);
}
	
void main (void)
{
	unsigned char times = 0; // ���������� ������� ���������� ��������� ������������
	unsigned char keyResult = 0xff; // ������ �������� �������� � ����������
	unsigned char oper = 0; // ������ �������� ��� ����������
	int value1=0, // ������ ������ �������� 
		value2=0, // ������ ������ �������� 
		result=0; // ������ ��������� �� ���������� �������� 
	Init_Timer0();

	while (1)       
	{
	  	switch(times) // � ����������� �� ���������
		{
			case 0: // ��������� ������ �����
			{
					// ��������� ����� �����
					// ��������� �������� �������� � value1
				    // ���������� ��������� ��������
  			
			       // ����� ������ �������� ��������
				 	// ��������� � ����� ��������� �������� ��������
				}
			 	break;
			}

			case 1: // ������������ �������� �������� (���� ��������)
			{
				 // ���������� ��� �������� � ��������� �� ������������ ��������
				{
						// �������� ��������
					// �������� ���������
					{
						 // ��������� � ����� ����� ������� �����
					 	break;
					}
					default: // ���� ������������ ��������
					{
					   	times = 0; // ��������� � ����� ����� ������� ����� 
					}
				}
				break;
			}

			case 2: // ��������� ������ �����
			{
				// ��������� �������� �������� � value2
	 			 // ���������� ��������� ��������
  				// ������ ����������, ���� ���� ������� �����, ��...
					{
				 		times = 3; // ��������� � ����� ��������� ��������
					}
				}
			 	break;
			}

			case 3: // ��������� ���� ���������
			{
				switch (oper)
				{
					case 12:	// ��������� �������� ��������
								// � ���������� ��� �����, ��������� ��������� � result
					case 13: // ��������� �������� ���������
					{
							// �������� ��� �����, ��������� ��������� � result
					 	break;
					}
				}
				// ������� �� ����� ���������
				value1 = result;
				times = 0; // ��������� � ����� ����� ������� ����� 
			 	break;
			}

			default:
			{
				times = 0; // ��������� � ����� ����� ������� ����� 
			 	break;
			}
		}
 	}
}
	
	void DelayUs2x(unsigned char t)
	{   
		while(--t);
	}
	
	void DelayMs(unsigned char t)
	{
		while(t--)
		{
			 //    �1mS
			 DelayUs2x(245);
			 DelayUs2x(245);
		}
	}
	

void Display(unsigned char FirstBit,unsigned char Num)
{
      static unsigned char i=0;

	   DataPort=0xff;  
       LATCH1=1;     
       LATCH1=0;

       DataPort=ZN_DATA[i+FirstBit];
       LATCH2=1;  
       LATCH2=0;

//      DataPort= value1;
	   DataPort=DisplayData[i]; 
       LATCH1=1;   
       LATCH1=0;
       
	   i++;
       if(i==Num)
	      i=0;


	}

	/*
	 * ��������� ������� ����� �� ����������
	 */
	void DisplayNumber(int number)
	{
		unsigned char i, digitValue;
		// ���������� ���� �����
		if (number < 0)
		{
			DisplayData[0] = 0xBF;
			number = -number;
		}
		else
		{
			DisplayData[0] = 0xFF;
		} 
		// ���������� ���� �����
		for(i=7;i>0;--i)
		{
			if ((number == 0) && (i != 7))
			{
			  	digitValue = 0xFF;
			}
			else 
			{
			  	digitValue = DATA[number%10];
				number /= 10;
			}
			DisplayData[i]= digitValue;
		}
	}

	
	void Init_Timer0(void)
	{
		TMOD |= 0x01;	  
		EA=1;           
		ET0=1;           
		TR0=1;           
		}
		
		void Timer0_isr(void) interrupt 1 
		{
		TH0=(65536-2000)/256;		 
		TL0=(65536-2000)%256;
		
		Display(0,8);      
	
	}

	unsigned char KeyPro(void)
	{
		unsigned char keyValue = 0xff;
		KeyPort=0xf0; // ���������� ������ ��� ������ ������
		if(KeyPort!=0xf0) // ���� ������ ���� ������
		{
			DelayMs(10); // �����������
			if(KeyPort!=0xf0)
			{
				KeyPort = 0xfe;	// ���������� �� �������� ������ �����
				if (KeyPort != 0xfe)
				{
					Delay(10); // �����������
					if (KeyPort != 0xfe)
					{
						switch(KeyPort)
						{
							case 0x7e:keyValue = 0;break;//0 
							case 0xbe:keyValue = 4;break;//4
							case 0xde:keyValue = 8;break;//8
							case 0xee:keyValue = 12;break;// �������� "+"
							default:keyValue = 0xff; break;
						}
						while(KeyPort!=0xfe); // ����, ���� �� ��������� ������
						KeyPort=0xff; // ������� ����
						return keyValue; // ���������� �������� ������� ������
					}
				}
	
				KeyPort = 0xfd;
				if (KeyPort != 0xfd)
				{
					Delay(10);
					if (KeyPort != 0xfd)
					{
						switch(KeyPort)
						{
							case 0x7d:keyValue = 1;break;//1
							case 0xbd:keyValue = 5;break;//5
							case 0xdd:keyValue = 9;break;//9
							case 0xed:keyValue = 13;break;// �������� "-"
							default:keyValue = 0xff; break;
						}
						while(KeyPort!=0xfd); // ����, ���� �� ��������� ������
						KeyPort=0xff;
						return keyValue;
					}
				}
	
				KeyPort = 0xfb;
				if (KeyPort != 0xfb)
				{
					Delay(10);
					if (KeyPort != 0xfb)
					{
						switch(KeyPort)
						{
							case 0x7b:keyValue = 2;break;//2
							case 0xbb:keyValue = 6;break;//6
							case 0xdb:keyValue = 10;break;//a
							case 0xeb:keyValue = 14;break;//e
							default:return 0xff; break;
						}
						while(KeyPort!=0xfb); // ����, ���� �� ��������� ������
						KeyPort=0xff;
						return keyValue;
					}
				}
	
				KeyPort = 0xf7;
				if (KeyPort != 0xf7)
				{
					Delay(10);
					if (KeyPort != 0xf7)
					{
						switch(KeyPort)
						{
							case 0x77:keyValue = 3;break;//3
							case 0xb7:keyValue = 7;break;//7
							case 0xd7:keyValue = 11;break;// �������� "�����"
							case 0xe7:keyValue = 15;break;//f
							default:return 0xff; break;
						}
						while(KeyPort!=0xf7); // ����, ���� �� ��������� ������
						KeyPort=0xff;
						return keyValue;
					}
				}
			}
		}
		return keyValue;
 	}			
