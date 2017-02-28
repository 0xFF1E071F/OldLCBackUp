<?php
/*	Yu Fu
	CS 385
	2014
	tag PHP
 	which read in tags from databse
	will work for catagory posts in future*/
	
	include 'conn.php';
	$check_query = mysql_query("SELECT * FROM tags") or die(mysql_error());
	if (isset($_GET['Refresh']))
	{
		$tags = array(); 
		$show = mysql_query("select tagname from tags");
		while ($row = mysql_fetch_row($show))
		{
			if ($tags[$i]==theForm.$tags[$i] && theForm.$tags[$i].checked)
			{
			}
		}
		 // document.forms['contactus'].action='action1.php';
		 // document.forms['contactus'].target='frame_result1';
		 // document.forms['contactus'].submit();
	 
		 // document.forms['contactus'].action='action2.php';
		 // document.forms['contactus'].target='frame_result2';
		 // document.forms['contactus'].submit();
	
	}
?>

<fieldset>
<legend>Tag</legend>
	<form name="tags" method="get" action="<?php echo $_SERVER['PHP_SELF'];?>" onSubmit="return checkCheckBoxes(this)">
	<p>
	<?php
		$tags = array(); 
		$show = mysql_query("select tagname from tags");
		while ($row = mysql_fetch_row($show))
			$tags[] = $row[0]; 
		for($i=0;$i<sizeof($tags);$i++)
			if(!empty($tags[$i]))
		echo "<input type='checkbox' name='$tags[$i]'>".$tags[$i];
		if (sizeof($tags)==0)
		{
			echo "No tags.";
		}	
	?>
		<p/>
	<p>
		<input type="submit" name="Refresh" value="Refresh" class="right" />
		</p>
		</form>
	</fieldset>
