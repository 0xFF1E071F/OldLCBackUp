<?php
function makeNumberArray($maxRows,$maxCols)  // use two same old number
{
	// start from center
	$row=$maxRows/2+1;
	$col=$maxCols/2+1;
	
	$currentNumber=1; // start from number 1
	$direction="right";// set as default, first one should go right way
	$maxLength=1;
	$stepsLeft=1;
	
    $numArray=array_fill(1,$maxRows,array_fill(1,$maxCols, 0)); // create an array,defalt as zero
    
	while($currentNumber<=$maxRows*$maxCols)
	{
		for($multiAction=2;$multiAction > 0;$multiAction--)
		{
			for ($LengthLeft=$maxLength; $LengthLeft>0; $LengthLeft--)
			{
				if(isPrime($currentNumber))
					$numArray[$row][$col]=$currentNumber;	
                else// fill in line depends on direction
                {
					switch ($direction)
					{
						case "right":$data="--";break;
						case "left":$data= "--";break;
						case "up":$data= "|"; break;
						case "down":$data= "|";break;
					}
					$numArray[$row][$col]=$data;
				}
				++$currentNumber;
		
				switch ($direction)// go to next one block.
				{
					case "up"   : $row++; break;
					case "down" : $row--; break;
					case "right": $col++; break;
					case "left" : $col--; break;
				}
			}
			switch ($direction)	//finish current maxLength, change to new direction
			{
				case "right": $direction="down"; break;
				case "down" : $direction="left"; break;
				case "left" : $direction="up"; break;
				case "up" : $direction="right"; break;
			}
			$maxLength++;
		}
		return $numArray;
	}
}
	
 function isPrime ($number)			//prime return true
 {
 	$result = true; // always assume its prime
	for ($factor=2; $factor<=sqrt($number);$factor++)	//test all factor up to sqrt(number), this is def of prime
     	if ($number % $factor == 0)	// if one 0, then it isnt prime
     	  	$result = false; 
     	  	
   return $result;
 }
 
function createUlanSpiralTable($maxRows,$maxCols,$numbers)
{
	echo "<table border=\"1\">";  //table border show
	for ($r=1; $r<=$maxRows; $r++)
	{
		echo "<tr>\n";
		for ($c=1; $c<=$maxCols; $c++)
		{	
			$numberX=$numbers[$r][$c];
			echo "<td>$numberX</td>\n";
		}
		echo "</tr>";
	}
	echo "</table>";
}


?> 

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Ulam spiral</title>
</head>

<body>
<h2>Ulam spiral</h2>
<?php
	$maxRows=11;
	$maxCols=11;
	$numbers=makeNumberArray($maxRows,$maxCols);
	$table=createUlanSpiralTable($maxRows,$maxCols,$numbers);
?>

</body>
</html>