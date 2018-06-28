var formularioRegistro = document.getElementById('form2'),
rutEmpresa = formularioRegistro.txtRutEmpresa,
razonSocial = formularioRegistro.txtRazonSocial,
rubro = formularioRegistro.ddlRubro,
direccion = formularioRegistro.txtDireccion,
ciudad = formularioRegistro.txtNombreCiudad,
comuna = formularioRegistro.ddlComunas,
correo = formularioRegistro.txtCorreoElectronico,
telefono = formularioRegistro.txtTelefono,
contrasena = formularioRegistro.txtContraseña,
error = document.getElementById('error');


function validarRut(e) {
    if (rutEmpresa.value == null || rutEmpresa.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarRazon(e) {
    if (razonSocial.value == null || razonSocial.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}


function validarRubro(e) {
    if (rubro.value == '' || rubro.value == 'Selecciona un Giro') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Seleccione uno de los giros </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}


function validarDireccion(e) {
    if (direccion.value == '' || direccion.value == null) {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Seleccione uno de los giros </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarCiudad(e) {
    if (ciudad.value == '' || ciudad.value == null) {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Seleccione uno de los giros </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarComuna(e) {
    if (comuna.value == '' || comuna.value == null) {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Seleccione uno de los giros </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarCorreo(e) {
    if (correo.value == '' || correo.value == null) {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Seleccione uno de los giros </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarTelefono(e) {
    if (telefono.value == '' || telefono.value == null) {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Seleccione uno de los giros </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarContrasena(e) {
    if (contrasena.value == '' || contrasena.value == null) {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Seleccione uno de los giros </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}



function validarFormulario(e) {
    error.innerHTML = '';
    validarRut(e);
    validarRazon(e);
    validarRubro(e);
    validarDireccion(e);
    validarCiudad(e);
    validarComuna(e);
    validarCorreo(e);
    validarTelefono(e);
    validarContrasena(e);
    if (error.innerHTML == '') {
        alert("Usuario ingresado exitosamente");
    }
}

document.getElementById("btnRegistrar").addEventListener("click", validarFormulario);