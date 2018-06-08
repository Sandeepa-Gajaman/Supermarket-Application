<div id="shopping-cart">
<div class="txt-heading"><a id="btnEmpty" href="index.php?action=empty">Empty Cart</a></div>
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
    <td style="text-align:right;border-bottom:#F0F0F0 1px solid;"><?php echo "$".$item["item_unit_price"]; ?></td>
    <td style="text-align:center;border-bottom:#F0F0F0 1px solid;"><a href="index.php?action=remove&item_brand=<?php echo $item["item_brand"]; ?>" class="btnRemoveAction">Remove Item</a></td>
    </tr>
    <?php
    $item_total += ($item["item_unit_price"]*$item["quantity"]);
		}
		?>

<tr>
<td colspan="5" align=right><strong>Total:</strong> <?php echo "$".$item_total; ?></td>
</tr>
<tr>
  <td colspan="5" align="right"><a href="bill.php" class="btn btn-sm btn-primary"><span class="glyphicon glyphicon-chevron-right"></span> Place Order</a></td>
</tr>
</tbody>
</table>
  <?php
}
?>
</div>
