$(() => {
    $('#UserContatoTipo').on('change', function () {

        $('#DescricaoContato').attr('disabled', 'disabled');
        $('#DescricaoContato').val('');
        $('#DescricaoContato').unmask();

        if ($(this).val() != 'Selecione') {

            if ($('#UserContatoTipo :selected').data('mascara') !== undefined) {
                $('#DescricaoContato').mask($('#UserContatoTipo :selected').data('mascara'))
                console.log($('#UserContatoTipo :selected').data('mascara'))
            }
            else {
                $('#DescricaoContato').unmask();
            }

            $('#DescricaoContato').removeAttr('disabled')
        }
    })
})