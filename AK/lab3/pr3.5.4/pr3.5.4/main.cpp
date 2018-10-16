#include <iostream>

void main() {
	//Вариант 6. Вычислить 7 значений функции Y = 5(sin x), x изменяется в градусах от 10 с шагом 8.
			//									  A                                    X          B
	long C = 7, C_m = 0; //общий счетчик и счетчик адреса элементов массива (нужно для перебора)
	long X = 10, B = 8, A = 5, D = 180;
	float REZ[7];
	_asm {
		
		mov ECX, C;
	a1:
		finit;
		fldpi;			загрузка константы «пи» в стек FPU
		fimul	X;		умножение числа «пи» на аргумент
		fidiv	D;		деление аргумента на 180
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