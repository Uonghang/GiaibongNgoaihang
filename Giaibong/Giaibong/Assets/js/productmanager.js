function removeProduct(ID) {
    $.ajax({
        type: "POST",
        url: "ProductManager/ProductRemove",
        data: { id: ID }
    });
}
