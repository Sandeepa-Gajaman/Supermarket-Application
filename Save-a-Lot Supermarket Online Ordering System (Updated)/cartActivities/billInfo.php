
<div class="container" align="center">
<br>
<h3> Hi <?php echo $_SESSION['fname']; ?> <?php echo $_SESSION['lname']; ?>!</h3>
<p><b>this will be your bill for the above transaction</b></p>

<br>
<h4>Below items will be delivered to this address</h4>
<p><b>
<?php echo $_SESSION['stAddress']; ?>,<br>
<?php echo $_SESSION['city']; ?>,<br>
<?php echo $_SESSION['province']; ?>
<?php echo $_SESSION['zip']; ?>,<br>
<?php echo "Sri Lanka"; ?><br>
Tel No:  <?php echo $_SESSION['phNum']; ?>
</b></p>

</div>
