<?php /*
--------------------------------------------
			 deleteDate.php
				Yu Fu
			  2015-11-6
--------------------------------------------
create a date select 
and a button to submit it to database
*/ ?>
<div>
<fieldset>
	<legend>Delete Date:</legend>
	<form name="deleteDateForm" method="post" action="updateDates.php" >	
		<select name="selectDate">
		<?php
		//get all dates
		$sql = "SELECT * from dates ORDER BY date";
		$getDate = mysqli_query($conn,$sql);
		$today=strtotime("today-1day");
		while($daterow = mysqli_fetch_array($getDate)) 
		{
			if($daterow['date'] > $today)
			{
		?>
				<option value=<?php echo $daterow['id'];?>>
					<?php echo date('M-d-Y', $daterow['date']);?>
				</option>
		<?php
			}
		}
		?>
		</select>
		<input type="submit" name="deleteDate" id= "deleteDate" value="DeleteDate">
	</form>
</fieldset>	
</div>