//// This is the javascript way
//// document.getElementById("btnSend").addEventListener("click", function () {
////    alert("From: " + document.getElementById("txtFrom").value +
////        ", Subject: " + document.getElementById("txtSubject").value +
////        ", Message: " + document.getElementById("txtMessage").value);
////})

//// this is the jquery way
$("#btnSend").click(function () {
    alert("From: " + $("#txtFrom").val() +
        ", Subject: " + $("#txtSubject").val() +
        ", Message: " + $("#txtMessage").val());
    $("#picGanderson").fadeToggle;
})