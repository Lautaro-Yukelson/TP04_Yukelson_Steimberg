// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function setearMedia(event) {
    let imagenClickeada = event.target;
    let idImagen = imagenClickeada.id;
    document.creador.media.value = idImagen;
}
  
function setearShort(event) {
    let imagenClickeada = event.target;
    let idImagen = imagenClickeada.id;
    document.creador.shorts.value = idImagen;
}
  
function setearRemera(event) {
    let imagenClickeada = event.target;
    let idImagen = imagenClickeada.id;
    document.creador.remera.value = idImagen;
}
  
function clickImagen() {
    // Obtener la fila de la imagen clickeada
    let fila = this.closest("tr");
    // Obtener todas las imágenes de la fila
    let imagenesFila = fila.querySelectorAll("img.no-select");
    // Si la imagen ya está seleccionada, deseleccionarla
    if (this.classList.contains("select")) {
        this.classList.remove("select");
    } else {
    // Si la imagen no está seleccionada, seleccionarla y deseleccionar
    // todas las demás imágenes de la misma fila
    for (let i = 0; i < imagenesFila.length; i++) {
        if (imagenesFila[i] !== this && imagenesFila[i].classList.contains("select")) {
            imagenesFila[i].classList.remove("select");
        }
      }
    this.classList.add("select");
    }
}
  
for (imagen of document.querySelectorAll("img.no-select")) {
    imagen.addEventListener("click", clickImagen);
}
  
  