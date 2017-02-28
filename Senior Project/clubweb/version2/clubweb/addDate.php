<!--
--------------------------------------------
			 addDate.php
				Yu Fu
			  2015-11-6
--------------------------------------------
create a select date input 
and a button to submit this date to database
-->
<div>
	<fieldset>
	<legend>Add New Date:</legend>
	<form name="dateForm" method="post"  onSubmit="return InputCheck(this)" action="updateDates.php" >	
		<label for="date">Select A new Date:</label>
		<p>
			<input id="date" name="date" type="date" class="input" /> ( The selected date should after today.)
		</p>
		<input type="submit" name="addDate" id= "submit" value="AddDate "/>
	</form>
	
	<?php 
	// show user the result of their action
		if (isset($_GET['result']))
		{
			if ($_GET['result']=="exist")
			{
				echo "Date exist, please select a new date!";
			}
			if ($_GET['result']=="add")
			{
				echo "Date added successful!";
			}
		}
		unset($_GET['result']);
	?>
	</fieldset>
</div>