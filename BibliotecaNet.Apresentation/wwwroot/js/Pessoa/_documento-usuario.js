$(() => {
    $('#TipoDocumento').on('change', function () {

        $('#DescricaoContato').attr('disabled', 'disabled');
        $('#DescricaoContato').val('');
        $('#DescricaoContato').unmask();

        if ($(this).val() != 'Selecione') {

            if ($('#TipoDocumento :selected').data('mascara') !== undefined) {
                $('#DescricaoDocumento').mask($('#TipoDocumento :selected').data('mascara'))
            }
            else {
                $('#DescricaoDocumento').unmask();
            }

            $('#DescricaoDocumento').removeAttr('disabled')
        }
    })
})

let adicionarDocumento = function () {


    let formularioValido = true


    $.map($('#modalDocumento input[required], select[required]'), function (item, index) {

        if ($(item).val() == '') {
            formularioValido = false;
            $(item).addClass('is-invalid')
        }
    });

    if (!formularioValido) {
        return;
    }

    let indexRow = $('#hdnTotalDocumentos').val();
    let html = [];
    html.push(`<tr>`);
    html.push(`    <td>`);
    html.push(`        <input type="hidden" id="PessoaDocumento[${indexRow}].TipoDocumento" name="PessoaDocumento[${indexRow}].TipoDocumento" value="${$('#TipoDocumento').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaDocumento[${indexRow}].DescricaoDocumento" name="PessoaDocumento[${indexRow}].DescricaoDocumento" value="${$('#DescricaoDocumento').val()}"/>`)
    html.push(`        ${$('#TipoDocumento :selected').text()}`)
    html.push(`    </td>`)
    html.push(`    <td>${$('#DescricaoDocumento').val()}</td>`)
    html.push(`    <td></td>`)
    html.push(`</tr>`);

    $('#tbDocumentos').append(html.join(''));
    $('#hdnTotalDocumentos').val(indexRow++);

    $.map($('#modalContato input, select'), function (item, index) {
        item.value = ''
        $(item).removeClass('is-invalid')
    })


    $('#modalDocumento').modal('hide');

};