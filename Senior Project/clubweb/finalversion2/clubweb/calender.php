<!--
--------------------------------------------
			  calender.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php creates calender frame
-->
<?php
//reg
	require_once 'conn.php'; 
	if(!isset($_POST['submit']))
	{
    	header("location:cal.php");
	}
	else
	{
		$date = $_POST['date'];
				
		$shortdate=strtotime($date);
	
		$check_query = mysql_query("select date from dates where date='$shortdate' limit 1");
		if(mysql_fetch_array($check_query)){
			echo 'Error: Current Date ',$date,' exist! <a href="javascript:history.back(-1);">RETURN</a>';
			exit;
		}
		//insert date
		$sql = "INSERT INTO dates(date)VALUES('$shortdate')";
		
		if(mysql_query($sql,$conn)){
			exit('Date '.$date. ' added successfully! Bank to<a href="index.php"> Calender</a>');
		} else {
			echo 'ERROR: ',mysql_error(),'<br />';
			echo 'Click <a href="javascript:history.back(-1);">Return</a> to retry';
		}
	}
	

?>

