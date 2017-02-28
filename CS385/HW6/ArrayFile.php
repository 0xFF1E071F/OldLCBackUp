<?php
function readAFile($fileName)
{
	$lines = array(); 
	$file = fopen($fileName, "r"); 
	while(!feof($file)) 
	{ 
	    //read file line by line into a new array element 
	    $lines[] = fgets($file, 100); 
	} 
	fclose ($file);
	return $lines;
}

?>

<!DOCTYPE html>
<html>

<head>
	<link href="style.css" rel="stylesheet" type="text/css">
	<title>Fil Array</title>
	</head>

<body>

	<h1>Read a file, and put in an array</h1>
	<?php 
	
	$content=readAFile("relevant.txt");
	$arraySize = count($content);
	$i=0;
	while($i < $arraySize){
		echo "Array[$i] =>"; print_r($content[$i]); echo "<br>";
		$i++;
		}
	?>
	
</body>
</html>
