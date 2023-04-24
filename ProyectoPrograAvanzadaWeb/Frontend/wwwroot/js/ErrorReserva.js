let boton = document.getElementById("btn-home")

boton.addEventListener(("click"), () => {
    localStorage.removeItem("cantCamas")
    localStorage.removeItem("fechaEntrada")
    localStorage.removeItem("fechaSalida")
})


