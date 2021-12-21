// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function read_data() {
    const json_string = localStorage.getItem("editor_data")

    if (!json_string) {
        return [{
            id: 1,
            title: '',
            columns: [{
                    id: 1,
                    title: "Новое",
                    items: []
                },
                {
                    id: 2,
                    title: "В работе",
                    items: []
                },
                {
                    id: 3,
                    title: "Сделано",
                    items: []
                }],
        },
            {
                title: "author"
                value:
            }];

    }

    return JSON.parse(json_string)
}


function save_data(data) {
    localStorage.setItem("boards_data", JSON.stringify(data))
}