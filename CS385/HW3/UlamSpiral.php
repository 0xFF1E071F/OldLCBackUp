<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>

<?php
	function creatTable($rows,$cols)
	{
	echo "<table border=\"1\">";
	   
	//starting with the rows.
	for ($row=1; $row<=7; $row++){
 	 echo "<tr>\n";
  	//Generate each entry in the row to create the columns.
  	for ($col=1; $col<=7; $col++){
    //First, do the math.
    $x=$col * $row;
    //Then send the value to the table with the table data tags.  
    echo "<td>$x</td>\n";
     echo "</tr>";
  }
 
}
echo "</table>";

		
	}
	
	<?php
//Generate an HTML table
?>
?&gt;

</body>

</html>
