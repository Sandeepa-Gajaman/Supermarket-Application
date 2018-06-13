<div id="product-grid">
	<div class="txt-heading">Products</div>
	<?php
	$product_array = $db_handle->runQuery("SELECT * FROM item ORDER BY item_brand ASC");
	if (!empty($product_array)) {
		foreach($product_array as $key=>$value){
	?>
		<div class="product-item">
			<form method="post" action="index.php?action=add&item_brand=<?php echo $product_array[$key]["item_brand"]; ?>">

			<div><strong><?php echo $product_array[$key]["item_name"]; ?></strong></div>
			<div class="product-image"><img src="<?php echo $product_array[$key]["image"]; ?>"></div>
			<div class="product-price"><?php echo "රු.".$product_array[$key]["item_unit_price"]; ?></div>
			<div><input type="text" name="quantity" value="1" size="2" /><input type="submit" value="Add to cart" class="btnAddAction" /></div>
			</form>
		</div>
	<?php
			}
	}
	?>
  </div>
