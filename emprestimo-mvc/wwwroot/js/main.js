// pegamos o valor no localStorage
const nightModeStorage = localStorage.getItem('gmtNightMode');
const nightMode = document.querySelector('#night-mode');
// pega o valor do meta tag
const metaThemeColor = document.querySelector("meta[name=theme-color]");

// caso tenha o valor no localStorage
if (nightModeStorage) {
    // ativa o night mode
    document.documentElement.classList.add('night-mode');
    // pinta o theme color na meta tag
    metaThemeColor.setAttribute("content", '#2b2b2b');
    // já deixa o input marcado como ativo
    nightMode.checked = true;
}

// ao clicar mudaremos as cores
nightMode.addEventListener('click', () => {
    // adiciona a classe `night-mode` ao html
    document.documentElement.classList.toggle('night-mode');

    // se tiver a classe night-mode
    if (document.documentElement.classList.contains('night-mode')) {
        // salva o tema no localStorage
        localStorage.setItem('gmtNightMode', true);
        // pinta o theme color na meta tag
        metaThemeColor.setAttribute("content", '#2b2b2b');
        return;
    }
    // senão remove
    localStorage.removeItem('gmtNightMode');
    // senão bota a cor original
    metaThemeColor.setAttribute("content", '#005f97');
});

//Salvar os dados dos inputs novo emprestiomo no localstorage

var inputNovoEmprestimo = document.getElementById('nomeNovoEmprestimo');

var btnNovoEmprestimo = document.getElementById("btn-novoEmprestimo");
if (btnNovoEmprestimo) {
    btnNovoEmprestimo.addEventListener("click", function () {
        window.localStorage.setItem("nomeCliente", inputNovoEmprestimo.value);

        window.location.href = "Home/ValorNovoEmprestimo";
    });
}


var inputValorEmprestimo = document.getElementById('valorEmprestimo');

var btnValorEmprestimo = document.getElementById("btn-valorEmprestimo");
if (btnValorEmprestimo) {
    btnValorEmprestimo.addEventListener("click", function () {
        window.localStorage.setItem("valorEmprestimo", inputValorEmprestimo.value);

        window.location.href = "PrazoNovoEmprestimo";
    });
}

var inputPrazoEmprestimo = document.getElementById('prazoEmprestimo');

var btnPrazoEmprestimo = document.getElementById("btn-prazoEmprestimo");
if (btnPrazoEmprestimo) {
    btnPrazoEmprestimo.addEventListener("click", function () {
        window.localStorage.setItem("prazoEmprestimo", inputPrazoEmprestimo.value);

        window.location.href = "EntradaNovoEmprestimo";
    });
}

var inputEntradaEmprestimo = document.getElementById('entradaEmprestimo');


var btnEntradaEmprestimo = document.getElementById("btn-entradaEmprestimo");
if (btnEntradaEmprestimo) {
    btnEntradaEmprestimo.addEventListener("click", function () {
        window.localStorage.setItem("entradaEmprestimo", inputEntradaEmprestimo.value);

        window.location.href = "EncerramentoNovoEmprestimo";
    });
}

var inputNomeEncerramento = document.getElementById('nomeEncerramento');

if (inputNomeEncerramento) {
    inputNomeEncerramento.value = window.localStorage["nomeCliente"];
}

var inputValorEncerramento = document.getElementById('valorEncerramento');

if (inputValorEncerramento) {
    inputValorEncerramento.value = window.localStorage["valorEmprestimo"];
}

var inputPrazoEncerramento = document.getElementById('prazoEncerramento');

if (inputPrazoEncerramento) {
    inputPrazoEncerramento.value = window.localStorage["prazoEmprestimo"];
}

var inputEntradaEncerramento = document.getElementById('entradaEncerramento');

if (inputEntradaEncerramento) {
    inputEntradaEncerramento.value = window.localStorage["entradaEmprestimo"];
}