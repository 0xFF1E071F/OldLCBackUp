<!-- 
--------------------------------------------
		     updatepw.php
				Yu Fu
			  2015-11-18
--------------------------------------------
update pw in db
-->

<?php
	require_once 'conn.php';
	$opw=$_POST['oldpw'];
	$npw=$_POST['password'];
	$nrepw=$_POST['repw'];
	
	$user=$_COOKIE['user_id'];
	$check_old_pw="select password from users where id = $user";
	if ($data = mysqli_query($conn,$check_old_pw))
	{
		if(mysqli_num_rows($data)==1) 
		{
			$row_old = mysqli_fetch_array($data);
			if ($row_old['password']==sha1($opw))
			{
				if($npw==$nrepw)
				{
					$update_pw="update users set password ='".sha1($npw)."' where id = '$user'";
					if (mysqli_query($conn,$update_pw))
					{
							// logout users
							if(isset($_COOKIE['user_id']))
							{ 
								//set each cookie time
								setcookie('user_id','',time()-12000); 
								setcookie('username','',time()-12000); 
							} 
								//location to home page
							$home_url = 'index.php?result=pwsuc'; 
					}
					else
					{
						$home_url = 'password.php?result=dbfail';
					}
				}
				else
				{
					$home_url = 'password.php?result=repw'; 
					
				}
			}
			else
			{
				$home_url = 'password.php?result=oldfail'; 
			}
		}
		else
		{
			$home_url = 'password.php?result=dbfail'; 
		}
	}
	header('Location:'.$home_url); 
	exit;
?>