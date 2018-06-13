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

<br>

<?php

 include 'cartActivities/cart.php';
 include 'cartActivities/indexCartTable.php';
 require 'cartActivities/product_grid.php';
 require 'essential/alertInvoke.php';
   ?>

</body>
</html>
