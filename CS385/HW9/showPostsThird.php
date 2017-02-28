<?php
/*	Yu Fu
	CS 385
	2014
	showpostsFirstColumn PHP
	which read in posts from databse
	and print*/

	include "conn.php";
	$check_query = mysql_query("SELECT * FROM tags") or die(mysql_error());
	
	//getTags;
	if (!empty($_GET['tags']))
		$getTags=$_GET['tags'];



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
		
		if (empty($_GET['tags']))	// if no tags checked, print all
		{
			if ($row['post_id']%3==0)	// use to separate into 3 lines 
			{
				?>	
				<li>
				<h2><?php echo "Title:".$row['title'];?></h2><br />
				<p><?php echo $text[0];?></P>
				<p><?php echo "Poster: ",$user[0],"       ";  echo "   Category: ",$tag[0]; ?></P>
				</li>
				<?php
			}
		}
		else // print checked
		{
			for($i=0;$i<count($getTags);$i++)
			{
				if ($tag[0]==$getTags[$i]&&$row['post_id']%3==0)	// use to separate into 3 lines 
				{
					?>	
					<li>
					<h2><?php echo "Title:".$row['title'];?></h2><br />
					<p><?php echo $text[0];?></P>
					<p><?php echo "Poster: ",$user[0],"       ";  echo "   Category: ",$tag[0]; ?></P>
					</li>
					<?php
				}
			}
		}
	}	
?>		
</div><br>