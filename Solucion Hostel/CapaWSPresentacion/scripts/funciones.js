$("#htmlbtnAgregar").click(function () {

    //alert( "paso3" + x);
    var nuevaFila="<tr>";
    nuevaFila+="<td><input name='txtFechaIngreso' id='txtFechaIngreso' type='text'></td>";
    nuevaFila+="<td><input name='txtFechaEgreso' id='txtFechaEgreso' type='text'></td>";
    nuevaFila+="<td><input name='txtObservacionCama' id='txtObservacionCama' type='text'></td>";
    nuevaFila+="</tr>";
    $("#tablaDetalle").append(nuevaFila);
    //alert( "paso4" );		
})


