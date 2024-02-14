//HOME
fetch('https://diwserver.vps.webdock.cloud/products/category/Accessories - Watches?page=38')
    .then(res => res.json())
    .then(data => {
        let str = ''
        for (let i = 0; i < 10; i++) {
            let produtoLoja = data.products[i]
                str += `<div class="col-lg-4">
                        <div class="card" id="card">
                            <img src="${produtoLoja.image}" class="card" id="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title">${produtoLoja.title}</h5>
                            <p>Preço: $${produtoLoja.price},00</p>
                            <p>Avaliaçao: ${produtoLoja.rating.rate}</p>
                            <a href="/html/description.html?${produtoLoja.id}" class="btn" id="botao">Ver mais detalhes</a>
                        </div>
                        </div>
                        </div>`
            }
            document.getElementById('tela').innerHTML = str
})
//FILTRO
function filtroProduto() {
    const filtro = document.getElementById('filtro');
    const query = filtro.value;
    console.log(query)

    fetch(`https://diwserver.vps.webdock.cloud/products/category/Accessories - Watches`)
        .then(response => {
            console.log(response);
            return response.json();
        })
        .then(data => {
            let string = '';

            for (let i = 0; i < data.products.length; i++) {
                let produtoLoja = data.products[i];
                if(produtoLoja.brandName == query){
                string += `<div class="col-lg-4">
                <div class="card" id="card">
                    <img src="${produtoLoja.image}" class="card" id="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">${produtoLoja.title}</h5>
                    <p>Preço: $${produtoLoja.price},00</p>
                    <p>Avaliaçao: ${produtoLoja.rating.rate}</p>
                    <a href="/html/description.html?${produtoLoja.id}" class="btn" id="botao">Ver mais detalhes</a>
                </div>
                </div>
                </div>`;
                }
            }

            const resultsContainer = document.getElementById('tela');
            resultsContainer.innerHTML = string;
        })
        .catch(error => {
            console.error('Ocorreu um erro:', error);
        });
}
//BUSCA
function searchProducts() {
    const searchInput = document.querySelector('#caixapesquisa');
    const query = searchInput.value;

    fetch(`https://diwserver.vps.webdock.cloud/products/search?query=${query}`)
        .then(response => {
            console.log(response);
            return response.json();
        })
        .then(data => {
            let string = '';

            for (let i = 0; i < data.length; i++) {
                let produtoLoja = data[i];
                if(produtoLoja.category == 'Accessories - Watches'){
                string += `<div class="col-lg-4">
                <div class="card" id="card">
                    <img src="${produtoLoja.image}" class="card" id="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">${produtoLoja.title}</h5>
                    <p>Preço: $${produtoLoja.price},00</p>
                    <p>Avaliaçao: ${produtoLoja.rating.rate}</p>
                    <a href="/html/description.html?${produtoLoja.id}" class="btn" id="botao">Ver mais detalhes</a>
                </div>
                </div>
                </div>`;
                }
            }

            const resultsContainer = document.getElementById('tela');
            resultsContainer.innerHTML = string;
        })
        .catch(error => {
            console.error('Ocorreu um erro:', error);
        });
}
//DESCRIÇAO
let id = window.location.href;
id = id.split('?');
id = id[1];

fetch(`https://diwserver.vps.webdock.cloud/products/${id}`)
    .then(res => res.json())
    .then(descriçao => {
        let str = 
        `<div class="col-md-12 col-lg-3">
            <img src="${descriçao.image}" id="img-descriçao" alt="">
        </div>
        <div class="col-md-12 col-lg-4">
            <h3>${descriçao.title}</h3>
            <p>Preço: $${descriçao.price},00</p>
            <p>Ano de lançamento: ${descriçao.year}</p>
            <p>Marca: ${descriçao.brandName}</p>
            <p>Avaliaçao: ${descriçao.rating.rate}</p>
            <p>Uso: ${descriçao.usage}</p>
        </div>
        <div class="col-md-12 col-lg-5">
            <h3>Description</h3>
            <p>${descriçao.description}</p>
        </div>
        `
        document.getElementById('descricao').innerHTML = str
    })