<!-- 
--------------------------------------------
			 changeDay.php
				Yu Fu
			  2015-11-12
--------------------------------------------
This is php for update default weekday
-->
<script language=JavaScript>
function InputCheck(dateForm)
{
  if (dateForm.date.value == "")
  {
    alert("Please select a vaild date!");
    dateForm.date.focus();
    return (false);
  }
}
</script>
<?php
	// this is weekday funciton file
	include ('weekday.php');
?>
<div class="reg">
<fieldset>
	<legend>Change Meeting Date</legend>
	<form name="RegForm" method="post" action="updatedefDay.php" onSubmit="return InputCheck(this)">
	<table>  
    <tr>  
	<?php
		if(isset($_GET['result']))
		{
			echo '<center><span class="messageFromURLArgument">';
			switch ($_GET['result'])
			{
				case "suc": 	echo "Successful change a default weekday!"; 				break;
				case "nsd": 	echo "Error: Unsuccessfully to change a default day.</br>You must select a date on the same day as weekday. "; 				break;
			}
			echo "</span></center>";
		}
		require_once 'conn.php'; 
		$get_new_date="select * from defday where isnew = 1";
		$date = mysqli_query($conn,$get_new_date); 
		if(mysqli_num_rows($date)==1)
		{ 
			$row = mysqli_fetch_array($date); 
			echo '<span class="messageForDate">';
			echo "Current default weekday is ".weekday($row['weekday']).", from date: ". date('M-d-Y',$row['date']);
			echo "</span>";
		}
		
	?>
	</tr> 
	<tr>
		<td>
			<label for="date">Change Meeting Date From:</label>
		</td>
		<td>
			<input id="date" name="date" type="date" class="input" />
		</td>
	</tr>
	<tr>
		<td>
			<label for="day">Set New default Weekday:</label>
		</td>
		<td>
			<select name="weekday"> 
				<option value="1">Monday</option> 
				<option value="2">Tuesday</option> 
				<option value="3">Wednesday</option> 
				<option value="4">Thursday</option> 
				<option value="5">Friday</option> 
				<option value="6">Saturday</option> 
				<option value="0">Sunday</option> 
			</select>
		</td>
	</tr>
	<tr>  
		<td>
			<input type="submit" name="submit" value="Submit" class="left">
		</td>
		<td>
			<input type="button" onclick="window.location.href='index.php';" value="Cancel" class="left" >
		</td>

	</tr> 

	</table>
	</form>
</fieldset>
</div>
