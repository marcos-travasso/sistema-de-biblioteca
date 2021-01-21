# Changelog
Todas as mudanças notáveis serão documentadas nesse arquivo.

O formato baseado é o [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
e o projeto segue o [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.3.0] - 2021-01-21
### Adicionado
- Intervalo para apagar backups antigos.
  - Intervalo para backup automático.
  - Tela para configurar os intervalos.
- Tela de pesquisa de livro na tela de fazer empréstimo.
- Perfil do usuário é aberta quando selecionado na lista de empréstimos.

## [1.2.0] - 2021-01-19
### Adicionado
- Sistema de backup no Google Drive.
  - Backup diário, periódico de 30 minutos e a qualquer momento.
  - Selecionar a pasta do Drive em que será salvo.
  - Abrir um backup do Drive.

## [1.1.1] - 2021-01-18
### Consertado
- Consertado bug que não cadastrava autores novos.

## [1.1.0] - 2021-01-18
### Adicionado
- Tela de pesquisa de livros com filtros.
- Notificação na tela inicial dos livros que estão em atraso.
- Painel de configurações de administrador.
  - Seleção da imagem na tela inicial.

### Modificado
- Agora as configurações são salvas no app.config.

### Consertado
- Consertado bug que cadastrava incorretamente livros.

## [1.0.0] - 2021-01-15
### Adicionado
- Telas de usuários.
  - Cadastro de usuários.
  - Listagem dos usuários.
  - Cadastro de responsável.
  - Tela de informações individuais.
  - Tela de edição de usuário.
- Telas de livros.
  - Cadastro de livros.
    - Cadastro de gêneros e autores.
	- Edição de gêneros e autores.
  - Listagem dos livros.
  - Tela de informações do livro.
  - Tela de edição do livro.
- Empréstimo de livros.
  - Função para emprestar, devolver e renovar livros.
- Senha para edição e exclusão de livros e usuários.