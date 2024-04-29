const ball1 = document.querySelector('#ball1');
const ball2 = document.querySelector('#ball2');
const ball3 = document.querySelector('#ball3');

ball1.onclick = function() {
    ball1.style.opacity = 0;
}

ball2.onclick = function() {
    let y = 0;

    setInterval(function()
        {
            ball2.style.marginLeft = (y + "px");
            y += 1;
        },
        1);
}

ball3.onclick = function() {
    if (!this.classList.contains('move-right')) {
        this.classList.add('move-right');
    } else {
        this.classList.remove('move-right');
    }
}