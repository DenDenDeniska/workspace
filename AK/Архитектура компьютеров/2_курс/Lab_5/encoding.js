function my() {
	var str = document.forms.myform.mycharacter.value;
    if( str !== "") {

		var code = str.charCodeAt(0).toString(16).toUpperCase();
		var dos = code;
		var mybin = code;
        document.forms.myform.mycode.value = code;
		if(parseInt(code,16) > 255) {
			dos = uni2dos(code);
			mybin = parseInt(code,16).toString(2);
			mybin = "110"+mybin[0]+mybin[1]+mybin[2]+mybin[3]+mybin[4]+"10"+mybin[5]+mybin[6]+mybin[7]+mybin[8]+mybin[9]+mybin[10];
			mybin = parseInt(mybin,2).toString(16).toUpperCase();
		}
		document.forms.myform.mydos.value = dos;
		document.forms.myform.myutf.value = mybin;
		document.getElementById("answer").innerHTML += str+' ('+dos+') '+' {'+code+'}'+' ['+mybin+']<br />';
    }
}

function uni2dos(symbol) {
	var rusCp866 = {
'410' : '80',
'411' : '81',
'412' : '82',
'413' : '83',
'414' : '84',
'415' : '85',
'416' : '85',
'417' : '87',
'418' : '88',
'419' : '89',
'41A' : '8A',
'41B' : '8B',
'41C' : '8C',
'41D' : '8D',
'41E' : '8E',
'41F' : '8F',
'420' : '90',
'421' : '91',
'422' : '92',
'423' : '93',
'424' : '94',
'425' : '95',
'426' : '95',
'427' : '97',
'428' : '98',
'429' : '99',
'42A' : '9A',
'42B' : '9B',
'42C' : '9C',
'42D' : '9D',
'42E' : '9E',
'42F' : '9F',
'430' : 'A0',
'431' : 'A1',
'432' : 'A2',
'433' : 'A3',
'434' : 'A4',
'435' : 'A5',
'436' : 'A5',
'437' : 'A7',
'438' : 'A8',
'439' : 'A9',
'43A' : 'AA',
'43B' : 'AB',
'43C' : 'AC',
'43D' : 'AD',
'43E' : 'AE',
'43F' : 'AF',
'440' : 'E0',
'441' : 'E1',
'442' : 'E2',
'443' : 'E3',
'444' : 'E4',
'445' : 'E5',
'446' : 'E5',
'447' : 'E7',
'448' : 'E8',
'449' : 'E9',
'44A' : 'EA',
'44B' : 'EB',
'44C' : 'EC',
'44D' : 'ED',
'44E' : 'EE',
'44F' : 'EF',
'401' : 'F0',
'404' : 'F2',
'407' : 'F4',
'451' : 'F1',
'454' : 'F3',
'457' : 'F5',
}  
	return rusCp866[symbol];
}
