// Write your Javascript code.
function activateSlider() {
    $("#heightSlider").roundSlider({
    sliderType: "min-range",
    circleShape: "custom-quarter",
    min: 0,
    max: 29,
    value: 3,
    startAngle: 45,
    editableTooltip: false,
    radius: 300,
    width: 20,
    handleShape: "dot",
    tooltipFormat: "tooltipVal1"
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
});