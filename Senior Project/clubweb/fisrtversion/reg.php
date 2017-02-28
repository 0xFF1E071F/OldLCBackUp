<!-- 
--------------------------------------------
			   reg.php
				Yu Fu
			  2015-10-3
--------------------------------------------
-->
<?php

if(isset($_POST['cancel']))
{
	header("location:index.php");
}
else if (isset($_POST['submit']))
{	
	$username = $_POST['username'];
	$password = $_POST['password'];
	$repw = $_POST['repw'];
	$tel = $_POST['tel'];
	$fname = $_POST['fname'];
	$lname = $_POST['lname'];
	//check register information
	if(!preg_match('/^[\w\x80-\xff]{3,15}$/', $username)){
		exit('Hmm...that doesn\'t look like an correct username.<a href="javascript:history.back(-1);">Return</a>');
	}
	if(strlen($password) < 6){
		exit('Your password is too short! You need 6+ characters.<a href="javascript:history.back(-1);">Return</a>');
	}
	if($password!=$repw){
		exit('Your twice passwords are not same! <a href="javascript:history.back(-1);">Return</a>');
	}

	//include database file
	include('conn.php');
	$conn = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD);
					if (!$conn){
						die("connection fail." . mysql_error());
					}
					mysqli_select_db($conn,DB_NAME);
					
	//check if username exist
	$check_query = mysqli_query($conn,"select id from users where username='$username' limit 1");
	if(mysqli_fetch_array($check_query)){
		echo 'Error: Username ',$username,' exist! <a href="javascript:history.back(-1);">RETURN</a>';
		exit;
	}
	
	//insert database
	$password = sha1($password);
	$sql = "INSERT INTO users(username,password)VALUES('$username','$password')";
	
	if(mysqli_query($conn,$sql)){
		$last_user_id=mysqli_insert_id($conn);
		$sql = "INSERT INTO uinfo(f_name,l_name,tel,uid)VALUES('$fname','$lname','$tel','$last_user_id')";
		if (mysqli_query($conn,$sql))
		{
			exit('User register success <a href="index.php">LOGIN</a>');
		}
	} else {
		echo 'ERROR: ',mysql_error(),'<br />';
		echo 'Click <a href="javascript:history.back(-1);">Return</a> to retry';
	}

	exit(' <a href="index.php">Return to fill username and password.</a>'); 
}

?>

