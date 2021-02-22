$(() => {
});

let adicionarEndereco = function () {

    let formularioValido = true


    $.map($('#myModal input[required], select[required]'), function (item, index) {

        if ($(item).val() == '') {
            formularioValido = false;
            $(item).addClass('is-invalid')
        }
    });

    if (!formularioValido) {
        return;
    }

    let indexRow = $('#hdnTotalEnderecos').val();
    let html = [];
    html.push(`<tr>`);
    html.push(`    <td>`);
    html.push(`        <input type="hidden" id="Input.UserAddress[${indexRow}].Cep" name="Input.UserAddress[${indexRow}].Cep" value="${$('#Cep').val()}"/>`)
    html.push(`        <input type="hidden" id="Input.UserAddress[${indexRow}].Cidade" name="Input.UserAddress[${indexRow}].Cidade" value="${$('#Cidade').val()}"/>`)
    html.push(`        <input type="hidden" id="Input.UserAddress[${indexRow}].Bairro" name="Input.UserAddress[${indexRow}].Bairro" value="${$('#Bairro').val()}"/>`)
    html.push(`        <input type="hidden" id="Input.UserAddress[${indexRow}].Logradouro" name="Input.UserAddress[${indexRow}].Logradouro" value="${$('#Logradouro').val()}"/>`)
    html.push(`        <input type="hidden" id="Input.UserAddress[${indexRow}].Numero" name="Input.UserAddress[${indexRow}].Numero" value="${$('#Numero').val()}"/>`)
    html.push(`        <input type="hidden" id="Input.UserAddress[${indexRow}].Complemento" name="Input.UserAddress[${indexRow}].Complemento" value="${$('#Complemento').val()}"/>`)
    html.push(`        <input type="hidden" id="Input.UserAddress[${indexRow}].EnderecoPrincipal" name="Input.UserAddress[${indexRow}].EnderecoPrincipal" value="${$('#EnderecoPrincipal').prop('checked')}"/>`)

    html.push(`        ${$('#UserEnderecoTipo :selected').text()}`)
    html.push(`    </td>`)
    html.push(`    <td>${$('#Cep').val()}</td>`)
    html.push(`    <td>${$('#Cidade').val()}</td>`)
    html.push(`    <td>${$('#Bairro').val()}</td>`)
    html.push(`    <td>${$('#Logradouro').val()}</td>`)
    html.push(`    <td>${$('#Numero').val()}</td>`)
    html.push(`    <td>${$('#Complemento').val()}</td>`)
    html.push(`    <td>${$('#EnderecoPrincipal').prop('checked') ? 'Sim' : 'Não'}</td>`)
    html.push(`</tr>`);

    $('#tbEnderecos').append(html.join(''));
    $('#hdnTotalEnderecos').val(indexRow++);

    $.map($('#myModal input, select'), function (item, index) {
        item.value = ''
        $(item).removeClass('is-invalid')
    })


    $('#myModal').modal('hide');
}