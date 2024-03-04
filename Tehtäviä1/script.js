
function funktio1() {
    let numero1 = document.getElementById('annaNumero1').value;
    let numero2 = document.getElementById('annaNumero2').value;
    let numero3 = document.getElementById('annaNumero3').value;
    let numerot = [numero1, numero2, numero3];
    numerot.sort(function(a, b){return a-b});
    console.log(numerot);
  }

function funktio2() {
    let numero12 = document.getElementById('annaNumero12').value;
    let numero22 = document.getElementById('annaNumero22').value;
    let numero32 = document.getElementById('annaNumero32').value;
    let numero42 = document.getElementById('annaNumero42').value;
    let numero52 = document.getElementById('annaNumero52').value;
    console.log(Math.max(numero12, numero22, numero32, numero42, numero52));
}

function funktio3() {
    let Numero13 = document.getElementById('annaNumero13').value;
    if(Numero13 % 2 == 0) {
        console.log("Numero on parillinen.")
    }
    else {
        console.log("Numero on pariton.")
    }
}

function funktio4() {
    let Numero14 = document.getElementById('annaNumero14').value;
    if(Numero14 >= 18) {
        console.log("Saat ajaa polkupyörää, mopoa sekä autoa.")
    }
    else if(Numero14 >= 15) {
        console.log("Saat ajaa polkupyörää sekä mopoa.")
    }
    else {
        console.log("Saat ajaa polkupyörää.")
    }
}

function funktio5() {
    let kieli = document.getElementById('annakieli').value;
    if(kieli == "Saksa") {
        console.log("Hallo Welt!")
    }
    if(kieli == "Englanti") {
        console.log("Hello World!")
    }
    if(kieli == "Ruotsi") {
        console.log("Hallå världen!")
    }
}