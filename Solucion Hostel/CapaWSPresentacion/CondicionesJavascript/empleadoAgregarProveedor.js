var formularioRegistro = document.getElementById('form1'),
rut = formularioRegistro.txtRutEmpresa,
razonSocial = formularioRegistro.txtRazonSocial,
giro = formularioRegistro.txtGiro,
calle = formularioRegistro.txtCalle,
ciudad = formularioRegistro.txtNombreCiudad,
comuna = formularioRegistro.txtComuna,
correo = formularioRegistro.txtCorreoElectronico,
telefonoEmpresa = formularioRegistro.txtTelefonoEmpresa,
mailUsuario = formularioRegistro.txtMailUsuario,
contrasena = formularioRegistro.txtConstrasena,
error = document.getElementById('error');


function validarRut(l) {
    if (rut.value == null || rut.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarRazonSocial(l) {
    if (razonSocial.value == null || razonSocial.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarGiro(l) {
    if (giro.value == null || giro.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarCalle(l) {
    if (calle.value == null || calle.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarCiudad(l) {
    if (ciudad.value == null || ciudad.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarComuna(l) {
    if (comuna.value == null || comuna.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarCorreo(l) {
    if (comuna.value == null || comuna.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarTelefonoEmpresa(l) {
    if (telefonoEmpresa.value == null || telefonoEmpresa.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarMailUsuario(l) {
    if (mailUsuario.value == null || mailUsuario.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarContrasena(l) {
    if (contrasena.value == null || contrasena.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}


function validarFormulario(l) {
    error.innerHTML = '';
    validarRut(l);
    validarRazonSocial(l);
    validarGiro(l);
    validarCalle(l);
    validarCiudad(l);
    validarComuna(l);
    validarUsuario(l);
    validarCorreo(l);
    validarTelefonoEmpresa(l);
    validarMailUsuario(l);
    validarContrasena(l);

    if (error.innerHTML == '') {
        alert("Usuario ingresado exitosamente");
    }
}

document.getElementById("btnModificar").addEventListener("click", validarFormulario);