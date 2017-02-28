<?php /* 
	Yu Fu
	cs395
	2014
	logout.php */
/**cookies log out action*/ 
if(isset($_COOKIE['user_id']))
{ 
	//set each cookie time
	setcookie('user_id','',time()-3600); 
	setcookie('username','',time()-3600); 
} 
//location to home page
$home_url = 'main.php'; 
header('Location:'.$home_url); 


?> 