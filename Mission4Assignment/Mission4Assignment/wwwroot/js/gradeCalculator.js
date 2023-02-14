// documnet.getElementById = $
// id = #id
// .value = .val()
$("#calculateGrade").click(function () {
    // calculate the overall percentage
    let percentage = (($("#assignments").val() * .5) + ($("#groupProject").val() * .1) + ($("#quizzes").val() * .1) + ($("#midterm").val() * .1) + ($("#final").val() * .1) + ($("#intex").val() * .1));

    // print on the page the grade they got
    if (percentage >= 94) {
        grade = "A";
    } else if (percentage >= 90) {
        grade = "A-"
    } else if (percentage >= 87) {
        grade = "B+"
    } else if (percentage >= 84) {
        grade = "B"
    } else if (percentage >= 80) {
        grade = "B-"
    } else if (percentage >= 77) {
        grade = "C+"
    } else if (percentage >= 74) {
        grade = "C"
    } else if (percentage >= 70) {
        grade = "C-"
    } else if (percentage >= 67) {
        grade = "D+"
    } else if (percentage >= 64) {
        grade = "D"
    } else if (percentage >= 60) {
        grade = "D-"
    } else {
        grade = "E"
    };
    alert("Your grade is " + grade + " with " + percentage + "%");
})