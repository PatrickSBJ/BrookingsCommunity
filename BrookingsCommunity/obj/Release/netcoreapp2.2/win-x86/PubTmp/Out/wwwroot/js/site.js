// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var colors = ["", "#d7d7e9", "orange", "#e0e9d7", "white",
    "#e9d7e0"];

setInterval(changeBackgroundColor, 5000);

function changeBackgroundColor()
{
    document.body.style.backgroundColor = colors[Math.floor((Math.random() * 5) + 1)]
}