<!-- 
--------------------------------------------
			  login.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php check username and passwork correct or not 
and set user cookies

-->
<?php
//reg
	require_once 'conn.php'; 

	if (isset($_POST['submit']))
	{	
		//if sumbit login information, run this. 
		$dbc = mysqli_connect(DB_HOST,DB_USER,DB_PASSWORD,DB_NAME); 
		$user_username = mysqli_real_escape_string($dbc,trim($_POST['username'])); 
		$user_password = mysqli_real_escape_string($dbc,trim($_POST['password'])); 

		if(!empty($user_username)&&!empty($user_password))
		{ 
			//Mysql password use sha1 
			$query = "SELECT id, username,password FROM users WHERE username = '$user_username' AND "."password = sha1('$user_password')"; 
			//check username and password
			$data = mysqli_query($dbc,$query); 
			//if exist username and password, set cookie and reload main
			if(mysqli_num_rows($data)==1)
			{ 
				$row = mysqli_fetch_array($data); 
				setcookie('user_id',$row['id'],time()+86400*365*10); 
				setcookie('username',$row['username'],time()+86400*365*10); 
				$home_url = 'autoupdate.php'; 
				header('Location: '.$home_url); 
			}
			else
			{//if no exist information, show error msg
				$error_msg = 'Sorry, username or password wrong.'; 
				exit(' username or password wrong! <a href="index.php">Return to try again.</a>');
			} 
		}
		else
		{
			exit('username and password cannot be empty <a href="index.php">Return</a>');
		} 
	}
?>

<script type="text/javascript">
	public function alterMsg()
	{
		 alert("Username can not be empty!");
	}
	
</script>
