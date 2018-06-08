<?php
session_start();
require_once("dbcontroller.php");
$db_handle = new DBController();
?>

<?php
require 'essential/head.php';
require 'essential/Navbar.php';
?>

<body>

<?php

 include 'cartActivities/cart.php';
 require 'cartActivities/checkoutTable.php';
 require 'essential/alertInvoke.php';
  ?>

</body>
</html>
