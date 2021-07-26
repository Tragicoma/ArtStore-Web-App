
document.addEventListener("DOMContentLoaded", start);
let numberBasket;
const myJSON = [

];
function start() {
    const addButton = document.querySelector('.btn-add');
    if (addButton) {
        addButton.addEventListener('click', onButtonClick);
    }

    const removeButton = document.querySelector('.btn-remove');
    if (removeButton) {
        removeButton.addEventListener('click', onButtonClickk);
    }

    const itemsInBasket = localStorage.getItem('itemsInBasket');

    const basket = document.querySelector('.basket');
    if (basket) {
        basketo();
    }

    /*Ja eksistē do nothing, ja neeksiste tad pievieno ar value 0*/
    if (itemsInBasket) {
        numberBasket = localStorage.getItem('itemsInBasket');
        console.log('Name exists');
        console.log(localStorage.getItem('itemsInBasket'));
        document.querySelector('.fa-shopping-basket-container span').textContent = numberBasket;
    } else {
        numberBasket = 0;
        localStorage.setItem('itemsInBasket', numberBasket);
        console.log('Name is not found');
        document.querySelector('.fa-shopping-basket-container span').textContent = numberBasket;
    }
}
function onButtonClick() {
    numberBasket = parseInt(localStorage.getItem('itemsInBasket')) + 1;
    localStorage.setItem('itemsInBasket', numberBasket);
    document.querySelector('.fa-shopping-basket-container span').textContent = numberBasket;

    /*part about product info*/
    const productName = document.querySelector('.product-name').textContent;
    const productPrice = document.querySelector('.product-price').textContent;
    const productImage = document.querySelector('.product-image').src;

    if (localStorage.getItem('products')) {
        const parsed = JSON.parse(localStorage.getItem('products'));
        const localSpace = parsed;
        console.log(localSpace);

        const newProduct = {
            name: productName,
            price: productPrice,
            image: productImage
        }
        console.log(newProduct);
        localSpace.push(newProduct);
        const stringified = JSON.stringify(localSpace);
        localStorage.setItem('products', stringified);
    }
    else {
        const newProduct = {
            name: productName,
            price: productPrice,
            image: productImage
        }
        console.log(newProduct);
        myJSON.push(newProduct);
        const stringified = JSON.stringify(myJSON);
        localStorage.setItem('products', stringified);
    }
    document.querySelector('.btn-add').disabled = true;
    document.querySelector('.error-message').style.display = 'block';
}
function onButtonClickk() {
    if (numberBasket) {
        numberBasket = parseInt(localStorage.getItem('itemsInBasket')) - 1;
        localStorage.setItem('itemsInBasket', numberBasket);
        document.querySelector('.fa-shopping-basket-container span').textContent = numberBasket;
        const productName = document.querySelector('.product-name').textContent;
        const parsed = JSON.parse(localStorage.getItem('products'));
        const localSpace = parsed;
        const filter = localSpace.filter(product => product.name !== productName);
        console.log(filter);
        const stringified = JSON.stringify(filter);
        localStorage.setItem('products', stringified);

        document.querySelector('.btn-add').disabled = false;
        document.querySelector('.error-message').style.display = 'none';
    }
}
/*sending info to basket*/
function basketo() {
    let price = 0;

    const products = JSON.parse(localStorage.getItem('products'));

    products.forEach(product => {
        const convertNumber = parseInt(product.price);
        price += convertNumber;
        console.log(convertNumber);

        const productContainer = document.createElement('div');
        productContainer.classList.add('product');
        const productImage = document.createElement('img');
        productImage.classList.add('product-picture');
        const productInfo = document.createElement('div');
        productInfo.classList.add('product-info');
        const productName = document.createElement('h3');
        productName.classList.add('product-name');
        const productPrice = document.createElement('h2');
        productPrice.classList.add('product-price');
        const productButton = document.createElement('button');
        productButton.classList.add('btn');
        productButton.classList.add('product-remove');
        const productsContainer = document.querySelector('.products');
        productsContainer.appendChild(productContainer);
        productContainer.appendChild(productImage);
        productContainer.appendChild(productInfo);
        productInfo.appendChild(productName);
        productInfo.appendChild(productPrice);
        productInfo.appendChild(productButton);

        productImage.src = product.image;
        productName.innerHTML = product.name;
        productPrice.innerHTML = product.price;
        productButton.innerHTML = 'remove';
    })

    const totalPrice = document.querySelector('.total-price');
    totalPrice.innerHTML = price;

    document.querySelector('.all-products').innerHTML = products.length;

}









