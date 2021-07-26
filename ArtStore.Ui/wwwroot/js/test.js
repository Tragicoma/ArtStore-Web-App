
//$(document).ready(function () {
//    $('.category_item').click(function () {
//        var category = $(this).attr('id');


//        if (category == 'all') {
//            $('.art_item').css('display', 'none');
//            setTimeout(function () {
//                $('.art_item').css('display', '');
//            }, 300);

//        } else {
//            $('.art_item').css('display', 'none');
//            setTimeout(function () {
//                $('.' + category).css('display', '');
//            }, 300);

//        }

//    });
//let products = [
//    {
//        iD: "@Model.ID",
//        tag: "@Model.Name",
//        price: "@Model.Price",
//        inBasket: 0
//    }
//];

///*Add function for button*/
//$(document).ready(function () {
//    let baskets = document.querySelectorAll('.btn-add');
//    /*        baskets[0]*/
//    /*baskets[1]*/

//    for (let i = 0; i < baskets.length; i++) {
//        baskets[i].addEventListener('click', () => {
//            basketNumbers(products[i]);
//        })
//    }
//    function onLoadBasketNumbers() {
//        productsNumbers = localStorage.getItem('basketNumbers');

//        if (productsNumbers) {
//            document.querySelector('.fa-shopping-basket-container span').textContent = productsNumbers;
//        }
//    }
//    function basketNumbers(products) {

//        /*productsNumbers = localStorage.getItem('basketNumbers');*/

//        productsNumbers = parseInt(productsNumbers);

//        if (productsNumbers) {
//            localStorage.setItem('basketNumbers', productsNumbers + 1);
//            document.querySelector('.fa-shopping-basket-container span').textContent = productsNumbers + 1;
//            /*@ViewData["BasketData"] = productsNumbers + 1;*/
//        }
//        else {
//            localStorage.setItem('basketNumbers', 1);
//            document.querySelector('.fa-shopping-basket-container span').textContent = 1;
//        }
//        setItems(products);
//    }
//    function setItems(products) {
//        let basketItems = localStorage.getItem('productsinBasket');
//        console.log(basketItems);
//        basketItems = JSON.parse(basketItems);
//        console.log("My basketItems is", basketItems);

//        if (basketItems != null) {
//            if (basketItems[products.tag] == undefined) {
//                basketItems = {
//                    ...basketItems,
//                    [products.tag]: products
//                }
//            }
//            basketItems[products.tag].inBasket += 1;
//        }
//        else {
//            products.inBasket = 1;
//            basketItems = {
//                [products.tag]: products
//            }
//        }
//        localStorage.setItem("productsInBasket", JSON.stringify(basketItems));
//    }

//    /*Shows in basket what in local storage*/
//    function displayBasket() {
//        let basketItems = localStorage.getItem("productsInBasket");
//        basketItems = JSON.parse(basketItems);

//        let productContainer = document.querySelector("productsInBasket");
//        ('.container');

//        console.log(basketItems);
//        if (basketItems && productContainer) {
//            productContainer.innerHTML = '';
//            Object.values(basketItems).map(item => {
//                productContainer.innerHTML += `
//                     <div class="products">
//                     <img src="./pic/${item.tag}.jpg"> ///tag in product is not pic
//                     <span>${item.price}</span>
//                    < div >
//                     `
//            });
//        }
//    }
//    onLoadBasketNumbers();
//    displayBasket();
//});
///*Remove function for button*/
//$(document).ready(function () {
//    let baskets = document.querySelectorAll('.btn-remove');
//    baskets[0]
//    baskets[1]

//    for (let i = 0; i < baskets.length; i++) {
//        baskets[i].addEventListener('click', () => {
//            basketNumbers();
//        })
//    }
//    function onLoadBasketNumbers() {
//        productsNumbers = localStorage.getItem('basketNumbers');

//        if (productsNumbers) {
//            document.querySelector('.fa-shopping-basket-container span').textContent = productsNumbers;
//        }
//    }
//    function basketNumbers() {

//        productsNumbers = localStorage.getItem('basketNumbers');
//        productsNumbers = parseInt(productsNumbers);

//        if (productsNumbers) {
//            localStorage.setItem('basketNumbers', productsNumbers - 1);
//            document.querySelector('.fa-shopping-basket-container span').textContent = productsNumbers - 1;
//            /*@ViewData["BasketData"] = productsNumbers - 1;*/
//        }
//    }
//    onLoadBasketNumbers();
//});
//});