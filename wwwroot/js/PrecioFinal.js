const precio = document.getElementsByClassName("precio");
let precioFinal = 0;
let numero;

for (let x of precio) {
    numero = x.innerHTML.slice(1);
    precioFinal += Number(numero);
}

const mostrarPrecio = document.getElementById("mostrarPrecio");
mostrarPrecio.innerHTML = "Precio final: $" + precioFinal;