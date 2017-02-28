<?php /*
	Yu Fu
	CS385
	2014
	This is post.php 
	which checks action from post page*/?>
<?php
	if(isset($_POST['post']))
	{
		$title = $_POST['title'];
		$content = $_POST['content'];
		$currentUser=$_COOKIE['user_id'];
		$tag = $_POST['tag'];
		//include database file
		include('conn.php');
		//check 
		//insert database
		$newtag = "INSERT INTO tags(tagname)VALUES('$tag')";
		mysql_query($newtag,$conn);
		$tagid=mysql_INSERT_ID();
		$newtext = "INSERT INTO text(text)VALUES('$content')";
		mysql_query($newtext,$conn);
		$textid=mysql_INSERT_ID();
		$newcontent = "INSERT INTO posts(title,text_id,tag_id,user_id)VALUES('$title','$textid','$tagid','$currentUser')";
		if(mysql_query($newcontent,$conn)){
			exit('Successful post! <a href="main.php">Return Main Page.</a>');
		} else {
			echo 'ERROR: ',mysql_error(),'<br />';
			echo 'Click <a href="javascript:history.back(-1);">Return</a> to retry';
		}
	}

?>