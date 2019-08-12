<?php
error_reporting(0);
$type = $_GET['action'];

if($type == "add")
{
    $rusers = fopen("users.txt","r") or die("Error");
	$count = fread($rusers,filesize("users.txt"));
	$txt = $count += 1;
	
	$wusers = fopen("users.txt","w") or die("Error!");
	fwrite($wusers,$txt);
	$fclose($wusers);
	$fclose($rusers);
}
else if($type == "take")
{
    $rusers = fopen("users.txt","r") or die("Error");
	$count = fread($rusers,filesize("users.txt"));
	$txt = $count -= 1;
	
	$wusers = fopen("users.txt","w") or die("Error!");
	fwrite($wusers,$txt);
	$fclose($wusers);
	$fclose($rusers);
}
?>