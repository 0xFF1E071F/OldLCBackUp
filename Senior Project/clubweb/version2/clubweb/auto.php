<!--
--------------------------------------------
			   auto.php
				Yu Fu
			  2015-11-05
--------------------------------------------
this is update the dalender date
and set the last update time in autoupdate.txt
-->
<?php
$time = time();
$file = 'autoupdate.txt';
$filemtime = filemtime($file);
if($time - $filemtime > 60*60*24)
{
    $h = fopen($file,'wb+');
    $content = "This is update at time: ".date('Y-m-d H:i:s', $time);
    fwrite($h,$content);
    fclose($h);
    touch($file);
	//=============
	include ('autoupdate.php');
} 


?>
