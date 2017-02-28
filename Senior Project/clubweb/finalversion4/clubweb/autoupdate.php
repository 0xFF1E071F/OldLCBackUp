
<?php

	/*
	--------------------------------------------
				autoupdate.php
					Yu Fu
				  2015-10-3
	--------------------------------------------
	This php can set up database automatically.
	It run one every $weekday and when user login.
		When empty  
			set default all date(every saturday)
		When not empty
			check old date, if too old delete and fill in new date
			
		There are always $lookback+$lookahead dates in database:
			$lookback    weeks ago, on $weekday
			$lookback-1  weeks ago, on $weekday
			...
			$lookahead weeks ahead, on $weekday
			
	*/
	//require_once 'conn.php';

	date_default_timezone_set('America/New_York');  //<!-- set time zone -->
	function autoupdate ($connection)
	{
		$today = strtotime("today"); // today date
		$weekday = "sunday";								//on what day of week do we meet?
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
		$get_old = mysqli_query($connection,$get_old_date);
		$get_new_date="select * from defday where isnew = 1";
		$get_new = mysqli_query($connection,$get_new_date);
		
		// if we did not get the old week day	
		if(mysqli_num_rows($get_old)==0||mysqli_num_rows($get_new)==0) 
		{
			// i prefer to reset the table
			// and insert data
			mysqli_query($$connection,'TRUNCATE TABLE defday');
			$thisDate=strtotime("next ".$weekday." -1 weeks"); // make the date as the day this week
			$thisWeekday=date('w',$thisDate);
			//echo $thisDate.'</br>';
			//echo $thisWeekday;
			$insert_defday="INSERT INTO defday (date,weekday,isnew) VALUES ('$thisDate','$thisWeekday',0)";
			mysqli_query($$connection,$insert_defday);
			$insert_defday="INSERT INTO defday (date,weekday,isnew) VALUES ('$thisDate','$thisWeekday',1)";
			mysqli_query($$connection,$insert_defday);
		}	
		
		
		// if we can get the old day from db
		$get_old = mysqli_query($connection,$get_old_date);
		$get_new = mysqli_query($connection,$get_new_date);
		// set old day
		$row_old = mysqli_fetch_array($get_old); 
		$weekday = weekday($row_old['weekday']);
		$old_date = $row_old['date'];
		// use it as our default day
		$row = mysqli_fetch_array($get_new); 
		$new_weekday = weekday($row['weekday']);
		$last_date = $row['date'];
		
		echo $weekday." %% ".$new_weekday;
		


		//===========================================================================
		
		$begin_date = strtotime("next ".$weekday." -".$lookback ." weeks");	// oldest
		//$new_date   = strtotime("next ".$weekday." +".$lookahead." weeks");	// newest 
		//if ($new_date>$last_date)
			//$new_date   = strtotime("next ".$new_weekday." +".$lookahead." weeks");	// newest 
		//echo $begin_date.'<br>';
		//echo $new_date.'<br>';
		
		//get dates from database
		$sql = "SELECT * from dates ORDER BY date";
		$getDate = mysqli_query($connection,$sql);
		if(mysqli_num_rows($getDate)==0)	// if db empty
		{ 
			for($i=-(int)$lookback;$i<(int)$lookahead;$i++)
			{
				$add_date=strtotime("next ".$weekday." +".$i." weeks");
				$sql_set_up_date= "INSERT INTO dates(date)VALUES('$add_date')";
				//echo "$sql_set_up_date<br>";
				mysqli_query($connection,$sql_set_up_date);
			}
			// bug: upper funtion cannot insert same day
			// if today is wed
			// then  "next wednesday +-0 weeks" is not insert
			// do not know if this is only happens on my computer or not
		}
		else								// if db non-empty ,check all dates
		{
			$daterow = mysqli_fetch_array($getDate);
			//echo $daterow['date']."<br>";
			//echo $daterow['id']."<br>";
			//if old date too old
			if ($begin_date > $daterow['date'])
			{
				// delete all old checkouts 
				$sql_delete_old_date = "DELETE FROM checkouts WHERE dateId =".$daterow['id'] ;	
				mysqli_query($connection,$sql_delete_old_date);
				//reset new date
				$getLastDateSql = "SELECT * from dates ORDER BY date DESC";
				$getLastDate = mysqli_query($connection,$getLastDateSql);
				$lastDate = mysqli_fetch_array($getLastDate);
				//if not same weekday
				//we set new day with new_weekday
				// nDays as diff days between old and new weekday
				$nDays=0;
				echo date('M-d-Y', $lastDate['date']);
				echo weekday($lastDate['date']);
				if ($new_weekday!=getWeekFull($lastDate['date']))
				{
					echo $new_weekday." != "; echo getWeekFull($lastDate['date']);
					//days between 
					$nDays=weekdaynumber($new_weekday)-weekdaynumber(getWeekFull($lastDate['date']));
				}
				//add new date
				$new_date=strtotime(date('M-d-Y', $lastDate['date'])."+1 week"." +".$nDays." days");
				// update old date to new date
				$sql_update_new_date = "UPDATE dates SET date=".$new_date." WHERE id =".$daterow['id'] ;
				mysqli_query($connection,$sql_update_new_date);	
			}	
		}
		
		//this is a php to update dates in db
		//when we have a new meet day, we will change all the date with old meet day to new meet day at same week
		//
		//include "updateOldDate.php";
		
		// add a file as timer which save the recent updates
		$time = time();
		$file = 'autoupdate.txt';
		$filemtime = filemtime($file);
		$h = fopen($file,'wb+');
		$content = "This is update at time: ".date('Y-m-d H:i:s', $time);
		fwrite($h,$content);
		fclose($h);
	}
	

?>