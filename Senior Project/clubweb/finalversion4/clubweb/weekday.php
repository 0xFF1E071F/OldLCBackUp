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
        case '3': $str.='Wed'; break;
        case '4': $str.='Thr'; break;
        case '5': $str.='Fri'; break;
        case '6': $str.='Sat'; break;
    }
    return $str;
}

function getWeekFull($timestamp){
    $timestamp=date('w',$timestamp);
    $str='';
    switch($timestamp){
        case '0': $str.='Sunday'; break;
        case '1': $str.='Monday'; break;
        case '2': $str.='Tuesday'; break;
        case '3': $str.='Wednesday'; break;
        case '4': $str.='Thursday'; break;
        case '5': $str.='Friday'; break;
        case '6': $str.='Saturday'; break;
    }
    return $str;
}

// this is function to get week date of time
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
// this is function convert weekday to weekday number
function weekdaynumber($weekday){
   $weekdaynum=0;
    switch($weekday){
        case 'Sunday':$weekdaynum=0; break;
        case 'Monday':$weekdaynum=1; break;
        case 'Tuesday':$weekdaynum=2; break;
        case 'Wednesday':$weekdaynum=3; break;
        case 'Thursday':$weekdaynum=4; break;
        case 'Friday':$weekdaynum=5; break;
        case 'Saturday':$weekdaynum=6; break;
    }
    return $weekdaynum;
}
?>