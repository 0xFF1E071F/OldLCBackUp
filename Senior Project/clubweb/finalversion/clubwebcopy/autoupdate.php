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
	//old
	//default dates
	//$today = strtotime("today-1day"); // today date
	//$check_date = strtotime("next monday - 1 week");  // auto set date
	
	//new 
	require_once 'conn.php';
	$today = strtotime("today-1day"); // today date

	$weekday = "monday";								//on what day of week do we meet?
	$lookback = "3";									//how many weeks back do we keep records?
	$lookahead= "6";									//how many weeks ahead can you check out?
	//==============

	include ('weekday.php');
	// get old/new setup of default from db
	$get_new_date="select * from defday where isnew = 1";
	$get_new = mysqli_query($conn,$get_new_date);
	//if we can get a new day from db
	if(mysqli_num_rows($get_new)==1)
	{ 
		// use it as our default day
		$row = mysqli_fetch_array($get_new); 
		$weekday = weekday($row['weekday']);
	}

	$begin_date = strtotime("next ".$weekday." - ".$lookback ." weeks");	// oldest
	$new_date   = strtotime("next ".$weekday." + ".$lookahead." weeks");	// newest 

	
	//if($today==$check_date) 
	//{
		 // get connection
		
		//echo "We are about to update the dates table<br>";
		//I can't seem to ever reach this line -- WSB
		
		//get dates from database
		$sql = "SELECT * from dates ORDER BY date";
		$getDate = mysqli_query($conn,$sql);
		
		if(mysqli_num_rows($getDate)==0)	// if db empty
		{ 
			for($i=-(int)$lookback;$i<(int)$lookahead;$i++)
			{
				$add_date=strtotime("next ".$weekday." +".$i." weeks");
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
				$sql_update_new_date = "UPDATE dates set date=".$new_date." where id =".$daterow['id'] ;
				mysqli_query($conn,$sql_update_new_date);	
			}	
		}
		mysqli_close ($conn);
	//}
	
	header('Location: index.php'); //back to index
?>