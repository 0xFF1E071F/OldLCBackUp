<?php
/*
Convert all BFV code in database to html code
Just run this php will replace all in database
*/
include'conn.php';

ini_set('max_execution_time', 1300);
echo "set 'max_execution_time to 1300.";
echo "</br>start:";
//replace pub
//A
$sql="UPDATE ref SET pub = REPLACE (pub,'A%A','&Aacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'A%C','&Agrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'A%D','&Acirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'A%E','&Atilde')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'A%F','&Auml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'A%H','&Aacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'A%K','&Acedil')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'A%R','&#461')";

//a
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%A','&aacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%C','&agrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%D','&acirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%E','&atilde')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%F','&auml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%H','&aacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%K','&acedil')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%R','&#462')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'a%J','&nbsp')";
//C
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'C%A','&Cacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'C%B','&Ccedil')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'C%J','&#268')";

//c
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'c%A','&cacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'c%B','&ccedil')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'c%J','&#269')";

//D
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'D%S','&ETH')";

//d
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'d%S','&eth')";

//E
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'E%A','&Eacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'E%C','&Egrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'E%D','Ecirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'E%F','&Euml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'E%J','&#282')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'E%K','&Ecedil')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'E%M','&#278')";

//e
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'e%A','&eacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'e%C','&egrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'e%D','ecirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'e%F','&euml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'e%J','&#283')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'e%K','&ecedil')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'e%M','&#279')";

//G
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'G%R','&#486')";

//g
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'g%R','&#487')";

//I
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'I%A','&Iacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'I%C','&Igrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'I%D','&Icirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'I%F','&Iuml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'I%H','&Iacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'I%M','&#298')";

//i
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'i%A','&iacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'i%C','&igrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'i%D','&icirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'i%F','&iuml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'i%H','&iacute')";

//L
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'L%S','&#321')";

//l
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'l%S','&#322')";

//N
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'N%A','&Nacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'N%E','&Ngrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'N%J','&#327')";

//n
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'n%A','&nacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'n%E','&ngrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'n%J','&#328')";

//O
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'O%A','&Oacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'O%C','&Ograve')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'O%D','&Ocirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'O%E','&Otilde')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'O%F','&Ouml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'O%L','&#336')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'O%N','&#332')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'O%S','&Oslash')";

//o
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%A','&oacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%C','&ograve')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%D','&ocirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%E','&otilde')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%F','&ouml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%L','&#337')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%N','&#333')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%S','&oslash')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'o%R','&nbsp')";

//R
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'R%J','&#344')";

//r
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'r%J','&#345')";

//S
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'S%A','&Sacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'S%B','&Scedil')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'S%J','&#352')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'S%K','&Scedil')";

//s
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'s%A','&sacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'s%B','&scedil')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'s%J','&#353')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'s%K','&scedil')";

//T
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'T%B','&Tcedil')";

//t
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'t%B','&tcedil')";

//U

mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'U%A','&Uacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'U%C','&Ugrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'U%D','&Ucirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'U%F','&Uuml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'U%H','&Uacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'U%N','&#362')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'U%R','&#467')";

//u

mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'u%A','&uacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'u%C','&ugrave')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'u%D','&ucirc')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'u%F','&uuml')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'u%H','&uacute')";

mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'u%N','&#363')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'u%R','&#468')";

//Y
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'Y%A','&Yacute')";

//y
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'y%A','&yacute')";

//Z
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'Z%A','&Zacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'Z%J','&#381')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'Z%M','&#379')";

//z
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'z%A','&zacute')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'z%J','&#382')";
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'z%M','&#380')";
//--
mysqli_query($conn,$sql);
$sql="UPDATE ref SET pub = REPLACE (pub,'--','&#45')";
mysqli_query($conn,$sql);



mysqli_close($conn);
echo "All replace function done!";
?>