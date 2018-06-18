var formularioRegistro = document.getElementById('formCliente'),
 razonSocial = formularioRegistro.txtRazonSocial,
 error = document.getElementById('error');


function validarRazon(l) {
    if (razonSocial.value == null || razonSocial.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}


function validarFormulario(l) {
    error.innerHTML = '';
    validarRazon(l);
    if (error.innerHTML == '') {
        alert("Usuario ingresado exitosamente");
    }
}

document.getElementById("btnModificar").addEventListener("click", validarFormulario);
