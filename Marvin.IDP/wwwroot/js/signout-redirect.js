window.addEventListener("load", function () {
    var a = document.querySelector("a.PostLogoutRedirectUri");
    if (a) {
        window.location = a.href;
       
    }
    this.setTimeout(function () {
        window.location = "https://localhost:44301/";

    }, 4000)

    
});
