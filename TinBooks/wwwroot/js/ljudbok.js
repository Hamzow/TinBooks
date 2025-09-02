var numberOfDrumButtons = document.querySelectorAll(".drum").length;

for (var i = 0; i < numberOfDrumButtons; i++) {
    document.querySelectorAll(".drum")[i].addEventListener("click", function() {
        var buttonInnerHTML = this.innerHTML.trim(); // trim() för att ta bort eventuella mellanslag

        makeSound(buttonInnerHTML);
        buttonAnimation(buttonInnerHTML);
    });
}

document.addEventListener("keypress", function(event) {
    makeSound(event.key);
    buttonAnimation(event.key);
});

function makeSound(key) {
    switch (key.toLowerCase()) {
        case "mästaren och margarita":
            var tom1 = new Audio("/sounds/Mästren-1.mp3");
            tom1.play();
            break;
        case "sagan om ringen":
            var tom2 = new Audio("/sounds/Sagan.mp3");
            tom2.play();
            break;

        default:
            console.log("Ljudfiler saknas för " + key);
    }
}

function buttonAnimation(currentKey) {
    var buttons = document.querySelectorAll(".drum");
    for (var i = 0; i < buttons.length; i++) {
        if (buttons[i].innerHTML.trim() === currentKey) {
            buttons[i].classList.add("pressed");
            setTimeout(function() {
                buttons[i].classList.remove("pressed");
            }, 100);
            break;
        }
    }
}
