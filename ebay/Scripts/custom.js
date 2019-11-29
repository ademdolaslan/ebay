$(function () {
    $("#producttable").DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json"
        }
    });
    //$("#regiontablo").DataTable({
    //    "language": {
    //        "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json"
    //    }
    //});
    $("#tblTerritories").DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json"
        }
    });
    $("#customertable").DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json"
        }
    });
    $("#regiontablo").on("click", ".regionsil", function () {
        if (confirm("Region Silmek İstediğinizden Eminmisiniz?")) {
            var id = $(this).data("id");
            var btn = $(this);
            $.ajax({
                type: "GET",
                url: "/Region/DeleteRegion/" + id,
                success: function () {
                    btn.parent().parent().remove();
                }
            });
        }


    });
});






