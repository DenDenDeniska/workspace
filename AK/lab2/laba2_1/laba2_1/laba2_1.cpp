// laba2_1.cpp: ���������� ����� ����� ��� ����������� ����������.
//

#include "stdafx.h"

void main ()				// ������ ��������� �� ����� �++
{
	long	X=1;			// ������ ������ ��� ���������
	long	REZ[6];			// 6 ����� ������ ��� �����������
	long	P=2;			// ������ ��� �������������� ��������

	_asm
	{				; ������ ������������ �������
	lea	EBX, REZ		; �������� ������ ����������� � ������� EBX
	mov	ECX, 6			; ������� ���������� ���������� �����
m1:	mov	EAX, 5 			; EAX = 5
	add	EAX, X			; EAX = X + 5
	mov	EDI, EAX		; ��������� ����������� � ������� EDI
	mov	EAX, 3			; EAX = 3
	mov EDX , 0			;
	mov P , ECX			;
	mov ECX, X			;
	
a1: mul EAX
	loop a1
	mov ECX, P			;pizdetz

	
	}				// ��������� ������������ �������
}