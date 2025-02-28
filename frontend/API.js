document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('login-form'); // Substitua 'loginForm' pelo ID do seu formulário.

    form.addEventListener('submit', (event) => {
        event.preventDefault(); // Impede o envio padrão do formulário.

        // Obtém os valores dos campos.
        const email = document.getElementById('Email').value;
        const senha = document.getElementById('Senha').value;

        // Cria o objeto com os dados para enviar ao servidor.
        const dadosLogin = {
            Email: email,
            Senha: senha
        };

        console.log('Dados enviados:', dadosLogin);

        // Faz a requisição POST para o servidor.
        fetch('https://seu.local/api/Usuario', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(dadosLogin)
        })
            .then(response => response.json())
            .then(data => {
                console.log('Resposta do servidor:', data);
            })
            .catch(error => {
                console.error('Erro:', error);
            });
    });
});