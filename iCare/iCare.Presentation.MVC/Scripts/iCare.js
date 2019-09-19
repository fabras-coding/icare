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

function MostrarFoto(src) {

	alert(src);
	$("#bodymodalFoto").html("<img src='data:image/png;base64,"+src+"  />");
	$("#bodymodalFoto").modal("show");

}