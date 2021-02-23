$(() => {
    $('#TipoContato').on('change', function () {

        $('#DescricaoContato').attr('disabled', 'disabled');
        $('#DescricaoContato').val('');
        $('#DescricaoContato').unmask();

        if ($(this).val() != 'Selecione') {

            if ($('#TipoContato :selected').data('mascara') !== undefined) {
                $('#DescricaoContato').mask($('#TipoContato :selected').data('mascara'))
                console.log($('#TipoContato :selected').data('mascara'))
            }
            else {
                $('#DescricaoContato').unmask();
            }

            $('#DescricaoContato').removeAttr('disabled')
        }
    })
})

let adicionarContato = function () {


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

    let indexRow = $('#hdnTotalContatos').val();
    let html = [];
    html.push(`<tr>`);
    html.push(`    <td>`);
    html.push(`        <input type="hidden" id="PessoaContato[${indexRow}].TipoContato" name="PessoaContato[${indexRow}].TipoContato" value="${$('#TipoContato').val()}"/>`)
    html.push(`        <input type="hidden" id="PessoaContato[${indexRow}].DescricaoContato" name="PessoaContato[${indexRow}].DescricaoContato" value="${$('#DescricaoContato').val()}"/>`)
    html.push(`        ${$('#TipoContato :selected').text()}`)
    html.push(`    </td>`)
    html.push(`    <td>${$('#DescricaoContato').val()}</td>`)
    html.push(`    <td></td>`)
    html.push(`</tr>`);

    $('#tbContatos').append(html.join(''));
    $('#hdnTotalContatos').val(indexRow++);

    $.map($('#modalContato input, select'), function (item, index) {
        item.value = ''
        $(item).removeClass('is-invalid')
    })


    $('#modalContato').modal('hide');

};