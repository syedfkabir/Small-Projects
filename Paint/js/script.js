// JavaScript source code
function makeSearch() {
    alert("Code to make AJAX Call");
    return false;
}

function requestQuote() {


    var fName = document.getElementById("tbName").value;
    var fEmail = document.getElementById("tbEmail").value;
    var fRoom = document.getElementById("tbRoom").value;
    var fRoomW = document.getElementById("tbHeight").value;
    var fRoomH = document.getElementById("tbWidth").value;
    var fColor = document.getElementById("tbColor").value;
    var fType = document.getElementById("select").value;


    localStorage.setItem('Name', fName);
    localStorage.setItem('Email', fEmail);
    localStorage.setItem('Room', fRoom);
    localStorage.setItem('roomW', fRoomW);
    localStorage.setItem('roomH', fRoomH);
    localStorage.setItem('Color', fColor);
    localStorage.setItem('Type', fType);



}

function displayQuote() {

    var name = localStorage.getItem('Name');
    var email = localStorage.getItem('Email');
    var room = localStorage.getItem('Room');
    var roomw = localStorage.getItem('roomW');
    var roomh = localStorage.getItem('roomH');
    var color = localStorage.getItem('Color');
    var type = localStorage.getItem('Type');

    //console.log(roomw);

    document.getElementById("name").innerHTML = name;
    document.getElementById("email").innerHTML = email;

    document.getElementById("room").innerHTML = room;
    document.getElementById("roomw").innerHTML = roomw;
    document.getElementById("roomh").innerHTML = roomh;
    var dimensions = roomw * roomh;
    document.getElementById("dimensions").innerHTML = dimensions + " sqft";

    document.getElementById("selectedColor").innerHTML = color;
    document.getElementById("selectedColor").style.backgroundColor = color;

    var numberOfCans;
    numberOfCans = dimensions / 400;
    if (numberOfCans < 1) {
        numberOfCans = 1;
    } else {
        numberOfCans += 1;
    }
    document.getElementById("cans").innerHTML = Math.trunc(numberOfCans);

    document.getElementById("type").innerHTML = type;
    var finalCost;
    if (type.toString == "standard") {
        finalCost = 24.99 * Math.trunc(numberOfCans);

    } else {
        finalCost = 39.99 * Math.trunc(numberOfCans);
    }

    taxes = finalCost * .13;
    finalCost += taxes;
    document.getElementById("cost").innerHTML = finalCost.toFixed(2);


}
