let cantCamas = document.getElementById("cantCamas")
let fechaEntrada = document.getElementById("date-in")
let fechaSalida = document.getElementById("date-out")

let boton = document.getElementById("btnDisponibilidad")

boton.addEventListener(("click"), () => {
    localStorage.setItem("cantCamas", cantCamas.value)
    localStorage.setItem("fechaEntrada", fechaEntrada.value)
    localStorage.setItem("fechaSalida", fechaSalida.value)
})