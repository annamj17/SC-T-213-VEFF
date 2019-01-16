var h1Element = document.querySelector('h1')
function h1Click() {
  alert('Hello World')
}
h1Element.addEventListener('click', h1Click)

var div = document.querySelector('div');
console.log(div.style.backgroundColor);

function hide() {
    div.style.display = "none";
}
var button = document.getElementById('hide');
console.log(button);
button.onclick = hide;

function sumOfTwo(number1, number2){
  return number1 + number2;
}

var input1 = document.getElementById("first-number");
var input2 = document.getElementById("second-number");

var button = document.getElementById('calculate');

button.onclick = function() {
  var input1number = Number(input1.value);
  var input2number = Number(input2.value);
  var result = sumOfTwo(input1number, input2number);
  var sum = document.getElementById('sum');
  sum.value = result;
};

var numberIncrement = document.getElementById('calculate-increment');
var numberDecrement = document.getElementById('calculate-decrement');
var numberReset = document.getElementById('calculate-reset');
var h2Element = document.querySelector("h2");

numberIncrement.addEventListener("click", increment);
numberDecrement.addEventListener("click", decrement);
numberReset.addEventListener("click", reset);

function increment(){
  h2Element.innerText = Number(h2Element.innerText) + 1;
}

function decrement(){
  h2Element.innerText = Number(h2Element.innerText) -1;
}

function reset(){
  h2Element.innerText = 0;
}

var coloredText = document.getElementById("color-text");
var colorSelector = document.getElementById("color-selector");
var colorButton = document.getElementById("color-button");

function changeColor() {
  coloredText.style.backgroundColor = colorSelector.value;
}

colorButton.addEventListener('click', changeColor);







