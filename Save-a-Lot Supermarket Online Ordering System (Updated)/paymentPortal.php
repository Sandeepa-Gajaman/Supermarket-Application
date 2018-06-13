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
<div class="container" id="confirm">

<?php
 include 'cartActivities/deliverAddress.php';
 require 'essential/alertInvoke.php';
?>

</div>
</body>
</html>
