#include <iostream>

void main()
{
	//¬ариант 6. Y = ( 1 / 3 ) * arcSin (3 * A + sin 20∞).
	//                     B			 			  C
	long A=0, B=3, C=20, D=180; // €чейки дл€ операндов и аргумента ј
	float Y;			// €чейка дл€ результата функции
	_asm{
		finit;
		fild	B;
		fimul	A;
		
		fldpi;			загрузка константы Ђпиї в стек FPU
		fimul	C;		умножение числа Ђпиї на аргумент
		fidiv	D;		деление аргумента на 180
		fsin;
		fadd	ST,ST(1);
		//----------------
		fld		ST;		копирование вершины стека
		fmul	ST, ST;	возведение в квадрат
		fld1;			загрузка 1 в стек FPU
		fsubr;			вычитание с реверсом : 1 Ц z ^ 2
		fsqrt;			корень квадратный
		fpatan;			вычисление арктангенса
		fld1;
		fild B;
		
		fdiv;
		fmul;
		fstp Y;
	}
}