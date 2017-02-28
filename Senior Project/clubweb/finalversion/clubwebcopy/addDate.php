<!--
--------------------------------------------
			 addDate.php
				Yu Fu
			  2015-11-6
--------------------------------------------
create a select date input 
and a button to submit this date to database
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
<div>
	<fieldset>
	<legend>Add date for meeting not on usual night:</legend>
	<form name="dateForm" method="post"  onSubmit="return InputCheck(this)" action="updateDates.php" >	
		<label for="date">Select A new Date:</label>
		<p>
			<input id="date" name="date" type="date" class="input" />
			<p> ( The selected date should be <i>after</i> today.)
		</p>
		<input type="submit" name="addDate" id= "submit" value="AddDate "/>
	</form>
	</fieldset>
</div>