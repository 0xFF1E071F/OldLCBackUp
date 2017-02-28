<?php /* 
	Yu Fu
	CS385
	2014
	searchResult.php
	which to users the search results
*/
	include "conn.php";
	$check_query = mysql_query("SELECT * FROM posts") or die(mysql_error());
	if ($_POST['Search'])
	{
		$searchKey=$_POST['searchKey'];
		$sql = "SELECT * FROM Posts WHERE title LIKE '%".$searchKey."%'"; 
		$r_query = mysql_query($sql);
	}
?>
<div class="search_block" >
<?php
	if (mysql_num_rows($r_query)==0)
		echo 'No Search result found!    <a href="javascript:history.back(-1);">RETURN</a>';
	else if(empty($_POST['searchKey']))
	{
		echo 'You need enter a search key!     <a href="javascript:history.back(-1);">RETURN</a>';
	}
	else
	{	
		while($row=mysql_fetch_array($r_query))
		{
			$getText =mysql_query( "SELECT text FROM text WHERE text_id = $row[text_id]");
			$getUser = mysql_query( "SELECT username FROM users WHERE user_id = $row[user_id]");
			$getTag = mysql_query( "SELECT tagname FROM tags WHERE tag_id = $row[tag_id]");
			$text= mysql_fetch_row($getText);
			$user= mysql_fetch_row($getUser);
			$tag= mysql_fetch_row($getTag);	
		?>	
		<li>
		<h2><?php echo "Title:".$row['title'];?></h2><br/>
		<p><?php echo $text[0];?></P>
		<p><?php echo "Poster: ",$user[0],"       ";  echo "   Category: ",$tag[0]; ?></P>
		</li>
		<?php
		}
	}
?>		
</div><br>