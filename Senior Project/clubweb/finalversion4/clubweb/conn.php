<?php
	/* 
	--------------------------------------------
				  conn.php
					Yu Fu
				  2015-10-3
	--------------------------------------------
	conn.php is settings for connecting to database
	*/

	define('DB_HOST', 'localhost');
	define('DB_USER', 'root');
	define('DB_PASSWORD', '');//tciafbCS@LCin
	define('DB_NAME','clubdb');
	
	// get connection
	$conn = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD);
	
	// conn fail
	if (!$conn)
		die("Database connection failed." . mysql_error());
	
	//select db
	mysqli_select_db($conn,DB_NAME);
?>