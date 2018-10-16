#include <iostream>

void main()
{
	//������� 6. Y = ( 1 / 3 ) * arcSin (3 * A + sin 20�).
	//                     B			 			  C
	long A=0, B=3, C=20, D=180; // ������ ��� ��������� � ��������� �
	float Y;			// ������ ��� ���������� �������
	_asm{
		finit;
		fild	B;
		fimul	A;
		
		fldpi;			�������� ��������� ��� � ���� FPU
		fimul	C;		��������� ����� ��� �� ��������
		fidiv	D;		������� ��������� �� 180
		fsin;
		fadd	ST,ST(1);
		//----------------
		fld		ST;		����������� ������� �����
		fmul	ST, ST;	���������� � �������
		fld1;			�������� 1 � ���� FPU
		fsubr;			��������� � �������� : 1 � z ^ 2
		fsqrt;			������ ����������
		fpatan;			���������� �����������
		fld1;
		fild B;
		
		fdiv;
		fmul;
		fstp Y;
	}
}