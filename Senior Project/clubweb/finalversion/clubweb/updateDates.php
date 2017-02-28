<!-- 
--------------------------------------------
			updateDates.php
				Yu Fu
			  2015-10-3
--------------------------------------------
update calender dates
-->


<?php
//connect to database
require_once 'conn.php'; 
if (!$conn){
	die("connection fail." . mysql_error());
}
else
{
	if (isset($_POST['deleteDate']))
	{
		$selected_date_id=$_POST['selectDate'];
		$delete_checkouts="Delete from checkouts where dateId=$selected_date_id";
		$result_delete_checkouts = mysqli_query($conn,$delete_checkouts) 
							or die("Error: ".mysqli_error($conn));
		$delete_date="Delete from dates where id=$selected_date_id";
		if (mysqli_query($conn,$delete_date) )
		{			
			$result = "delete";
		}
		else
		{
			$result = "notdelete";
		}
	}
	else if(isset($_POST['addDate']))
	{
		$new_date=$_POST['date'];
		$new_date_strtotime=strtotime($new_date);

		if($new_date!="")
		{
			//check if date exist?
			$find_date="select date from dates where date='$new_date_strtotime' limit 1";
			$check_date = mysqli_query($conn,$find_date);
			if(mysqli_num_rows($check_date)==1){
				$result = "exist";
			}
			else
			{
				//add a new date
				$add_date = "Insert dates (date) value('$new_date_strtotime')"; 
				if (mysqli_query($conn,$add_date))
				{
					$result = "add";
				}
			}

		}
	}
}
mysqli_close ($conn);
$href="index.php?result=".$result;
header("Location:".$href); 
?>