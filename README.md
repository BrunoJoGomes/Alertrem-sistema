<h1 align="center"> :train2: Projeto Integrador - AlerTrem :train2:</h1>

Este projeto é uma plataforma que oferece informações atualizadas sobre a linha 9 esmeralda, que é operada pela empresa Via Mobilidade na cidade de São Paulo. O objetivo é facilitar a vida dos usuários da linha, que podem consultar dados sobre as estações, fazer comentários, reclamações e reports, e ficar por dentro das últimas notícias sobre a linha.

Este é o resultado do projeto integrador realizado pelos alunos do curso técnico em informática do SENAC da turma TI106. 
Os integrantes do grupo são:

- [Bruno](https://github.com/BrunoJoGomes)
- [Leonardo](https://github.com/NNiine)
- [João](https://github.com/jooaooz)
- [Gustavo](https://github.com/auizes)
- [Gabriel](https://github.com/Chefin004)
- [Nathan](https://github.com/NathanSnt)


# Índice

- [Sobre o projeto](#sobre-o-projeto)
- [Telas](#telas)
- [Como executar](#como-executar)


# Sobre o projeto

O projeto consiste em duas partes: um site e um sistema de administração. O site é uma plataforma que fornece informações atualizadas sobre a linha 9 esmeralda, operada pela Via Mobilidade em São Paulo. O sistema de administração é uma ferramenta para gerenciar o conteúdo e os dados do site.

Código-fonte do site: [NathanSnt/PI](https://github.com/NathanSnt/PI).

Código-fonte do sistema de administração: [BrunoJoGomes/Alertrem-sistema](https://github.com/BrunoJoGomes/Alertrem-sistema).

No site, os usuários podem:

- Ver o nome e a localização das estações da linha 9 esmeralda
- Conhecer as características de cada estação, como a acessibilidade e os serviços oferecidos
- Fazer reclamações sobre problemas ou sugestões relacionados à linha ou às estações
- Fazer reports sobre o status das estações, dos carros ou da linha em geral
- Consultar informações sobre as estações, como o horário de funcionamento e as conexões com outras linhas
- Visualizar os reports dos outros usuários
- Ficar sabendo sobre as últimas notícias sobre a linha 9 esmeralda, como obras, interrupções ou eventos

No sistema de administração, é possível:

- Ler e apagar reclamações feita pelo usuário.
- Visualizar as informações do usuário.
- Visualizar, editar ou cadastrar informação de uma estação.
- Visualizar, editar ou cadastrar características de uma estação.


# Telas

- [ ] Adicionar prints das telas
- [ ] Adicionar explicação das telas

# Como executar

- **Clone o repositório do projeto**
	
	Vá até o local onde deseja salvar o projeto, abra o cmd e execute:
	```
	git clone https://github.com/BrunoJoGomes/Alertrem-sistema
	```

- **Suba o banco de dados**

	Neste [repositório](https://github.com/NathanSnt/PI) tem um arquivo chamado `db_alertrem.sql` que, contém o script necessário para a criação do banco.
	Execute ele em um SGBD de sua preferência.

- **Crie um usuário no banco de dados**

	Acesse o banco e execute o seguinte comando:
	```
	CREATE USER 'alertrem'@'%' IDENTIFIED BY 'alertrem';
	GRANT ALL ON db_alertrem.* TO 'alertrem'@'%';
	FLUSH PRIVILEGES;
	```

- **Configure o acesso ao banco**
	
	- Vá até onde você salvou o projeto, acesse a pasta `Alertrem-sistema/alertrem/sistemaAlertrem`. 
	- Dentro dela tem um arquivo chamado `Conexao.cs`. Abra ele em algum editor de texto.
	- Localize a declaração de uma variável chamada `connString`.
	- Dentro da string, altere o IP do servidor de banco de dados e a porta para os valores que os servidor de banco de dados foi configurado.
	- Caso tenha criado um usuário diferente no banco, altere também o uid e pwd para o usuário e senha que você criou.

- **Execute**

	Para executar, abra o projeto com o [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) e, clique em executar ou, pressione F5.
