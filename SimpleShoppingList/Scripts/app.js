var currentList = {};

function createShoppingList() {
    currentList.name = $("#shoppingListName").val();
    currentList.items = new Array();

    // web service call

    $("#shoppingListTitle").html(currentList.name);
    $("#shoppingListItems").empty();

    $("#createListDiv").hide();
    $("#shoppingListDiv").show();

}

function addItem() {
    var newItem = {};
    newItem.name = $("#newItemName").val();
    currentList.items.push(newItem);
    console.info(currentList);

    drawItems();
}

function drawItems() {
    var $list = $("#shoppingListItems").empty();

    for (var i = 0; i < currentList.items; i++) {
        var currentItem = currentList.items[i];
        var $li = $("<li>").html(currentItem.name)
            .attr("id", "item_" + i);
        var $deleteBtn = $("<button>D<button>").appendTo($li);
        var $checkBtn = $("<button>C<button>").appendTo($li);
        $li.appendTo($list);
    }
}

$(document).ready(function () {
    console.info("ready");
})
