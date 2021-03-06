﻿$(function () {
    bsCustomFileInput.init();

    $('table[data-table="true"]').each(function (index) {
        var sortOrder = $(this).data("table-sort-order") || "asc";
        var sortColumn = $(this).data("table-sort-column") || 0;

        $(this).DataTable({
            "order": [[sortColumn, sortOrder]],
            "responsive": true,
            "autoWidth": false,
        });
    });

    $('textarea[data-snote="true"]').summernote({
        height: 200
    });

    // https://getbootstrap.com/docs/4.4/components/modal/#via-javascript
    $("body").on("click", "[data-delete-id]", function (event) {
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