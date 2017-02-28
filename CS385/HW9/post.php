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
		//check if tagname exist
		$check_query = mysql_query("select tagname from tags where tagname='$tag' limit 1") or die(mysql_error());

		if(mysql_fetch_array($check_query))//if exist tag name, just get the tag id
		{
			$row = mysql_fetch_array(mysql_query("select tag_id from tags where tagname='$tag' limit 1"));
			$tagid = $row[0];
		}
		else	// insert tagname in database and create a tag id
		{
			//insert database
			mysql_query( "INSERT INTO tags(tagname)VALUES('$tag')",$conn);
			$tagid=mysql_INSERT_ID();
		}
		
		$newtext = "INSERT INTO text(text)VALUES('$content')";
		mysql_query($newtext,$conn);
		$textid=mysql_INSERT_ID();
		$newcontent = "INSERT INTO posts(title,text_id,tag_id,user_id)VALUES('$title','$textid','$tagid','$currentUser')";
		if(mysql_query($newcontent,$conn)){
			exit('Successful post! <a href="index.php">Return Main Page.</a>');
		} else {
			echo 'ERROR: ',mysql_error(),'<br />';
			echo 'Click <a href="javascript:history.back(-1);">Return</a> to retry';
		}
	}

?>