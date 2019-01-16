document.getElementById("reset").addEventListener("click", startGame);

var scoreForPlayer1 = 0;
var scoreForPlayer2 = 0;

document.getElementById('score-x').innerHTML = scoreForPlayer1;
document.getElementById('score-o').innerHTML = scoreForPlayer2;

function startGame() {
 
  for(var i = 1; i <= 9; i++) {
    clearTable(i);
  }
  document.turn = "X";
  document.winner = null;
  setText(document.turn + " get's to start")
}

function setText(msg) {
  document.getElementById("message").innerText = msg;
}
function nextMove(square) {
  if(document.winner != null) {
    setText(document.turn + " already won")
  }
  else if(square.innerText == '') {
    square.innerText = document.turn;
    switchPlayer();
  }
  else {
    setText("Pick another square")
  }
}

function switchPlayer() {
  if(checkIfPlayerWon(document.turn)) {
    setText("Congrats " + document.turn + ", you won!")
    document.winner = document.turn;
    if(document.turn == "X") {
      scoreForPlayer1++;
    }
    else {
      scoreForPlayer2++;
    }
  document.getElementById("score-x").innerHTML = " " + scoreForPlayer1;
  document.getElementById("score-o").innerHTML = " " + scoreForPlayer2;

  pointOutput();
  }
  else if (checkIfDraw()) {
    setText("Draw");
  }
  else if(document.turn == "X") {
    document.turn = "O";
    setText(document.turn + ",it's your turn!")
  }
  else {
    document.turn = "X";
    setText(document.turn + ",it's your turn!")
  }
}

function checkIfPlayerWon(move) {
  var result = false;
  if(checkRow(1, 2, 3, move) || checkRow(4, 5, 6, move) || checkRow(7, 8, 9, move) || checkRow(1, 4, 7, move) ||
     checkRow(2, 5, 8, move) || checkRow(3, 6, 9, move) || checkRow(1, 5, 9, move) || checkRow(3, 5, 7, move)) {
      result = true;
    }
    return result;
}

function checkRow(a, b, c, move) {
  var result = false;
  if(getTable(a) == move && getTable(b) == move && getTable(c) == move) {
    result = true;
  }
  return result;
}

function getTable(number) {
  return document.getElementById("s" + number).innerText;
}

function clearTable(number) {
  document.getElementById("s" + number).innerText = "";
}

function checkIfDraw(){
  for (var i = 1; i <= 9; i = i + 1) { 
      if(getTable(i)=="") {
          return false;
      }
  }
  return true;
}

function pointOutput() {
  if(scoreForPlayer1 == 1) {
    document.getElementById("player1").innerHTML = "\&nbsp\;point!";
  }
  else {
    document.getElementById("player1").innerHTML = "\&nbsp\;points!";
  }
  if(scoreForPlayer2 == 1) {
    document.getElementById("player2").innerHTML =  "\&nbsp\;point!";
  }
  else {
    document.getElementById("player2").innerHTML =  "\&nbsp\;points!";
  }
}

function print() {
  document.getElementById("score-x").innerHTML = " " + scoreForPlayer1;
  document.getElementById("score-o").innerHTML = " " + scoreForPlayer2;
}