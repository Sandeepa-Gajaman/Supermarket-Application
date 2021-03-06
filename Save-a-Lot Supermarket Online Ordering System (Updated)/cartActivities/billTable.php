
<div id="shopping-cart">
<div class="txt-heading" align="center">Bill Items</div>
<?php
if(isset($_SESSION["cart_item"])){
    $item_total = 0;
?>
<table cellpadding="10" cellspacing="1">
<tbody>
<tr>
<th style="text-align:left;"><strong>Name</strong></th>
<th style="text-align:left;"><strong>Code</strong></th>
<th style="text-align:right;"><strong>Quantity</strong></th>
<th style="text-align:right;"><strong>Price</strong></th>
</tr>
<?php
foreach ($_SESSION["cart_item"] as $item){
?>
    <tr>
    <td style="text-align:left;border-bottom:#F0F0F0 1px solid;"><strong><?php echo $item["item_name"]; ?></strong></td>
    <td style="text-align:left;border-bottom:#F0F0F0 1px solid;"><?php echo $item["item_brand"]; ?></td>
    <td style="text-align:right;border-bottom:#F0F0F0 1px solid;"><?php echo $item["quantity"]; ?></td>
    <td style="text-align:right;border-bottom:#F0F0F0 1px solid;"><?php echo "රු.".$item["item_unit_price"]; ?></td>
    </tr>
    <?php
    $item_total += ($item["item_unit_price"]*$item["quantity"]);
		}
		?>

<tr>
<td colspan="5" align=right><font size="5"><strong>Total:</strong></font>  <font size="5" color="red"><?php echo "රු.".$item_total; ?></font></td>
</tr>
<tr>
  <td colspan="5" align="right"><a href="#" class="btn btn-lg btn-primary" id= "proceedButton" onclick= "invokeProceedForm();" style= "margin: 5px;">Go Back to Home</a></td>
</tr>

</tbody>
</table>
  <?php
}
?>

</div>

</div>

<!-- Modal box for the confirm button-->
<div class= "modal fade" id= "proceedModal" role= "dialog">
<div class= "modal-dialog">

<div class= "modal-content">
<div class= "modal-header" style="  background-color: #fefbd8;">
<h4 class= "modal-title">Confirm Action</h4>
</div>

<div class= "modal-body"><p>Are you sure you want to go back to Home?</p></div>

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
  window.location.href="index.php";
}
</script>
