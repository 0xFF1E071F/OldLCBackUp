/*--
--------------------------------------------
			   myJS.js
				Yu Fu
			  2015-10-15
--------------------------------------------
This javaScript
User use to chekcout from calender or checkin
which connect to checkuser.php to modify databse
--*/

function clickFunction(elmnt,id)
{
	var xmlHttp;
	var url="checkuser.php";
	var data="id="+id+"&dateid="+elmnt.id+"&action="+elmnt.value;
	
	if (window.XMLHttpRequest)
	{// code for IE7+, Firefox, Chrome, Opera, Safari
		xmlHttp=new XMLHttpRequest();
	}
	else
	{// code for IE6, IE5
		xmlHttp= new ActiveXObject("Microsoft.XMLHTTP");
	}
	
	if (!xmlHttp) {
		alert('Giving up :( Cannot create an XMLHTTP instance');
	return false;
	}
    xmlHttp.open("POST",url,true);
	
	// Set content type header information for sending url encoded variables in the request
    xmlHttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    // Access the onreadystatechange event for the XMLHttpRequest object
    xmlHttp.onreadystatechange = function() 
	{
	    if(xmlHttp.readyState == 4 && xmlHttp.status == 200) 
		{
			//alert("successful");
			
			if (elmnt.value=="co")
			{
				elmnt.value="ci";
			}
			else if (elmnt.value=="ci")
			{
				elmnt.value="co";
			}
	    }
    }
	
    xmlHttp.send(data);
	
	 window.location.reload();
}

function myrefresh()
{
       window.location.reload();
}



