
$.validator.setDefaults({

    //QUANDO FOR ACIONADO  < QUANDO O ELEMENTO FOR INVALIDO
    highlight: function (element) {

        $(element)
            .closest('.form-group') //DEFININDO QUE VAI PEGAR TODOS OS ELEMENTOS DO FORM GROUP
            .find('input,label,select,textarea,span') //PEGAR QUAIS ELEMENTOS DETRO DO FORMGROUP QUE VAI MUDAR
            .addClass('is-invalid')//ADICIONANDO A CLASSE DENTRO DESSES ELEMENTOS DO FIND
    },

    //QUANDO FOR ACIONADO < QUANDO O ELEMENTO É VALIDO
    unhighlight: function (element) {
        $(element)
            .closest('.form-group')
            .find('input,label,select,textarea,span')
            .removeClass('is-invalid')
            .addClass('is-valid')
    },

})