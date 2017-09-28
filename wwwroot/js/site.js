// Write your Javascript code.
function activateSlider() {
   $("#heightSlider").roundSlider({
    radius: 200,
    min:0,
    max:29,
    width: 1,
    value: 14,
    handleSize: "+14",
    tooltipFormat: "tooltipVal1"
    });

    $("#ageRangeSlider").roundSlider({
    radius: 200,
    width: 10,
    min: 18,
    max: 100,
    handleSize: "+10",
    sliderType: "range",
    value: "25,40"
});
}

function tooltipVal1(args) {
    var months = ["4'5\"", "4'6\"", "4'7\"", 
                  "4'8\"", "4'9\"", "4'10\"", "4'11\"",
                  "5'0\"", "5'1\"", "5'2\"", 
                  "5'3\"", "5'4\"","5'5\"","5'6\"","5'7\"",
                  "5'8\"","5'9\"","5'10\"","5'11\"","6'0\"", "6'1\"",
                  "6'2\"","6'3\"","6'4\"","6'5\"","6'6\"","6'7\"","6'8\"",
                  "6'9\"","6'10\""];

    return months[args.value];
}

$(document).ready(function () {
  activateSlider();

  $(".height-btn").click(function(){
      var height = $("#heightSlider").getValue();
      $.ajax({
        type: "POST",
        url: "/Home/Height",
        data: height
        });
  })
});
// Get the modal
var modal = document.getElementById('myModal');

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on the button, open the modal 
btn.onclick = function() {
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function() {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}