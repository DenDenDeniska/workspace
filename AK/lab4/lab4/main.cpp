#include <iostream>

int main()
{
	__asm {

		

			pushf; ��������� ����� � - �� ������
			pop EBX; ������������ � EBX

			mov EAX, 0FFFh; �������� ���� 12 - 15 � EAX
			and EAX, EBX

			push EAX; ��������� ����� �������� ������
			popf

			pushf; ���������� ������� ������
			pop EAX; ��������� ����� ������ � - �� ������ � EAX

			mov ECX, 0F000h
			and EAX, ECX; ���� ���� 12 - 15 �����������,
			cmp EAX, ECX; ��� ��������� 8086 / 88

			jne non_8086; �������, ���� �� 8086 / 88
			jmp cputype_8086; ������ ���� ���������� 8086 / 88

			non_8086: mov EAX, 0; ��� �� 8086 / 88 ���������

			cputype_8086 : mov EAX, 1; ��� 8086 / 88 ���������




						   
		mov EAX, 0
		cpuid

		mov EBX, 0;

		mov EAX, 1
		cpuid

	}


	return 0;
}