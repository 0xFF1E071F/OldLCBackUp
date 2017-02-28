<!-- 
--------------------------------------------
			 weekday.php
				Yu Fu
			  2015-10-12
--------------------------------------------
this is php function to get weekday of a date
and set the weekday with number value
-->
<?php

// this is function to get week date of time
function getWeek($timestamp){
    $timestamp=date('w',$timestamp);
    $str='';
    switch($timestamp){
        case '0': $str.='Sun'; break;
        case '1': $str.='Mon'; break;
        case '2': $str.='Tue'; break;
        case '3': $str.='Wen'; break;
        case '4': $str.='Thr'; break;
        case '5': $str.='Fri'; break;
        case '6': $str.='Sat'; break;
    }
    return $str;
}


function weekday($weeknumber){
    $str='';
    switch($weeknumber){
        case '0': $str='Sunday'; break;
        case '1': $str='Monday'; break;
        case '2': $str='Tuesday'; break;
        case '3': $str='Wednesday'; break;
        case '4': $str='Thursday'; break;
        case '5': $str='Friday'; break;
        case '6': $str='Saturday'; break;
    }
    return $str;
}

?>