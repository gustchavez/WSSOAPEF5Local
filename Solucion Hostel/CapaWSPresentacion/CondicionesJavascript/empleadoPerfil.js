var formularioRegistro = document.getElementById('form1'),
rut = formularioRegistro.txtRut,
nombre = formularioRegistro.txtNombre,
apellido = formularioRegistro.txtApellido,
correo = formularioRegistro.txtCorreoElectronico,
nacimiento = formularioRegistro.txtFechaNacimiento,
telefono = formularioRegistro.txtTelefono,
usuario = formularioRegistro.txtUsuario,
contrasena = formularioRegistro.txtContraseña,
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

function validarNombre(l) {
    if (nombre.value == null || nombre.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarApellido(l) {
    if (apellido.value == null || apellido.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarCorreo(l) {
    if (correo.value == null || correo.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarNacimiento(l) {
    if (nacimiento.value == null || nacimiento.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarTelefono(l) {
    if (telefono.value == null || telefono.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarUsuario(l) {
    if (usuario.value == null || usuario.value == '') {
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
    validarNombre(l);
    validarApellido(l);
    validarCorreo(l);
    validarNacimiento(l);
    validarTelefono(l);
    validarUsuario(l);
    validarContrasena(l);

    if (error.innerHTML == '') {
        alert("Usuario ingresado exitosamente");
    }
}

document.getElementById("btnModificar").addEventListener("click", validarFormulario);
