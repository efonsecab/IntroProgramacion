function ReadSentValues(pNombre, pFechaNacimiento, pLblNombre, pLblFechaNacimiento) {
    //alert(lblNombre.innerHTML);
    pLblNombre.innerHTML = pNombre;
    pLblFechaNacimiento.innerHTML = pFechaNacimiento;

}
function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results == null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}