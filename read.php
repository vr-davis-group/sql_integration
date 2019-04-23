<?php
    
   $servername = "localhost";
   $serverusername = "root";
   $serverpassword = "";
   $databasename = "unity";

   $conn = new mysqli($servername, $serverusername, $serverpassword, $databasename);

   if(!$conn){
        die("Connection failed! ".mysqli_connect_error());
   }

   $sql = "SELECT user_id, username, password FROM users";

   $result = mysqli_query($conn, $sql);

   if(mysqli_num_rows($result) > 0){
       while($row = mysqli_fetch_assoc($result)){
            echo "ID:".$row['user_id']."|Username:".$row['username']."|Password:".$row['password'].";";
       }
   }


?>