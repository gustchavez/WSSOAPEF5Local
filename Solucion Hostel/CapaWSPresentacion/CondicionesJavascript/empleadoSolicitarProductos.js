var formularioRegistro = document.getElementById('form1'),
proveedor = formularioRegistro.txtProveedor,
producto = formularioRegistro.txtProducto,
cantidad = formularioRegistro.txtCantidad,
error = document.getElementById('error');


function validarProveedor(e) {
    if (proveedor.value == null || proveedor.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarProducto(e) {
    if (producto.value == null || producto.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}


function validarCantidad(e) {
    if (cantidad.value == null || cantidad.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}



function validarFormulario(e) {
    error.innerHTML = '';
    validarProveedor(e);
    validarProducto(e);
    validarCantidad(e);

    if (error.innerHTML == '') {
        alert("Usuario ingresado exitosamente");
    }
}

document.getElementById("btnRegistrar").addEventListener("click", validarFormulario);