$(document).ready(function () {

	$("#possuiReferencia").click(function () {

		if (!$("#possuiReferencia").prop("checked") === true) {
			$("#referencias").css("display", "none");
		}
		if ($("#possuiReferencia").prop("checked") === true) {
			$("#referencias").css("display", "block");
		}
	});


});

function ExibirReferencia(nome, contato) {
	$("#bodymodalFoto").html("<h2>Informações da referência</h2><h4>Nome: "+nome+"</h4><h4>Contato: "+contato +"</h4>");
	$("#modalFoto").modal("show");
}


function MostrarFoto(src) {

	$("#bodymodalFoto").html("<img width='500' height='500'  src='data:image/png;base64," + src + "'  />");
	$("#modalFoto").modal("show");

}