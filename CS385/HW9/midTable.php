<?php 
/*	Yu Fu
	CS 385
	2014
	midTable PHP
	This is mid table php 
	which is area of Posted information*/
	include 'conn.php';
	//databases
	$allTitles = mysql_query("SELECT title FROM posts") or die(mysql_error());	

?>	

<table style="width: 100%;height:100%" border="0">
<tr>

<?php if (isset($_POST['Search']))
{?>
	<td id="searchResult">
<?php
	include "searchResult.php";?>
	</td>
<?php
}
else
{?>
		<td id="threeLine">
			<?php include 'ShowPostsFirst.php';?>
		</td>
		<td id="threeLine">	
			<?php include 'ShowPostsSecond.php';?>
		</td>
		<td id="threeLine">
			<?php include 'ShowPostsThird.php';?>
		</td>
<?php }?>
</tr>
</table>