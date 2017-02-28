<?php
/*
====================================================================
					  charConv.php
					  Nov 05.2015
					     Yu Fu
====================================================================
this this char covert function page
also include a function whihc can make limited replace for any char in string
*/

$GLOBALS['normalizeChars'] = array(
//A
'A%A'=>'&Aacute','A%C'=>'&Agrave','A%D'=>'&Acirc','A%E'=>'&Atilde','A%F'=>'&Auml','A%H'=>'&Aacute','A%K'=>'A','A%R'=>'&#461','A%M'=>'','A%N'=>'',
//a
'a%A'=>'&aacute','a%C'=>'&agrave','a%D'=>'&acirc','a%E'=>'&atilde','a%F'=>'&auml','a%H'=>'&aacute','a%K'=>'a','a%R'=>'&#462','a%J'=>'','a%N'=>'&nbsp','a%B'=>'&nbsp','a%M'=>'&nbsp','a%L'=>'&nbsp','a%U'=>'&nbsp','a%Z'=>'&nbsp','a%d'=>'','a%O'=>'&nbsp','a%r'=>'&nbsp','a%S'=>'&agrave','a%n'=>'&nbsp',
//B
'B%B'=>'&nbsp',
//b
'b%A'=>'&nbsp','b%S'=>'&nbsp',
//C
'C%A'=>'&Cacute','C%B'=>'&Ccedil','C%J'=>'&#268','C%C'=>'&nbsp','C%R'=>'&nbsp','C%M'=>'&nbsp','C%H'=>'&nbsp','C%j'=>'',
//c
'c%A'=>'c','c%B'=>'&ccedil','c%J'=>'&#269','c%K'=>'&nbsp','c%R'=>'&nbsp','c%D'=>'&nbsp','c%C'=>'&nbsp','c%o'=>'&nbsp','c%E'=>'&nbsp','c%F'=>'&nbsp',
//D
'D%S'=>'&ETH',
//d
'd%S'=>'&eth','d%B'=>'&nbsp','d%C'=>'&nbsp','d%A'=>'',
//E
'E%A'=>'&Eacute','E%C'=>'&Egrave','E%D'=>'Ecirc','E%F'=>'&Euml','E%J'=>'&#282','E%K'=>'&Ecedil','E%M'=>'&#278','E%R'=>'&nbsp',
'E%a'=>'&nbsp','E%t'=>'&nbsp','E%R'=>'&nbsp','E%H'=>'',
//e
'e%A'=>'&eacute','e%C'=>'&egrave','e%D'=>'ecirc','e%F'=>'&euml','e%J'=>'&#283','e%K'=>'e','e%M'=>'&#279','e%a'=>'&nbsp','e%R'=>'&nbsp','e%L'=>'&nbsp','e%N'=>'&nbsp','e%t'=>'&nbsp','e%B'=>'&nbsp','e%E'=>'&nbsp','e%H'=>'t','e%T'=>'l','e%s'=>'&eacute','e%k'=>'&nbsp','e%O'=>'&nbsp','e%c'=>'&nbsp','e%W'=>'&egrave',
//F
'F%d'=>'&nbsp','F%M'=>'&nbsp',
//f
'f%M'=>'&nbsp','f%F'=>'&nbsp','f%H'=>'&nbsp','f%C'=>'&nbsp','f%H'=>'&nbsp',
//G
'G%R'=>'&#486',
//g
'g%R'=>'&#487','g%J'=>'&#487','g%e'=>'','g%H'=>'&nbsp',
//H
'H%E'=>'','H%F'=>'',
//I
'I%A'=>'&Iacute','I%C'=>'&Igrave','I%D'=>'&Icirc','I%F'=>'&Iuml','I%H'=>'&Iacute','I%M'=>'&#298','I%U'=>'&nbsp','I%J'=>'&nbsp','I%N'=>'',
//i
'i%A'=>'&iacute','i%C'=>'&igrave','i%D'=>'&icirc','i%F'=>'&iuml','i%H'=>'&iacute','i%J'=>'&#321','i%R'=>'&nbsp','i%M'=>'&nbsp','i%S'=>'&nbsp','i%E'=>'&nbsp','i%$'=>'&nbsp','i%a'=>'&nbsp','i%N'=>'&nbsp','i%r'=>'&nbsp','i%L'=>'&nbsp','i%T'=>'&nbsp','i%B'=>'&nbsp','i%N'=>'',
//j
'j%S'=>'&nbsp','j%D'=>'&nbsp','j%F'=>'&nbsp',
//K
'K%S'=>'&nbsp','K%R'=>'&nbsp',
//L
'L%S'=>'&#321','L%N'=>'L',
//l
'l%S'=>'&#322','l%C'=>'','l%D'=>'&nbsp','l%N'=>'',
//M
'M%A'=>'&nbsp',
//m
'm%A'=>'&nbsp','m%D'=>'&nbsp','m%E'=>'&nbsp','m%C'=>'&nbsp',
//N
'N%A'=>'N','N%E'=>'&Ntilde','N%J'=>'&#327','N%C'=>'&nbsp',
//n
'n%A'=>'n','n%E'=>'&ntilde','n%J'=>'&#328','n%D'=>'&nbsp','n%C'=>'&nbsp','n%M'=>'','n%N'=>'&nbsp','n%B'=>'','n%R'=>'','n%F'=>'','n%K'=>'&nbsp',
//O
'O%A'=>'&Oacute','O%C'=>'&Ograve','O%D'=>'&Ocirc','O%E'=>'&Otilde','O%F'=>'&Ouml','O%L'=>'&#336','O%N'=>'&#332','O%S'=>'&Oslash',
//o
'o%A'=>'&oacute','o%C'=>'&ograve','o%D'=>'&ocirc','o%E'=>'&otilde','o%F'=>'&ouml','o%L'=>'&#337','o%N'=>'&#333','o%S'=>'&oslash',
'o%R'=>'&nbsp','o%s'=>'&nbsp','o%J'=>'&nbsp','o%B'=>'&nbsp','o%M'=>'&nbsp','o%X'=>'&nbsp','o%K'=>'&nbsp','o%l'=>'&nbsp','o%H'=>'&nbsp','o%f'=>'&ouml','o%O'=>'&ouml',
//P
'P%A'=>'&nbsp','P%J'=>'',
//Q
'Q%F'=>'&nbsp',
//q
'q%L'=>'&nbsp','q%B'=>'&nbsp','q%F'=>'&nbsp',
//R
'R%J'=>'&#344','R%N'=>'','R%R'=>'',
//r
'r%J'=>'&#345','r%F'=>'&nbsp','r%A'=>'&nbsp','r%M'=>'&nbsp','r%R'=>'&nbsp','r%e'=>'&nbsp','r%C'=>'&nbsp','r%E'=>'&nbsp','r%D'=>'',
//S
'S%A'=>'S','S%B'=>'S','S%J'=>'&#352','S%K'=>'&Scedil','S%R'=>'','S%H'=>'','S%C'=>'&nbsp','S%D'=>'&nbsp','S%M'=>'&nbsp','S%F'=>'',
//s
's%A'=>'s','s%B'=>'s','s%J'=>'&#353','s%K'=>'&scedil','s%S'=>'&nbsp','s%C'=>'&nbsp','s%R'=>'&nbsp','s%a'=>'s','s%D'=>'&nbsp',
//T
'T%B'=>'&Tcedil',
//t
't%B'=>'t','t%A'=>'&nbsp','t%D'=>'','t%M'=>'','t%C'=>'&nbsp',
//U
'U%A'=>'&Uacute','U%C'=>'&Ugrave','U%D'=>'&Ucirc','U%F'=>'&Uuml','U%H'=>'&Uacute','U%N'=>'&#362','U%R'=>'&#467','U%K'=>'&nbsp','U%J'=>'&nbsp','U%L'=>'&nbsp',
//u
'u%A'=>'&uacute','u%C'=>'&ugrave','u%D'=>'&ucirc','u%F'=>'&uuml','u%H'=>'&uacute','u%N'=>'&#363','u%R'=>'&#468','u%M'=>'&nbsp','u%r'=>'',
'u%E'=>'','u%K'=>'','u%L'=>'&nbsp','u%s'=>'&nbsp','u%J'=>'&nbsp','u%f'=>'&nbsp','u%B'=>'&nbsp',
//v
'v%R'=>'&nbsp','v%J'=>'&nbsp',
//Y
'Y%A'=>'&Yacute','Y%F'=>'&nbsp',
//y
'y%A'=>'&yacute', 'y%F'=>'&nbsp','y%C'=>'t','y%J'=>'y','y%R'=>'',
//Z
'Z%A'=>'Z','Z%J'=>'&#381','Z%M'=>'&#379','Z%R'=>'&nbsp','Z%C'=>'','Z%H'=>'',
//z
'z%A'=>'z','z%J'=>'&#382','z%M'=>'&#380','z%L'=>'&nbsp','z%R'=>'&nbsp','z%H'=>'','z%K'=>'','z%F'=>'',
//--
'--'=>'&#45',
//.
'.%A'=>'&nbsp','.%R'=>'&nbsp',
//
'%A'=>'&nbsp','2%N'=>'','8%M'=>'','+%M'=>'',
);

// this is replace function
// which can help me only replace on char in string.
// i use it to replace "^xxxx^" in string
// as "^xxxx^" should be "<I>xxxx</I>"
function str_replace_limit($search,$replace,$content,$limit=-1){
    if(is_array($search)){
        foreach ($search as $k=>$v){
            $search[$k]='`'.preg_quote($search[$k],'`').'`';
        }
    }else{
        $search='`'.preg_quote($search,'`').'`';
    }
	$content=preg_replace("/alt=([^ >]+)/is",'',$content);
    return preg_replace($search,$replace,$content,$limit);
}


?>