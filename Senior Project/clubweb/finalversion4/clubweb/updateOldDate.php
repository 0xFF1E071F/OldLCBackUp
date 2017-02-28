
<?php 
/*
--------------------------------------------
			updateOldDates.php
				Yu Fu
			  2015-11-21
--------------------------------------------
reset all dates from db to new day with new weekday after today
currently, not using in our web
*/
	//reset corrent db value
	
	$sql = "SELECT * from dates ORDER BY date";
	$getDate = mysqli_query($conn,$sql);
	$j=0;
	$week=-$lookback;
	while($daterow = mysqli_fetch_array($getDate) && $weekday!=$new_weekday)
	{
		$week++;
		if($daterow['date']>$last_date)
		{
			$new_date=strtotime(date('M-d-Y',$last_date)." +".$week." weeks");
			
			if($new_date>$daterow['date'])
			{
				$sql_update_new_date = "UPDATE dates set date=".$new_date." where id =".$daterow['id'] ;
				mysqli_query($conn,$sql_update_new_date);
			}	
		}
		
		
		/* // reset all dates to a new date 
		if($daterow['date']>$last_date)
		{	
			if (j==0)
			{
				$next_date = strtotime('next sunday', $daterow['date']);
				if ($next_date<$new_date )
				{
					$j++;
				}
			}	

			$new_date=strtotime(date('M-d-Y',$last_date)." + ".$j." weeks");
			
			if($new_date>daterow['date'])
			{
				$sql_update_new_date = "UPDATE dates set date=".$new_date." where id =".$daterow['id'] ;
				mysqli_query($conn,$sql_update_new_date);
			}	
			$j++;
		} */
	}
?>