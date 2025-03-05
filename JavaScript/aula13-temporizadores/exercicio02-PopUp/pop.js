window.addEventListener('load', popUp)
function popUp(){
    var $modal = document.querySelector("#modal");
    var n=0;
    var time = setInterval(function (){
        $modal.classList.toggle('mostrar');
        if(n>=1){
            clearInterval(time)
            console.log(n)
        }
        n++
    }, 5000)
       
}