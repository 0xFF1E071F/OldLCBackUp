<!-- 
--------------------------------------------
			  conn.php
				Yu Fu
			  2015-10-10
--------------------------------------------
conn.php is settings for connecting to database
-->
<?php
define('DB_HOST', 'localhost');
//username
define('DB_USER', 'root');
//password
define('DB_PASSWORD', '');
//database name
define('DB_NAME','bfv');
// get connection
$conn = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD);
// conn fail
if (!$conn){
	die("Database connection failed." . mysql_error());
}

//select db
mysqli_select_db($conn,DB_NAME);
mysqli_query($conn,"set names 'utf8'");    
?>