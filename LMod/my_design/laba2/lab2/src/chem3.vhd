library IEEE;
use IEEE.STD_LOGIC_1164.all;

entity chem1 is
	 port(
		 x1 : in STD_LOGIC;
		 x2 : in STD_LOGIC;
		 x3 : in STD_LOGIC;
		 x4 : in STD_LOGIC;
		 y : out STD_LOGIC
	     );
end chem1;

architecture chem1 of chem1 is 
begin
process	(x1, x2, x3, x4) is
Variable p1, p2, p3, p4, p5, p6, p7, py : std_logic;
begin
	p1:=not x2;
	p2:=not x3;
	p3:=not x4;
	p4:=x1 and p1;
	p5:=p1 and p2;
	p6:=p1 and p3;
	p7:=x2 and x3 and x4;
	py:=p4 or p5 or p6 or p7;
	Y<=py;		  
	end process;
end chem1;
