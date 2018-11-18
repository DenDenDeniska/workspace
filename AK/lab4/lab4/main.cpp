#include <iostream>

int main()
{
	__asm {

		

			pushf; сохранить копию р - ра флагов
			pop EBX; восстановить в EBX

			mov EAX, 0FFFh; очистить биты 12 - 15 в EAX
			and EAX, EBX

			push EAX; сохранить новое значение флагов
			popf

			pushf; установить регистр флагов
			pop EAX; сохранить копию нового р - ра флагов в EAX

			mov ECX, 0F000h
			and EAX, ECX; если биты 12 - 15 установлены,
			cmp EAX, ECX; это процессор 8086 / 88

			jne non_8086; переход, если не 8086 / 88
			jmp cputype_8086; печать типа процессора 8086 / 88

			non_8086: mov EAX, 0; это не 8086 / 88 процессор

			cputype_8086 : mov EAX, 1; это 8086 / 88 процессор




						   
		mov EAX, 0
		cpuid

		mov EBX, 0;

		mov EAX, 1
		cpuid

	}


	return 0;
}