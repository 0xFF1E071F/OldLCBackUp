<!--
====================================================================
					resultpage.php
					  Nov 05.2015
					     Yu Fu
====================================================================
this is result page which build the page of search results
-->
<?php 
//include conn file
include 'conn.php';
//include search function
include "search.php"; 
?>
<HTML>
<HEAD>
<META HTTP-EQUIV="Content-Type" CONTENT="text/html; charset=iso-8859-1">
</head>
<BODY TEXT="#000000" BGCOLOR="#FFFFFF">
<TITLE>BFV Query Results</TITLE>
</HEAD><BODY bgcolor="#FFFFFF">
<H1>Bibliography of Fossil Vertebrates</H1>
<table>
<tr>
<?php
	// give search results
	search($conn);
?>
</tr>
</table>
</body>
</html>