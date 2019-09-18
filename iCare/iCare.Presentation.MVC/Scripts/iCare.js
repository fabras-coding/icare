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