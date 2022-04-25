function init() {
    // console.log("inicio")
    getEmpoderamentos()
    
}
var dados = null

function getEmpoderamentos() {
    var requestOptions = {
        method: 'GET',
        headers: {
            "Accept": "application/json",
            'Access-Control-Allow-Origin': '*'
        }
      };
     
      let myRequest = new Request("https://localhost:44362/api/EmpoderamentoFemininos", requestOptions)

      fetch(myRequest).then((response) =>response.json())
      .then((data) => {
        dados = data
        careegarCarrossel()
      })
      .catch(error => {
          return error;
      });
    
}

function editar(id) {
    var selecionado = dados.filter( x =>{
        return x.id == id
    })
    console.log(selecionado)
    $("#idhiden").val(id)
    $("#name").val(selecionado[0].nome)
    $("#site").val(selecionado[0].site)
    $("#url").val(selecionado[0].url)
    $("#descricao").val(selecionado[0].descricao)
   // $("#collapseExample").Headers()

}

function deletar(id) {
    console.log(id)
}
function salvar() {
    var myHeaders = new Headers();
myHeaders.append("content-type", "application/json");

var raw = JSON.stringify({
  "id": $("#idhiden").val(),
  "nome":  $("#name").val(),
  "descricao":  $("#site").val(),
  "site":  $("#url").val(),
  "url": $("#descricao").val()
  
});

var requestOptions = {
  method: 'PUT',
  headers: myHeaders,
  body: raw,
  redirect: 'follow'
};

fetch("https://localhost:44362/api/EmpoderamentoFemininos/7", requestOptions)
  .then(response => response.text())
  .then(result => console.log(result))
  .catch(error => console.log('error', error));
}


function careegarCarrossel(){
    $("#carrossel").empty()
    var buuton = ' <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>'
    var htm = ''
    for (let i = 0; i < dados.length; i++) {
        buuton += '<button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="'+(i+1)+'" aria-label="Slide '+(i+1)+'"></button>'
        if(i == 0)
        htm += '<div class="carousel-item active"><img src="../assets/background.png" class="d-block w-100" alt="..."><div class="carousel-caption d-none d-md-block"><h1>Nome: '+dados[i].nome+'</h1><h5>Clique no link para o Youtube:<a href="'+dados[i].url+'" ><i class="bi bi-youtube mg-l color tam"></i></a> </h5><p>'+dados[i].descricao+' <a href="'+dados[i].site+'" > <h2 class="SiteColor">Site Oficial</h2></a>. </p></div></div>'
        else
        htm += '<div class="carousel-item "><img src="../assets/background.png" class="d-block w-100" alt="..."><div class="carousel-caption d-none d-md-block"><h1>Nome: '+dados[i].nome+'</h1><h5>Clique no link para o Youtube:<a href="'+dados[i].url+'" ><i class="bi bi-youtube mg-l color tam"></i></a> </h5><p>'+dados[i].descricao+' <a href="'+dados[i].site+'" > <h2 class="SiteColor">Site Oficial</h2></a></p></div></div>'
    
    }
    $(".carousel-indicators").html(buuton)
    $("#carrossel").html(htm)
}


function careegarTable(){
    $("#bodytable").empty()
    for (let i = 0; i < dados.length; i++) {
        $("#bodytable").append(
            '<tr><th scope="row">'+dados[i].id+'</th><td>'+dados[i].nome+'</td><td><button type="button" onclick="editar('+dados[i].id+')" class="btn btn-sm btn-outline-primary"><i class="bi bi-pen-fill"></i></button><button type="button" onclick="deletar('+dados[i].id+')" class="btn btn-sm btn-outline-primary  mg-l" ><i class="bi bi-trash-fill"></i></button></td></tr>'
        )
    }
}
