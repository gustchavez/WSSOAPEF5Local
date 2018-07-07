alert("rea");
var razonSocial = document.getElementById('<%= txtRazonSocial.ClientID %>').value;
var rubro = document.getElementById('<%= ddlRubro.ClientID %>').value;
var direccion = document.getElementById('<%= txtDireccion.ClientID %>').value;
var ciudad = document.getElementById('<%= txtNombreCiudad.ClientID %>').value;
var comuna = document.getElementById('<%= ddlComunas.ClientID %>').value;
var correo = document.getElementById('<%= txtCorreoElectronico.ClientID %>').value;
var telefono = document.getElementById('<%= txtTelefono.ClientID %>').value;
var contrasena = document.getElementById('<%= txtContraseña.ClientID %>').value;


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
    alert("lala");
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

document.getElementById(Button1.ClientID ).addEventListener("click", validarFormulario);