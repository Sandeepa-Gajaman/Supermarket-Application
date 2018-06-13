<?php
session_start();
 ?>

 <?php
 require 'essential/head.php';
 require 'essential/Navbar.php';
 ?>

 <body>
   <br>
   <div class="container" id="bill">
<br>
   <h1 align="center"><b>Bill</b></h1>

 <?php

   include 'cartActivities/billInfo.php';
   include 'cartActivities/billTable.php';
   require 'essential/alertInvoke.php';
    ?>

  </div>
 </body>

 </html>

<?php
 // remove all session variables
 session_unset();

 // destroy the session
 session_destroy();

?>
