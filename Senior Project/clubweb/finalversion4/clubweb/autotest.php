<?php
		require_once 'conn.php';
		$weekday = "wednesday";								//on what day of week do we meet?
		$lookback = "3";									//how many weeks back do we keep records?
		$lookahead= "6";									//how many weeks ahead can you check out?
		$new_weekday=$weekday;
		//=========================================================================
		// This part is trying to update the default weekday table in db
		// as a new table "defday" (default weekday)
		// this table is saving the old meet day and new weekday
		// admin can change it, and update this table
		// also a new php called updateOldDay.php is trying to update old dates
		// to new dates when the meet day changed.
		// not finished
		// sometimes it will changed some specific day to our meet day
		// not sugget to use it.
		//=========================================================================
		
		//this is php file includes weekday function
		include ('weekday.php');
		// get old/new setup of default from db
		$get_old_date="select * from defday where isnew = 0";
		$get_old = mysqli_query($conn,$get_old_date);

		// if we did not get the old week day
		if(mysqli_num_rows($get_old)==0) 
		{
			// i prefer to reset the table
			// and insert data
			mysqli_query($conn,'TRUNCATE TABLE defday');
			$thisDate=strtotime("next ".$weekday." -1 weeks"); // make the date as the day this week
			$thisWeekday=date('w',$thisDate);
			//echo $thisDate.'</br>';
			//echo $thisWeekday;
			$insert_defday="INSERT INTO defday (date,weekday,isnew) VALUES ('$thisDate','$thisWeekday',0)";
			mysqli_query($conn,$insert_defday);
			$insert_defday="INSERT INTO defday (date,weekday,isnew) VALUES ('$thisDate','$thisWeekday',1)";
			mysqli_query($conn,$insert_defday);
		}	
		
		$get_old = mysqli_query($conn,$get_old_date);
		// if we can get the old day from db
		if(mysqli_num_rows($get_old)==1) 
		{ 
			// set old day
			$row_old = mysqli_fetch_array($get_old); 
			$weekday = weekday($row_old['weekday']);
			$old_date = $row_old['date'];
		}
		
		$get_new_date="select * from defday where isnew = 1";
		$get_new = mysqli_query($conn,$get_new_date);
		//if we can get a new day from db
		if(mysqli_num_rows($get_new)==1)
		{ 
			// use it as our default day
			$row = mysqli_fetch_array($get_new); 
			$new_weekday = weekday($row['weekday']);
			$last_date = $row['date'];
			//check if the date correct
			if ($last_date>$old_date && $new_weekday!=$weekday)
			{
				// set the weekday is new day

			}
		}
		else//if we cannot get a new day
		{
			$new_weekday=$weekday;
			$last_date=$old_date;
		}
		//===========================================================================
?>