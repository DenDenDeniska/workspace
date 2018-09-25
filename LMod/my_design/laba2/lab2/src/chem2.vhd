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
signal s5, s6, s7 ,s8, s9, s10, s11 : std_logic;
begin
	s5  <= not x2 ;
	s6  <= not x3 ;
	s7  <= not x4 ;
	s8  <= x1 and s5 ;
	s9  <= s5 and s6 ;
	s10 <= s5 and s7 ;
	s11 <= x2 and x3 and x3 ;
	y   <= s8 or s9 or s10 or s11 ;
end chem1;
