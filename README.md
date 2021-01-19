# 📚 Sistema de biblioteca 
## Uma aplicação de código aberto para bibliotecas

### ✨Funcionalidades
- [x] 👥 Cadastro de usuário
  - [x] Cadastro de responsável para menores de idade
  - [x] Cadastro de endereço
- [x] 📖 Cadastro de livro
  - [x] Gerenciamento de gêneros
  - [x] Gerenciamento de autores
  - [x] Pesquisa de livros com filtros
- [x] 📅 Empréstimo de livros
  - [x] Devolução de livros
  - [x] Renovação dos empréstimos
  - [x] Notificação quando um livro deveria ter sido entregue
  - [ ] Avalição do livro durante a devolução
- [x] 🛠 Painel de configurações para administrador
  - [x] Mudança de nome da biblioteca e senha
  - [x] Seleção de imagem da logo
  - [x] Backup da base de dados
  
### 🔑Configurar backup
Para o backup funcionar você deve habilitar a sua conta do Google Drive por [este link](https://developers.google.com/drive/api/v3/quickstart/dotnet).

1. Habilite a API do Drive
2. Dê um nome ao projeto
3. Escolha _Desktop App_
4. Baixe o arquivo de configuração
5. Coloque o _credentials.json_ na mesma pasta que o executável _SistemaInterface.exe_
6. Inicie o programa e entre nas configurações com a senha padrão _12345789_
7. Clique no botão _Backup...
8. Clique em _Configurações do Drive_ e selecione a pasta que deseja salvar os backups