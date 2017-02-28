<?php
/*	Yu Fu
	CS 385
	2014
	conn PHP
	database connection*/
$conn = @mysql_connect("localhost","root","cs385rox");
if (!$conn){
    die("connection fail." . mysql_error());
}
mysql_select_db("collectlikes", $conn);

?>