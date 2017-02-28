
<?php
/*
==========================================================
					   search.php
					  Nov 05.2015
					     Yu Fu
==========================================================
this is search page get informaiotn from input
and search them in databaseif 
*/
function search($conn)
{
	// include replace char function
	include "charConv.php";

	//get all inputs
	$getLnop = $_POST['lnop'];
	$getLn = $_POST['ln'];
	$getSjop = $_POST['sjop'];
	$getSubj = $_POST['subj'];
	$getJnop = $_POST['jnop'];
	$getJn = $_POST['jn'];
	$getTaxop = $_POST['taxop'];
	$getTaxon = $_POST['taxon'];
	$getPubop = $_POST['pubop'];
	$getPub = $_POST['pub'];
	$getYrop = $_POST['yrop'];
	$getYear = $_POST['year'];
	$getQuery = $_POST['query'];
	
	//set empty string
	$ln="";
	$subj="";
	$jn="";
	$taxon="";
	$year="";
	$pub="";
	//geneate value
	if ($getLn!="")
	{
		$ln="au ".$getLnop." "."'".$getLn."'";
	}
	if ($getSubj!="")
	{
		$subj="su ".$getSjop." "."'".$getSubj."'";
	}
	if ($getJn!="")
	{
		$jn="jn ".$getJnop." "."'".$getJn."'";
	}
	if ($getTaxon!="")
	{
		$taxon="taxon ".$getTaxop." "."'".$getTaxon."'";
	}
	if ($getPub!="")
	{
		$pub="pub ".$getPubop." "."'".$getPub."'";
	}
	if ($getYear!="")
	{
		$year="date ".$getYrop." '".$getYear."'";
	}
	
	//generate full query 
	// start from a empty $query
	// if $query not empty add " AND "
	$Query="";
	if ($ln!="")
	{
		$Query=$Query.$ln;
	}
	if ($subj!="")
	{
		if($Query!="")
			$Query=$Query." AND ";
		$Query=$Query.$subj;
	}
	if ($jn!="")
	{
		if($Query!="")
			$Query=$Query." AND ";
		$Query=$Query.$jn;
	}
	if ($taxon!="")
	{
		if($Query!="")
			$Query=$Query." AND ";
		$Query=$Query.$taxon;
	}
	if ($year!="")
	{
		if($Query!="")
			$Query=$Query." AND ";
		$Query=$Query.$year;
	}
	if ($pub!="")
	{
		if($Query!="")
			$Query=$Query." AND ";
		$Query=$Query.$pub;
	}
	if ($getQuery!="")
	{
		if($Query!="")
			$Query=$Query." AND ";
		$Query=$Query.$getQuery;
	}
	
	//if we got empty
	if ($Query=="")
	{
		echo "<br>
			<h2>There was an error in formatting the query.</h2>	
			<p>You must specify a type of search.</p>
			<p>Or use advanced query with either =. !=, > or <, e.g.: <br> example: taxon = 'Tyrannosaurus'<p>";
	}
	else
	{
		$search_sql="select distinct auths.au,auths.fn,ref.rid,ref.ti,ref.date,ref.jn,ref.jnfk,ref.vo,
		ref.pg,ref.pub,ref.type,ref.edvo,ref.trans,ref.tt,ref.ts,ref.ed from ref,subj,tax,auths 
		where ref.rid=subj.rid and ref.rid=tax.rid and ref.rid = auths.rid and (".$Query.") ORDER BY ref.date";
		echo "Query: ".$Query;
		echo "</br>";
		
		//connect to db
		//require_once 'conn.php'; 

		$getSearch = mysqli_query($conn,$search_sql);
		if (!$getSearch) {
			printf("Please check your inputs, Some <B>Grammatical Errors!</B>");
			//printf("Error: %s\n", mysqli_error($conn));

			exit();
		}
		//print the count of result
		echo mysqli_num_rows($getSearch)." references satisfied the query</br>";

		// print result
		while($row = mysqli_fetch_array($getSearch)) 
		{
			$result= "<p>".$row['au'].", ".$row['fn'];
			
			// some first name could include '.'
			if (strpos($row['fn'],'.') == false) 
			{
				$result=$result.". ";
			}
			else
			{
				$result=$result." ";
			}
			
			$result=$result.$row['date'].". ";
			$copyOfTitle=$row['ti'];
			
			//if find '^'
			// replace it as Italic
			while (strpos($copyOfTitle,'^')!== false)
			{
				//repace first ^ as <i>, and second as </I>
				$copyOfTitle=str_replace_limit('^','<I>',$copyOfTitle,1);
				$copyOfTitle=str_replace_limit('^','</I>',$copyOfTitle,1);
			}
			
			//generate results
			$result=$result.$copyOfTitle."</I>".". ";
			if ($row['tt']!="")
				$result=$result."[in ".$row['tt']."]";
			$result=$result." ".$row['ts']." ".$row['jn']." ".$row['vo'].". "." ".$row['pub']." ".$row['ed'].$row['pg'].".</p>";
			
			// place bfv code to html code
			echo strtr($result, $GLOBALS['normalizeChars']);
			//echo $result;
		}
	}
	
	//close connection
	mysqli_close($conn);

}
	
?>