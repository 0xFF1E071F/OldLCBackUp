<?php
define('DB_HOST', 'localhost');
//username
define('DB_USER', 'root');
//password
define('DB_PASSWORD', '');
//database name
define('DB_NAME','clubdb');
// get connection
$conn = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD);
// conn fail
if (!$conn){
	die("connection fail." . mysql_error());
}
//select db
mysqli_select_db($conn,DB_NAME);
?>