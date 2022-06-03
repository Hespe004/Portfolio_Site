// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function likeMelding(userID, meldingID, likebtnID, likespanID) {
    //Maak een variabele van het type like aan die wordt doorgestuurd naar de POST methode in de api/likes controller
    const like = {
        UserID: userID,
        MeldingID: meldingID
    }
    fetch('/api/Likes', {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(like)
    })
    //Zorg dat de teller in de view met 1 omhoog gaat.
    //Maak een nieuwe variabele 'count' aan. De waarde van de variabele is de waarde van het element 'likecount' in de view. Indien deze NaN is wordt de waarde op 0 gezet.
    var count = parseInt(document.getElementById(likespanID).innerHTML);
    if (isNaN(count)) {
        count = 0;
    }
    //Tel 1 like bij de waarde op
    count += 1;
    //Wijzig de button en de span van de button
    document.getElementById(likebtnID).className = "fa fa-thumbs-down";
    document.getElementById(likespanID).innerHTML = '';
    let e = document.createTextNode(count);
    document.getElementById(likespanID).appendChild(e);

    document.getElementById(likebtnID).onclick = function () {
        unlikeMelding(userID, meldingID, likebtnID, likespanID)
    }
}
function unlikeMelding(userID, meldingID, likebtnID, likespanID) {
    //Maak een variabele van het type like aan die wordt doorgestuurd naar de DELETE methode in de api/likes controller
    const like = {
        UserID: userID,
        MeldingID: meldingID
    }
    fetch('/api/Likes', {
        method: "DELETE",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(like)
    })
    //Zorg dat de teller in de view met 1 omlaag gaat.
    //Maak een nieuwe variabele 'count' aan. De waarde van de variabele is de waarde van het element 'likecount' in de view. Indien deze NaN is wordt de waarde op 0 gezet.
    var count = parseInt(document.getElementById(likespanID).innerHTML) - 1;
    if (isNaN(count)) {
        count = 0;
    }
    //Wijzig de button en de span van de button
    document.getElementById(likebtnID).className = "fa fa-thumbs-up";
    document.getElementById(likespanID).innerHTML = '';
    let e = document.createTextNode(count);
    document.getElementById(likespanID).appendChild(e);

    document.getElementById(likebtnID).onclick = function () {
        likeMelding(userID, meldingID, likebtnID, likespanID)
    }
}


function reactieVote(userID, reactieID, btnIdv2, spanIdv2) {
    //Maak een variabele van het type reactieVote aan die wordt doorgestuurd naar de POST methode in de api/reactieVotes controller
    const vote = {
        VoteUserID: userID,
        VoteReactieID: reactieID
    }
    fetch('/api/ReactieVotes', {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(vote)
    })
    //Zorg dat de teller in de view met 1 omhoog gaat.
    //Maak een nieuwe variabele 'count' aan. De waarde van de variabele is de waarde van het element 'spanId' in de view. Indien deze NaN is wordt de waarde op 0 gezet.
    var count = parseInt(document.getElementById(spanIdv2).innerHTML);
    if (isNaN(count)) {
        count = 0;
    }
    count += 1;
    //Wijzig de button en de span van de button
    document.getElementById(btnIdv2).className = "fa fa-thumbs-down";
    document.getElementById(spanIdv2).innerHTML = '';
    let e = document.createTextNode(count);
    document.getElementById(spanIdv2).appendChild(e);

    document.getElementById(btnIdv2).onclick = function () {
        reactieUnVote(userID, reactieID, btnIdv2, spanIdv2)
    }

}

//Functie die een reactieVote verwijdert
function reactieUnVote(userID, reactieID, btnIdv2, spanIdv2) {
    //Maak een variabele van het type reactieVote aan die wordt doorgestuurd naar de DELETE methode in de api/reactieVotes controller
    const vote = {
        VoteUserID: userID,
        VoteReactieID: reactieID
    }
    fetch('/api/ReactieVotes', {
        method: "DELETE",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(vote)
    })
    //Zorg dat de teller in de view met 1 omlaag gaat.
    //Maak een nieuwe variabele 'count' aan. De waarde van de variabele is de waarde van het element 'spanId' in de view. Indien deze NaN is wordt de waarde op 0 gezet.
    var count = parseInt(document.getElementById(spanIdv2).innerHTML) - 1;
    if (isNaN(count)) {
        count = 0;
    }
    //Wijzig de button en de span van de button
    document.getElementById(btnIdv2).className = "fa fa-thumbs-up";
    document.getElementById(spanIdv2).innerHTML = '';
    let e = document.createTextNode(count);
    document.getElementById(spanIdv2).appendChild(e);

    document.getElementById(btnIdv2).onclick = function () {
        reactieVote(userID, reactieID, btnIdv2, spanIdv2)
    }

}


//Maak variabelen aan die gebruikt worden voor de report-melding modal
var modal = document.getElementById("reportModal");
var btn = document.getElementById("reportButton");
var span = document.getElementsByClassName("close")[0];

btn.onclick = function () {
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}


//Functie die een report van een melding aanmaakt en doorstuurt naar de api/Report controller
function reportMelding(userID, meldingID) {
    var omschrijving = document.getElementById("reportomschrijving")
    const report = {
        UserID: userID,
        MeldingID: meldingID,
        Omschrijving: omschrijving.value
    }
    fetch('/api/Reports', {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(report)
    })
    //Zorg dat de pop-up uit beeld gaat
    modal.style.display = "none";
    document.getElementById("reportButton").innerHTML = "Melding gerapporteerd";
    document.getElementById("reportButton").className = "fa fa-flag-o";
    document.getElementById("reportButton").onclick = '';
    document.getElementById("reportButton").id = "reportButton3";
}