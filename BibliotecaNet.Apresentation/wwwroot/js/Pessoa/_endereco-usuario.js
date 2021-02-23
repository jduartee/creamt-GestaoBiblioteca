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
    html.push(`        <input type="hidden" id="PessoaEndereco[${indexRow}].Cep" name="PessoaEndereco[${indexRow}].Cep" value="${$('#Cep').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaEndereco[${indexRow}].Cidade" name="PessoaEndereco[${indexRow}].Cidade" value="${$('#Cidade').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaEndereco[${indexRow}].Estado" name="PessoaEndereco[${indexRow}].Estado" value="${$('#Estado').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaEndereco[${indexRow}].Bairro" name="PessoaEndereco[${indexRow}].Bairro" value="${$('#Bairro').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaEndereco[${indexRow}].Logradouro" name="PessoaEndereco[${indexRow}].Logradouro" value="${$('#Logradouro').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaEndereco[${indexRow}].Numero" name="PessoaEndereco[${indexRow}].Numero" value="${$('#Numero').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaEndereco[${indexRow}].Complemento" name="PessoaEndereco[${indexRow}].Complemento" value="${$('#Complemento').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaEndereco[${indexRow}].EnderecoPrincipal" name="PessoaEndereco[${indexRow}].EnderecoPrincipal" value="${$('#EnderecoPrincipal').prop('checked')}"/>`)
    html.push(`        ${$('#Cep').text()}`)
    html.push(`    </td>`)
    html.push(`    <td>${$('#Cidade').val()}</td>`)
    html.push(`    <td>${$('#Estado').val()}</td>`)
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