// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function openModal(id) {
    $("#divModal").modal("show");
    var i = 0;
    for (i = 0; i < dataCat.length; i++) {
        if (dataCat[i].MaSp == id)
            break;
    }
    var cat = dataCat[i];
    console.log(cat);
    $("#txtTsp").val(cat.TenSp);
    $("#txtDvt").val(cat.Donvitinh);
    $("#txtDg").val(cat.Dongia);
    $("#txtlsp").val(cat.MaLoaiSp);
}
