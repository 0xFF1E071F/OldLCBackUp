<?php
/*	Yu Fu
	CS 385
	2014
	tag PHP
 	which read in tags from databse
	will work for catagory posts in future*/
	include 'conn.php';
?>

<fieldset>
<legend>Tags: </legend>
	<form name="tags" method="get" action="<?php echo $_SERVER['PHP_SELF'];?>" onSubmit="return checkCheckBoxes(this)">
	<p>
	<?php
		$tags = array(); 
		$show = mysql_query("select tagname from tags");
		while ($row = mysql_fetch_row($show))
			$tags[] = $row[0]; 
		for($i=0;$i<sizeof($tags);$i++)
			if(!empty($tags[$i]))
				echo "<input type='checkbox' name='tags[]' value='$tags[$i]'>".$tags[$i];
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
