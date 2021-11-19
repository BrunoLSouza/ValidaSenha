# Valida Senha

Aplicação desenvolvida para exemplificar a construção de uma API. Nesse exemplo é exposto um serviço de validação de senha que segue a seguinte regra:

- Nove ou mais caracteres
- Ao menos 1 dígito
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 caractere especial
  - Considere como especial os seguintes caracteres: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto

## Descrição

Aplicação desenvolvida em .Net Core 3.1 utilizando o Visual Studio 2019, fazendo uso de outras biblioteca como:

- Swagger
- XUnit
- Moq
- Bogus

## Instruções

- 1 Após obter a aplicação, abra a mesma no Visual Studio
- 2 Certifique-se de ter o Framework .Net Core 3.1 instalado
- 3 Defina o projeto bpls.validaSenha.API como Startup Project
- 4 Para executar o programa, pressione Ctrl + F5, selecione depurar > Iniciar sem Depurar no menu superior ou selecione o botão verde Iniciar 

Se tudo ocorrer corretamente o navegador padrão será aberto e a tela do swagger carregada

## Motivadores

Foi implementado uma classe que contem 7 méodos de validação, sendo um para cada cenário. A opção por fazer dessa forma ocorreu para que se possa aproveitar as validações em futuras necessidades, sendo apenas uma delas ou combinadas de N formas diferentes.
Dessa modo foi exposto uma unica action (IsValid) que implementa todos os 7 métodos de validação.

## Endpoint

Ao executar a aplicação, a mesma irá  expor o seguinte endpoint [GET] -> https<span></span>://localhost:44330/Senha/IsValid/{SENHA}
