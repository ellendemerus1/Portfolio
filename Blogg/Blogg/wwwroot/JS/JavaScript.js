//Skapa eventlistners för varje textarea
document.querySelector("#PostHeader").addEventListener(
    "keyup", function () { countCharacters('#PostHeader', '#counter') });

document.querySelector("#PostText").addEventListener(
    "keyup", function () { countCharacters('#PostText', '#counter2') });


//Generell funktion för räknare
function countCharacters(source, target) {
    let maxLength = document.querySelector(source).maxLength;
    let length = document.querySelector(source).value.length;
    document.querySelector(target).innerHTML = length + "/" + maxLength;
}