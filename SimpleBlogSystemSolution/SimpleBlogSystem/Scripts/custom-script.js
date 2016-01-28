function showText(id) {
    console.log("function");

    if (document.getElementById('content' + id).style.display == "none") {
        console.log("if");
        document.getElementById('label' + id).style.content = "\2212";
        document.getElementById('content' + id).style.display = "block";
    } else {
        console.log("else");

        document.getElementById('label' + id).style.content = "+";
        document.getElementById('content' + id).style.display = "none";
    }
}