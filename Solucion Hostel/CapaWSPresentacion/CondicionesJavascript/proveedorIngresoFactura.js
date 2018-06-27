var formularioRegistro = document.getElementById('form1'),
ordenes = formularioRegistro.ddlOrdenes,
fecha = formularioRegistro.txtFecha,
valorBruto = formularioRegistro.txtValorBruto,
valorIVA = formularioRegistro.txtValorIVA,
valorNeto = formularioRegistro.txtValorNeto,
observacion = formularioRegistro.txtObservacion,
codigoIso = formularioRegistro.txtCodigoISO,
medioPago = formularioRegistro.ddlMedioPago,
monto = formularioRegistro.txtMonto,
tasaCambio = formularioRegistro.txtTasaCambio,
divisa = formularioRegistro.txtDivisa,
error = document.getElementById('error');

function validarOrdenes(e) {
    if (ordenes.value == null || ordenes.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarFecha(e) {
    if (fecha.value == null || fecha.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarValorBruto(e) {
    if (valorBruto.value == null || valorBruto.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarValorIVA(e) {
    if (valorIVA.value == null || valorIVA.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarValorNeto(e) {
    if (valorNeto.value == null || valorNeto.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarObservacion(e) {
    if (observacion.value == null || observacion.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarCodigoIso(e) {
    if (codigoIso.value == null || codigoIso.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarMedioPago(e) {
    if (medioPago.value == null || medioPago.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarMonto(e) {
    if (monto.value == null || monto.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarTasaCambio(e) {
    if (tasaCambio.value == null || tasaCambio.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarDivisa(e) {
    if (divisa.value == null || divisa.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}


function validarFormulario(e) {
    error.innerHTML = '';
    validarOrdenes(e);
    validarFecha(e);
    validarValorBruto(e);
    validarValorIVA(e);
    validarValorNeto(e);
    validarObservacion(e);
    validarCodigoIso(e);
    validarMedioPago(e);
    validarMonto(e);
    validarTasaCambio(e);
    validarDivisa(e);

    if (error.innerHTML == '') {
        alert("Usuario ingresado exitosamente");
    }
}

document.getElementById("btnRegistrar").addEventListener("click", validarFormulario);