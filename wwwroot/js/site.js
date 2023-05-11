// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function setearMedia(){
    let imagenClickeada = event.target;
    let idImagen = imagenClickeada.id;
    document.creador.media.value = idImagen;
}

function setearShort(){
    let imagenClickeada = event.target;
    let idImagen = imagenClickeada.id;
    document.creador.shorts.value = idImagen;
}

function setearRemera(){
    let imagenClickeada = event.target;
    let idImagen = imagenClickeada.id;
    document.creador.remera.value = idImagen;
}