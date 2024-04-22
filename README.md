# Editor HTML

Um editor simples de HTML em C#.

## Funcionalidades

- **Novo Arquivo:** Crie um novo arquivo HTML.
- **Abrir:** Abra um arquivo existente.
- **Modo Editor:** Edite o conteúdo do arquivo.
- **Modo Visualização:** Visualize o arquivo com formatação.

## Como Usar

1. Baixe ou clone este repositório.
2. Abra o projeto em sua IDE preferida.
3. Compile e execute o programa.
4. Use as opções do menu para criar ou abrir arquivos HTML e editá-los.

## Requisitos

- .NET Core SDK
- Visual Studio ou Visual Studio Code (opcional)

## Estrutura do Projeto

O projeto está estruturado da seguinte forma:

- **EditorHtml:** Contém o código-fonte do editor HTML.
  - **Menu.cs:** Implementa o menu principal.
  - **Editor.cs:** Implementa o modo de edição.
  - **TableFile.cs:** Implementa a visualização de arquivos em forma de tabela.
  - **Viewer.cs:** Implementa o modo de visualização.

## Principais Classes

- **Menu:** Classe responsável por exibir o menu principal e lidar com as opções do usuário.
- **Editor:** Classe responsável pelo modo de edição, onde o usuário pode inserir e editar o conteúdo do arquivo HTML.
- **TableFile:** Classe responsável por exibir os arquivos em formato de tabela e permitir ao usuário selecionar um arquivo para visualização ou edição.
- **Viewer:** Classe responsável pelo modo de visualização, onde o usuário pode visualizar o conteúdo do arquivo HTML com formatação.

## Contribuindo

Sinta-se à vontade para contribuir com melhorias ou correções de bugs! Basta abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a MIT License - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
