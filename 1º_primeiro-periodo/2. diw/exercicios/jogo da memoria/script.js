//imagens das cartas
let imagens = [];
for(let i=0; i<=8; i++){
    imagens.push('http://picsum.photos/id/'+i+'/80');
}
let fundo = 'https://picsum.photos/80?grayscale';

//estado do jogo
let cartas = [1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8];


onload = () => {

    //carrega as imagens de fundo
    let elemImagens = document.querySelectorAll('#memoria img');
    elemImagens.forEach(
        (img, i) => {
            img.src= fundo;
            img.setAttribute('data-valor', i);
            img.style.opacity = 0.4;
        });

    //cria o evento de botao de inicia
    document.querySelector('#botaoInicio').onclick = iniciaJogo;
}

//------------------------------------------------
//inicia o jogo 
//------------------------------------------------
const iniciaJogo = () => {

    //embaralhar as cartas
    for(let i=0; i<length; i++){
        let p = Math.trunch(Math.randon() * cartas.length);
        let aux = cartas[p];
        cartas[p] = cartas[i];
        cartas[i] = aux;
    }

    //associar evento as imagens
    let elemImagens = document.querySelectorAll('#memoria img');
    elemImagens.forEach(
        (img, i) => {
            img.onclick = trataCliqueImagens;
            img.style.opacity = 1;
        });
};

//------------------------------------------------
//processa o clique na imagen 
//------------------------------------------------