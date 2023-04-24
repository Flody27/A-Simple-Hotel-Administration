let cantCamas = document.getElementById("cantCamas")
let fechaEntrada = document.getElementById("date-in")
let fechaSalida = document.getElementById("date-out")
let precio = document.getElementById("precio")
let precioFinal = document.getElementById("precioFinal")

let boton = document.getElementById("ReservarHabitacion")

// Se recupera los datos del local storage
cantCamas.value = localStorage.getItem("cantCamas")
fechaEntrada.value = localStorage.getItem("fechaEntrada")
fechaSalida.value = localStorage.getItem("fechaSalida")

// Se obtine las noches que se va a hospedar
//let fechaEntradaFormat = covertirFecha(fechaEntrada.value)
//let fechaSalidaFormat = covertirFecha(fechaSalida.value)
//let diferencia = fechaSalidaFormat - fechaEntradaFormat
//var noches = Math.round(diferencia / (1000 * 60 * 60 * 24));
//console.log(precio.value, noches)

//precioFinal.value = precio.value * noches

calcularEstadia()

//fechaEntrada.addEventListener("change", () => {
//    calcularEstadia()
//})

// Se remueven los datos del local storage
boton.addEventListener(("click"), () => {
    localStorage.removeItem("cantCamas")
    localStorage.removeItem("fechaEntrada")
    localStorage.removeItem("fechaSalida")
})


function covertirFecha(value) {
    var fecha = new Date(Date.parse(value));
    return fecha.getTime();
}

function calcularEstadia() {
    let fechaEntradaFormat = covertirFecha(fechaEntrada.value)
    let fechaSalidaFormat = covertirFecha(fechaSalida.value)
    let diferencia = fechaSalidaFormat - fechaEntradaFormat
    var noches = Math.round(diferencia / (1000 * 60 * 60 * 24));
    var calcPrecio = precio.value * noches

    calcPrecio <= 0 ? precioFinal.value = precio.value : precioFinal.value = calcPrecio;

    console.log(precio.value, noches)
    
}

