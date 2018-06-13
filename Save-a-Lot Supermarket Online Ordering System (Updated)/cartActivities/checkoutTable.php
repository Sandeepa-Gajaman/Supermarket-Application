<div class="container" id="checkout">
<br>
<h1 align="center"><b>Checkout</b></h1>
<br>
<div id="shopping-cart">
<div class="txt-heading">Shopping Cart <a id="btnEmpty" href="index.php?action=empty">Empty Cart</a></div>
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
<th style="text-align:center;"><strong>Action</strong></th>
</tr>
<?php
foreach ($_SESSION["cart_item"] as $item){
?>
    <tr>
    <td style="text-align:left;border-bottom:#F0F0F0 1px solid;"><strong><?php echo $item["item_name"]; ?></strong></td>
    <td style="text-align:left;border-bottom:#F0F0F0 1px solid;"><?php echo $item["item_brand"]; ?></td>
    <td style="text-align:right;border-bottom:#F0F0F0 1px solid;"><?php echo $item["quantity"]; ?></td>
    <td style="text-align:right;border-bottom:#F0F0F0 1px solid;"><?php echo "රු.".$item["item_unit_price"]; ?></td>
    <td style="text-align:center;border-bottom:#F0F0F0 1px solid;"><a href="checkout.php?action=remove&item_brand=<?php echo $item["item_brand"]; ?>" class="btnRemoveAction">Remove Item</a></td>
    </tr>
    <?php
    $item_total += ($item["item_unit_price"]*$item["quantity"]);
		}
		?>

<tr>
<td colspan="5" align=right><font size="5"><strong>Total:</strong></font>  <font size="5" color="red"><?php echo "රු.".$item_total; ?></font></td>
</tr>
<tr>
  <td colspan="5">Before proceed please confirm above items as your ordering items or else go back for shopping.</td>
</tr>
<tr>
  <td colspan="5" align="right"><a href="#" class="btn btn-primary" id= "proceedButton" onclick= "invokeProceedForm();" style= "margin: 5px;">Confirm</a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="index.php" class="btn btn-success">Back to Shop</a></td>
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

<div class= "modal-body"><p>Are you sure you want to Proceed? Because this action cannot be reversed!</p></div>

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
  window.location.href="paymentInfo.php";
}
</script>
