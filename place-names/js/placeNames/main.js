// Put your code here
console.log("All Place Names")

const placeNames = ["Nashville", "Hong Kong", "The back yard", "Earth",
"London", "The mall", "Ryman Auditorium", "The Great Wall of China"];

for (let i = 0; i < placeNames.length; i++) {
  console.log(placeNames[i])
}

console.log("'The' Place Names")

let places = placeNames.filter(placeName => placeName.startsWith("The"))

 for (let j = 0; j < places.length; j++) {
   console.log(places[j])
 }

