<?php /* 
	Yu Fu
	CS385
	2014
	reg.php 
	which uses to check register action from register.php
	*/?>
<?php
	if(isset($_POST['Register']))
	{
		$username = $_POST['username'];
		$password = $_POST['password'];
		$repw = $_POST['repw'];
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
		//check if username exist
		$check_query = mysql_query("select user_id from users where username='$username' limit 1");
		if(mysql_fetch_array($check_query)){
			echo 'Error: Username ',$username,' exist! <a href="javascript:history.back(-1);">RETURN</a>';
			exit;
		}
		//insert database
		$password = MD5($password);
		$regdate = time();
		$sql = "INSERT INTO users(username,password,regdate)VALUES('$username','$password',
		$regdate)";
		if(mysql_query($sql,$conn)){
			exit('User register success <a href="main.php">LOGIN</a>');
		} else {
			echo 'ERROR: ',mysql_error(),'<br />';
			echo 'Click <a href="javascript:history.back(-1);">Return</a> to retry';
		}
	}
	else if (isset($_POST['Cancel']))
	{
		header('Location:main.php'); 
	}
?>