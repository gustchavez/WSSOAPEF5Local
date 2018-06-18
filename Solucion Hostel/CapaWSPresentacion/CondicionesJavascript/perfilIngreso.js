
var formularioRegistro = document.getElementById('formularioRegistro'),
 rutEmpresa = formularioRegistro.rutEmpresa,
 razonSocial = formularioRegistro.razonSocial,
 giro = formularioRegistro.giro,
 correo = formularioRegistro.correoElectronico,
 usuario = formularioRegistro.nombreUsuario,
 contrasena = formularioRegistro.contrasena,
 error = document.getElementById('error');

function validarRut(e) {
    if (rutEmpresa.value == null || rutEmpresa.value == '' ) {
		error.style.display= 'block';
		error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
		e.preventDefault();
	} else {
		error.style.display = 'none';
	}
}

function validarRazon(e) {
	if (razonSocial.value == null || razonSocial.value == '') {
		error.style.display= 'block';
		error.innerHTML = error.innerHTML + '<li> Ingrese una razón social </li>';
		e.preventDefault();
	} else {
		error.style.display = 'none';
	}
}


function validarGiro(e) {
	if (giro.value == '' || giro.value == 'Selecciona un Giro') {
		error.style.display= 'block';
		error.innerHTML = error.innerHTML + '<li> Seleccione uno de los giros </li>';
		e.preventDefault();
	} else {
		error.style.display = 'none';
	}
}


function validarCorreo(e) {
	if (correo.value == null || correo.value == '') {
		error.style.display= 'block';
		error.innerHTML = error.innerHTML + '<li> Favor ingrese un correo electrónico </li>';
		e.preventDefault();
	} else {
		error.style.display = 'none';
	}
}

function validarUsuario(e) {
	if (usuario.value == null || usuario.value == '') {
		error.style.display= 'block';
		error.innerHTML = error.innerHTML + '<li> Favor ingrese un nombre de usuario</li>';
		e.preventDefault();
	} else {
		error.style.display = 'none';
	}
}

function validarContrasena(e) {
	if (contrasena.value == null || contrasena.value == '') {
		error.style.display= 'block';
		error.innerHTML = error.innerHTML + '<li> Favor ingrese una contraseña </li>';
		e.preventDefault();
	} else {
		error.style.display = 'none';
	}
}


function validarFormulario(e) {
    error.innerHTML = '';
    validarRut(e);
    validarRazon(e);
    validarGiro(e);
    validarCorreo(e);
    validarUsuario(e);
    validarContrasena(e);
    if (error.innerHTML == '') {
        alert("Usuario ingresado exitosamente");
    }
}

document.getElementById("btnRegistrar").addEventListener("click", validarFormulario);



 /* formulairo Ingreso */

var formularioIngreso = document.getElementById('formularioRegistro'),
 usuario2 = formularioIngreso.txtNombreUsuario,
 contrasena2 = formularioIngreso.txtClaveUsuario,
 error2 = document.getElementById('error2');


function validarUsuario2(i) {
	if (usuario2.value == null || usuario2.value == '') {
		error2.style.display= 'block';
		error2.innerHTML = error2.innerHTML + '<li> Ingrese su usuario </li>';
		i.preventDefault();
	} else {
		error2.style.display = 'none';
	}
}

function validarContrasena2(i) {
	if (contrasena2.value == null || contrasena2.value == '') {
		error2.style.display= 'block';
		error2.innerHTML = error2.innerHTML + '<li> Ingrese su contraseña </li>';
		i.preventDefault();
	} else {
		error2.style.display = 'none';
	}
}

function validarFormularioIngreso(i) {
	error2.innerHTML = '';
	validarUsuario2(i);
	validarContrasena2(i);
}

document.getElementById("btnAceptar").addEventListener("click", validarFormularioIngreso);






