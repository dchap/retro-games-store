var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url:'/admin/user/getall'},
        "columns": [
            { "data": "name", "width": "15%" },
            { "data": "email", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            { "data": "company.name", "width": "15%" },
            { "data": "role", "width": "15%" },
            {
                data: { id:"id", lockoutEnd:"lockoutEnd"},
                "render": function (data) {
                    return `
                    <div class="text-center">
                            <a href="/admin/user/RoleManagment?userId=${data.id}" class="btn btn-danger text-white" style="cursor:pointer; width:150px;">
                                    <i class="bi bi-pencil-square"></i> Permission
                            </a>
                    </div>`
                    
                },
                "width": "25%"
            }
        ]
    });
}