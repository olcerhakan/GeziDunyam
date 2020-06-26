$(function () {
    $('table[data-table="true"]').DataTable({
        "responsive": true,
        "autoWidth": false,
    });

    $('textarea[data-snote="true"]').summernote({
        height: 200
    });

    // https://getbootstrap.com/docs/4.4/components/modal/#via-javascript
    $("[data-delete-id]").click(function (event) {
        event.preventDefault();
        var button = $(this); 
        var id = button.data('delete-id')
        var name = button.data('delete-name') 
        var action = button.data('delete-action')
        $("#deleteModalForm").attr("action", action);
        $("#deleteModalItemName").text(name);
        $("#deleteModalItemId").val(id);
        $("#deleteModal").modal();
    });
}); 