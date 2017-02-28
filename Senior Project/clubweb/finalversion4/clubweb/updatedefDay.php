<!-- 
--------------------------------------------
			 updatedefDay.php
				Yu Fu
			  2015-11-12
--------------------------------------------
update default date in db
and return results
-->
<?php
	include ('weekday.php');
	// get new infos from changeDay.php
	$new_date=strtotime($_POST['date']);
	$new_day=$_POST['weekday'];
	//  check if we selected date on the same weekday
	//	as we selectedweekday
	if(date('w',$new_date)==$new_day)
	{
		//connect to db
		require_once 'conn.php'; 
		//get old day info
		$get_old="select * from defday where isnew = 1";
		
		$date = mysqli_query($conn,$get_old); 
		//'new' value from db and set them to old
		if(mysqli_num_rows($date)==1)
		{ 
			$old_row = mysqli_fetch_array($date); 
			//copy old values as new
			$set_old_day="UPDATE defday SET date='".$old_row['date']."' , weekday='".$old_row['weekday']."' WHERE isnew=0";
			//upload new values
			$set_new_day="UPDATE defday SET date=$new_date , weekday=$new_day WHERE isnew = 1";
			//of all successful
			if(mysqli_query($conn,$set_old_day))
			{
				if(mysqli_query($conn,$set_new_day))
				{
					// give feedback
					$result="suc";
					unlink('autoupdate.txt');
				}
			}
		
		}
		mysqli_close($conn);
	}
	else//bad weekday
	{
		$result="nsd";
	}
	//$_GET give feedback and jump to changeDefDay.php
	$href="changeDefDay.php?result=".$result;
	header("Location:".$href); 
?>