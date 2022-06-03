"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    //var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + ": " + message;
    var li = document.createElement("li");
    var chat = document.createElement("chat");
    //var li = document.createElement("u");
    //var m = document.createElement("m");
    li.textContent = encodedMsg;
    //li.textContent = user +" ";
    //m.textContent = msg;
    document.getElementById("messagesList").appendChild(li, chat);
    appendMessage(user, BOT_IMG, "left", message);


    //document.getElementById("user").appendChild(li);
    //
    //document.getElementById("message").appendChild(m);
});

function appendMessage(user, message, side, img) {
    //   Simple solution for small apps
    const msgHTML = `
    <div class="msg ${side}-msg">
      <div class="msg-img" style="background-image: url(${img})"></div>

      <div class="msg-bubble">
        <div class="msg-info">
          <div class="msg-info-name">${user}</div>
          <div class="msg-info-time">${formatDate(new Date())}</div>
        </div>

        <div class="msg-text">${message}</div>
      </div>
    </div>
  `;

    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
}

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

document.getElementById("messageInput")
    .addEventListener("keyup", function(event) {
    event.preventDefault();
    if (event.keyCode === 13) {
        document.getElementById("sendButton").click();
    }
});

function AddZero(num) {
    return (num >= 0 && num < 10) ? "0" + num : num + "";
}

window.onload = function() {
    var now = new Date();
    var strDateTime = [[AddZero(now.getDate()), 
        AddZero(now.getMonth() + 1), 
        now.getFullYear()].join("/"), 
        [AddZero(now.getHours()), 
        AddZero(now.getMinutes())].join(":"), 
        now.getHours() >= 12 ? "PM" : "AM"].join(" ");
    document.getElementById("messagesList").innerHTML = "Send on: " + strDateTime;
};