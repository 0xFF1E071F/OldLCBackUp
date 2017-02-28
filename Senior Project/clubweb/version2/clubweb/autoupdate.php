<!-- 
--------------------------------------------
			autoupdate.php
				Yu Fu
			  2015-10-3
--------------------------------------------
This php can set up database automatically.
It run one every Saturday and when user login.
	When empty  
		set default all date(every saturday)
	When not empty
		check old date, if too old delete and fill in new date
		
	There are always 5 dates in database:
		two weeks ago Saturday date
		one week ago Saturday date
		this week Saturday date
		next week Saturday date
		two weeks later Saturday date
		
-->
<?php
	//old
	//default dates
	//$today = strtotime("today-1day"); // today date
	//$check_date = strtotime("next monday - 1 week");  // auto set date
	
	//new 
	$today = strtotime("today-1day"); // today date

	//==============
	
	$begin_date = strtotime("next saturday - 3 weeks");	// oldest
	$new_date   = strtotime("next saturday + 2 week");	// newest 

	
	//if($today==$check_date) 
	//{
		require_once 'conn.php'; // get connection
		
		//echo "We are about to update the dates table<br>";
		//I can't seem to ever reach this line -- WSB
		
		//get dates from database
		$sql = "SELECT * from dates ORDER BY date";
		$getDate = mysqli_query($conn,$sql);
		
		if(mysqli_num_rows($getDate)==0)	// if db empty
		{ 
			for($i=-2;$i<3;$i++)
			{
				$add_date=strtotime("next saturday +".$i." weeks");
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