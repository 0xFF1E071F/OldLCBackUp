Changed the conn.php to my password

make a clubweb-wsb-copy.sql in other folder. Add a new table defDay(date,weekday,isNew(key)), there is only 2 rows which isnew =0 and isnew =1 save as old date and  new date
weekday is 0=sunday 1=monday 2=tu 3=wen and so on.

make changes for sql backup file add ON UPDATE CASCADE ON DELETE CASCADE for foreign key, then we can delete

admin.php add new linker to change changedafday.php default meeting date.

admin.php add new linker to change adminusers.php which can set up admin users and delete users.
move set admin user to this new page 
add delete users in this page

move script function to different file
i find if i put all of them in index, not work
also make $_GET to different file, when js not working 
it will show the red error message on web page 

i find there is a loginForm.php created at friday, dont know where it works

add something at end of autoupdate.php
this will edit the autoupdate.txt when autoupdate.php update the db
This will tell us what is the recent update
also the modify time of autoupdate.txt is a timer to relod.php

also modify $weekday depends on db's dafday table
if we have new weekday then $weekday = new weekday

also make a new php called updateOldDate.php
This is work for updating the dates in database
it will change the exist dates to new dates if we changed the meet day
it include in autoupdate.php (can comment it)
im not sure if this works fine.

a new bug: if we have empty db with dates tables;
autoupdate.php show add dates into dates table;
if the add date is today then it wont be added

also a bug: the weekday part in autoupdate.php is not working
do not know why 
i want to use the default $weekday to generate the date of this weekday
then add them in to db defday, as the defalt if defday is empty.