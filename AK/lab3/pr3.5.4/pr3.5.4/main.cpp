#include <iostream>

void main() {
	//������� 6. ��������� 7 �������� ������� Y = 5(sin x), x ���������� � �������� �� 10 � ����� 8.
			//									  A                                    X          B
	long C = 7, C_m = 0; //����� ������� � ������� ������ ��������� ������� (����� ��� ��������)
	long X = 10, B = 8, A = 5, D = 180;
	float REZ[7];
	_asm {
		
		mov ECX, C;
	a1:
		finit;
		fldpi;			�������� ��������� ��� � ���� FPU
		fimul	X;		��������� ����� ��� �� ��������
		fidiv	D;		������� ��������� �� 180
		fsin;
		fimul	A;
		mov EAX, C_m;
		fstp	dword ptr REZ[EAX];
		add C_m, 4;
		mov EAX, B;
		add X, EAX;
		loop a1;
	}
}