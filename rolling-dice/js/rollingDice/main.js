// Put your code here

console.log("Let's roll some dice, baby!")
console.log("---------------------------");

// console log 10 die rolls
for (let i = 0; i < 10; i++) {
  const die1 = Roll();
  const die2 = Roll();

  let message = `${die1.dieString} + ${die2.dieString} == ${die1.dieValue + die2.dieValue}`;
  if (die1.dieValue == die2.dieValue) {
    message += " DOUBLES!";
  }

  console.log(message);
}

// function to roll a die
// generates a random number between 1 and 6
// constructs a new die object with the random number as its value
function Roll() {
  let dieString = "";
  const dieValue = getRandomInt(1, 6);

  if (dieValue === 1) {
    dieString = "\u2680";
  } else if (dieValue === 2) {
    dieString = "\u2681";
  } else if (dieValue === 3) {
    dieString = "\u2682";
  } else if (dieValue === 4) {
    dieString = "\u2683";
  } else if (dieValue === 5) {
    dieString = "\u2684";
  } else if (dieValue === 6) {
    dieString = "\u2685";
  }

  const tonyTaco = {dieString, dieValue};
  return tonyTaco;
}

// function to generate a random number
function getRandomInt(min, max) {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
}


