<!-- 
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
		
-->
<?php
	require_once 'conn.php'; // get connection
	$today = strtotime("today-1day"); // today date
	//this is php file includes weekday function
	include ('weekday.php');
	// get old/new setup of default from db
	$get_old_date="select * from defday where isnew = 0";
	$get_old = mysqli_query($conn,$get_old_date);
	
	// if we can get the old day from db
	if(mysqli_num_rows($get_old)==1) 
	{ 
		// set old day
		$row_old = mysqli_fetch_array($get_old); 
		$weekday = weekday($row_old['weekday']);
		$old_date = $row_old['date'];
	}
	else// if we cannot get the old date
	{
		// i prefer to reset the table
		// and insert data
		mysql_query('TRUNCATE TABLE defday;');
		$insert_defday="INSERT INTO defday (date, weekday, isnew)
VALUES (1445814000, 1, 0)";
		mysql_query($insert_defday);
		$insert_defday="INSERT INTO defday (date, weekday, isnew)
VALUES (1445814000, 1, 1)";
		mysql_query($insert_defday);
		$weekday = "Monday";
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
	}
	else // if not set new default yet
	{
		$new_weekday = "Monday";							//on what day of week do we meet by default?
	}	
	
	$lookback = "3";									//how many weeks back do we keep records?
	$lookahead= "6";									//how many weeks ahead can you check out?
	//==============
	
	$begin_date = strtotime("next ".$weekday." - ".$lookback ." weeks");	// oldest
	$new_date   = strtotime("next ".$weekday." + ".$lookahead." weeks");	// newest 

	//get dates from database
	$sql = "SELECT * from dates ORDER BY date";
	$getDate = mysqli_query($conn,$sql);
	
	if(mysqli_num_rows($getDate)==0)	// if db empty
	{ 
		for($i=-(int)$lookback;$i<(int)$lookahead;$i++)
		{
			$add_date=strtotime("next ".$weekday." +".$i." weeks");
			if($add_date>$last_date)
				$add_date=strtotime("next ".$new_weekday." +".$i." weeks");
			$sql_set_up_date= "INSERT INTO dates(date)VALUES('$add_date')";
			mysqli_query($conn,$sql_set_up_date);
		}
	}
	else								// if db non-empty ,check all dates
	{
		$daterow = mysqli_fetch_array($getDate);
		//if old date too old
		if ($begin_date > $daterow['date'])
		{
			// delete all old checkouts 
			$sql_delete_old_date = "DELETE from checkouts where id =".$daterow['id'] ;	
			mysqli_query($sql_delete_old_date);
			// update old date to new date
			if($new_date>$last_date)
			{
				$new_date   = strtotime("next ".$new_weekday." + ".$lookahead." weeks");	// newest 
			}
			$sql_update_new_date = "UPDATE dates set date=".$new_date." where id =".$daterow['id'] ;
			mysqli_query($conn,$sql_update_new_date);	
		}	
		
		//reset corrent db value
		$j=0;
		while($daterow = mysqli_fetch_array($getDate))
		{
			// reset all dates to a new date 
			
			if($daterow['date']>$last_date)
			{	
				if (j==0)
				{
					$next_sun = strtotime('next sunday', $daterow['date']);
					if ($next_sun<$new_date )
					{
						$j++;
					}
				}	

				$new_date=strtotime(date('M-d-Y',$last_date)." + ".$j." weeks");
				$sql_update_new_date = "UPDATE dates set date=".$new_date." where id =".$daterow['id'] ;
				mysqli_query($conn,$sql_update_new_date);
				$j++;
			}
		}
	}
	
	
	
	mysqli_close ($conn);

	
	header('Location: index.php'); //back to index
?>