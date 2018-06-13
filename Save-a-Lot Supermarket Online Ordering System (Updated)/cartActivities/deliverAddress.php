<?php
$_SESSION['fname'] = $_POST['fname'];
$_SESSION['lname'] = $_POST['lname'];
$_SESSION['stAddress'] = $_POST['stAddress'];
$_SESSION['city'] = $_POST['city'];
$_SESSION['province'] = $_POST['province'];
$_SESSION['zip'] = $_POST['zip'];
$_SESSION['phNum'] = $_POST['phNum'];
?>

<div class="container" align="center">
<br><br>
<h2><b>Hi <i><?php echo $_POST["fname"]; ?> <?php echo $_POST["lname"]; ?></i>!</b></h2><br>
<h4>Please confirm below address as your delivery address.</h4><br><br><br>
<h3><b><?php echo $_POST["stAddress"]; ?>,<br>
  <?php echo $_POST["city"]; ?>,<br>
  <?php echo $_POST["province"]; ?> <?php echo $_POST["zip"]; ?><br>
  Sri Lanka <br><br><br>
  Tel No:  <?php echo $_POST["phNum"]; ?></b></h3>

  <br><br>
<p><b><i>If not! Click Go Back button to coorect them.</i></b>&nbsp;&nbsp;&nbsp;&nbsp;<a href="paymentInfo.php" class="btn btn-sm btn-danger">Go Back </a></p>
<br><br>
  <a href="#" class="btn btn-lg btn-primary" id= "proceedButton" onclick= "invokeProceedForm();" style= "margin: 5px;">
    <span class="glyphicon glyphicon-chevron-right"></span>Confirm Details</a><br><br>
</div>
</div>
<br><br>
<!-- Modal box for the confirm button-->
<div class= "modal fade" id= "proceedModal" role= "dialog">
<div class= "modal-dialog">

<div class= "modal-content">
<div class= "modal-header" style="  background-color: #fefbd8;">
<h4 class= "modal-title">Confirm Action</h4>
</div>

<div class= "modal-body"><p>Are you sure you want to proceed?</p></div>

<div class= "modal-footer">
<button type= "button" class= "btn btn-success button1" data-dismiss= "modal" value= "yes" onclick= "proceedForm();">Yes</button>
<button type= "button" class= "btn btn-danger button1" data-dismiss= "modal">No</button>
</div>
</div>

</div>
</div>
<!---->

<script>
function proceedForm(){
  window.location.href="bill.php";
}
</script>
