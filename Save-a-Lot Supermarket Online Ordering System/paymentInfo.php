<?php
session_start();
 ?>

 <?php
 require 'essential/head.php';
 require 'essential/Navbar.php';
 ?>

<body>
  <br><br>
<div class="container" id="address">
<br>
  <h1 align="center"><b>Address Details</b></h1>
  <br>
     <h5 align="center">Enter your delivery address details below.</h5>

  <?php
  include 'cartActivities/addressForm.php';
  ?>

</div>

</body>
</html>
