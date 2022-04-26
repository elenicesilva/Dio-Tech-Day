function init() {
    getEmpoderamentos()
    tableClose = true
}
var dados = null
var tableClose = null
function getEmpoderamentos() {
    var requestOptions = {
        method: 'GET',
        headers: {
            "Accept": "application/json",
            'Access-Control-Allow-Origin': '*'
        }
    };

    let myRequest = new Request("https://localhost:44362/api/EmpoderamentoFemininos", requestOptions)

    fetch(myRequest).then((response) => response.json())
        .then((data) => {
            dados = data
            careegarCarrossel()
        })
        .catch(error => {
            return error;
        });

}

function editar(id) {
    var selecionado = dados.filter(x => {
        return x.id == id
    })
    console.log(selecionado)
    $("#idhiden").val(id)
    $("#name").val(selecionado[0].nome)
    $("#site").val(selecionado[0].site)
    $("#url").val(selecionado[0].url)
    $("#descricao").val(selecionado[0].descricao)
    colapse()
    abrir(true)
}

function deletar(id) {
    var myHeaders = new Headers();
    myHeaders.append("content-type", "application/json");
    var url = "https://localhost:44362/api/EmpoderamentoFemininos/" + id

    var requestOptions = {
        method: 'DELETE',
        headers: myHeaders,
        redirect: 'follow'
    };

    fetch(url, requestOptions)
        .then(response => response.text())
        .then(result =>{ 
            dados = dados.filter(function(item) {
                return item.id !== id
            })
            careegarTable()
        })
        .catch(error => console.log('error', error));
}
function salvar(id) {
    var myHeaders = new Headers();
    myHeaders.append("content-type", "application/json");
    var cod = parseInt(id)
    var url = "https://localhost:44362/api/EmpoderamentoFemininos";
    var method = 'POST'
    if (cod > 0) {
        url = url + "/" + cod
        method = 'PUT'
    }

    var raw = JSON.stringify({
        "id": cod,
        "nome": $("#name").val(),
        "descricao": $("#descricao").val(),
        "site": $("#site").val(),
        "url": $("#url").val()

    });

    var requestOptions = {
        method: method,
        headers: myHeaders,
        body: raw,
        redirect: 'follow'
    };

    fetch(url, requestOptions)
        .then(response => response.text())
        .then(result => {
            if (!cod)
                dados.push(result)
            getEmpoderamentos()
            careegarTable()
        })
        .catch(error => console.log('error', error));
}


function careegarCarrossel() {
    $("#carrossel").empty()
    var buuton = ' <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 0"></button>'
    var htm = ''
    for (let i = 0; i < dados.length; i++) {
        if(i < (dados.length - 1))
            buuton += '<button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="' + (i + 1) + '" aria-label="Slide ' + (i + 1) + '"></button>'
        if (i == 0)
            htm += '<div class="carousel-item active"><img src="../assets/background.png" class="d-block w-100" alt="..."><div class="carousel-caption d-none d-md-block"><h1>Nome: ' + dados[i].nome + '</h1><h5>Clique no link para o Youtube:<a href="' + dados[i].url + '" ><i class="bi bi-youtube mg-l color tam"></i></a> </h5><p>' + dados[i].descricao + ' <a href="' + dados[i].site + '" > <h2 class="SiteColor">Site Oficial</h2></a>. </p></div></div>'
        else
            htm += '<div class="carousel-item "><img src="../assets/background.png" class="d-block w-100" alt="..."><div class="carousel-caption d-none d-md-block"><h1>Nome: ' + dados[i].nome + '</h1><h5>Clique no link para o Youtube:<a href="' + dados[i].url + '" ><i class="bi bi-youtube mg-l color tam"></i></a> </h5><p>' + dados[i].descricao + ' <a href="' + dados[i].site + '" > <h2 class="SiteColor">Site Oficial</h2></a></p></div></div>'

    }
    $(".carousel-indicators").html(buuton)
    $("#carrossel").html(htm)
}


function careegarTable() {
    $("#bodytable").empty()
    for (let i = 0; i < dados.length; i++) {
        $("#bodytable").append(
            '<tr><th scope="row">' + dados[i].id + '</th><td>' + dados[i].nome + '</td><td><button type="button" onclick="editar(' + dados[i].id + ')" class="btn btn-sm btn-outline-primary"><i class="bi bi-pen-fill"></i></button><button type="button" onclick="deletar(' + dados[i].id + ')" class="btn btn-sm btn-outline-primary  mg-l" ><i class="bi bi-trash-fill"></i></button></td></tr>'
        )
    }
    limpar()
}

function colapse() {
    var collapseElementList = [].slice.call(document.querySelectorAll('.collapse'))
    var collapseList = collapseElementList.map(function (collapseEl) {
        return new bootstrap.Collapse(collapseEl)
    })
}

function limpar() {
    $("#idhiden").val("0")
    $(".limpar").val("")
}

function form() {
    if(!tableClose)
        colapse()
}

function abrir(open) {
    tableClose = open;
}

function reset() {
    limpar()
    form()
}