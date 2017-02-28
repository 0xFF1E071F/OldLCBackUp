<!--
--------------------------------------------
			   reload.php
				Yu Fu
			  2015-11-05
--------------------------------------------
This php works to upadte our calender table depens on database
-->
<?php
	$time = time();
	$file = 'autoupdate.txt';
	$filemtime = filemtime($file);
	if($time - $filemtime < 10)
	{
		//refresh page if the calender database just updated
		echo "<script>
				location.reload();
				</script>";
	} 
?>