var formularioRegistro = document.getElementById('form1'),
proveedor = formularioRegistro.txtProveedorAgregar,
producto = formularioRegistro.txtDetProdAgregar,
precio = formularioRegistro.txtPrecioProdAgregar,
stock = formularioRegistro.txtStock,
critico = formularioRegistro.txtStockCritico,
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

function validarPrecio(e) {
    if (precio.value == null || precio.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarStock(e) {
    if (stock.value == null || stock.value == '') {
        error.style.display = 'block';
        error.innerHTML = error.innerHTML + '<li> Ingrese solo los numeros de rut </li>';
        e.preventDefault();
    } else {
        error.style.display = 'none';
    }
}

function validarCritico(e) {
    if (critico.value == null || critico.value == '') {
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
    validarPrecio(e);
    validarStock(e);
    validarCritico(e);

    if (error.innerHTML == '') {
        alert("Usuario ingresado exitosamente");
    }
}

document.getElementById("btnRegistrar").addEventListener("click", validarFormulario);