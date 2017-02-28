<?php 
	/*
	--------------------------------------------
				logout.php
					Yu Fu
				  2015-10-3
	--------------------------------------------
	this php log uiser out
	and return back to index
	*/
	if(isset($_COOKIE['user_id']))
	{ 
		//set each cookie time
		setcookie('user_id','',time()-12000); 
		setcookie('username','',time()-12000); 
	} 
	//location to home page
	$home_url = 'index.php'; 
	header('Location:'.$home_url); 
?> 