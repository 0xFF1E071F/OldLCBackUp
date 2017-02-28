<?php
/*	Yu Fu
	CS 385
	2014
	showpostsFirstColumn PHP
	which read in posts from databse
	and print*/
	$conn = @mysql_connect("localhost","root","cs385rox");
	if (!$conn){
			die("connection fail." . mysql_error());
	}
	mysql_select_db("collectlikes", $conn);
	$check_query = mysql_query("SELECT * FROM tags") or die(mysql_error());

?>
<div class="content_block">
<?php
	$result = mysql_query("select * from posts");
			 
	while($row=mysql_fetch_array($result))
	{
		$getText =mysql_query( "SELECT text FROM text WHERE text_id = $row[text_id]");
		$getUser = mysql_query( "SELECT username FROM users WHERE user_id = $row[user_id]");
		$getTag = mysql_query( "SELECT tagname FROM tags WHERE tag_id = $row[tag_id]");
		$text= mysql_fetch_row($getText);
		$user= mysql_fetch_row($getUser);
		$tag= mysql_fetch_row($getTag);	
		if ($row['post_id']%3==2){?>
		<h2><?php echo "Title:".$row['title'];?></h2><br />
		<p><?php echo $text[0];?></P>
		<p><?php echo "Poster: ",$user[0],"       ";  echo "   Category: ",$tag[0]; ?></P>
		<?php
	}
	}
	if (mysql_num_rows($result)==0)
		echo "No posts";
?>		
</div><br>