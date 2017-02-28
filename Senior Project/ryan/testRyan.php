<?php
//CONNECT TO DATABASE:

//require_once 'sqlUtilities.php';
	//These will be used throughout -- at least $mysqli_link will
$db_hostname='localhost';
$db_database='bfv';
$db_username='root';
$db_password='cs385rox';

	//Database connection
$mysqli_link = new mysqli($db_hostname, $db_username, $db_password, $db_database);
if ($mysqli_link->connect_errno) 
	die ("Database connection failed: ".mysqli_connect_error()."<br>");
else
	echo 'db connection okey-dokey<br>';
?>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>
<?php
	$result = mysql_query("SELECT * FROM ttax");
	$row1   = mysql_fetch_array ($result);
	foreach ($result as $row)
	{
		echo '|'.$row['rid'].'=>'.$row['taxon'].'|<br>';
	}
?>

</body>

</html>
