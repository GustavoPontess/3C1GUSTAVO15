# 📌 Projeto CRUD Windows Forms

Este projeto foi desenvolvido como parte de uma prova prática no curso técnico de informática no **Cotemig**. O objetivo é demonstrar habilidades em **C# e Windows Forms**, abordando a criação de interfaces gráficas, manipulação de eventos e desenvolvimento de um CRUD funcional.

## 🎯 Objetivo do Projeto

A prova exigia o desenvolvimento de um sistema com as seguintes características:

- Criação de uma interface gráfica utilizando **Windows Forms**.
- Implementação das operações CRUD (Create, Read, Update, Delete).
- Manipulação de eventos e interações no Visual Studio.

## ⚙️ Funcionalidades

- **Tela de Login**: Validação de credenciais para acesso ao sistema.
- **Gerenciamento de Loja**: Permite cadastrar, editar, listar e excluir itens, incluindo campos como ID, nome, categoria e preço.

## 🛠️ Configuração do Banco de Dados

O projeto utiliza **MySQL** como banco de dados. O script SQL para criação das tabelas está disponível no arquivo `Banco.sql`, localizado na raiz do projeto.

### 🔹 Passos para configuração:

1. Certifique-se de que o **MySQL** está instalado e rodando.
2. Abra o arquivo `Banco.sql` em um editor SQL ou no cliente MySQL.
3. Execute o script para criar o banco de dados e as tabelas.
4. Atualize a string de conexão no arquivo `AcessoBancoDados.cs`, informando as credenciais corretas (host, usuário, senha, etc.).

## 🛠️ Pacotes e Dependências

O projeto utiliza o pacote NuGet **MySqlConnector** para a comunicação com o banco de dados.

### 🔹 Como instalar o pacote:

1. No **Visual Studio**, abra o Gerenciador de Pacotes NuGet.
2. Busque por `MySqlConnector` e instale a versão mais recente compatível.
3. Verifique se a referência ao pacote está presente no arquivo `CRUDAltcel.csproj`.

## ⚙️ Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET Framework
- **Banco de Dados**: MySQL
- **IDE**: Visual Studio

## 📂 Estrutura do Projeto

```plaintext
3C1GUSTAVO15/
├── .gitignore          # Arquivo de configuração para ignorar arquivos no Git
├── 3C1GUSTAVO15.csproj # Arquivo do projeto do Visual Studio
├── 3C1GUSTAVO15.sln    # Arquivo da solução do Visual Studio
├── App.config          # Configuração do aplicativo
├── Banco.sql           # Script para criação do banco de dados
├── packages.config     # Configuração de pacotes NuGet
├── Program.cs          # Ponto de entrada da aplicação
├── Code/               # Contém arquivos organizados por camadas (BLL, DAL, DTO)
│   ├── BLL/
│   │   ├── LoginBLL.cs
│   │   └── LojaBLL.cs
│   ├── DAL/
│   │   └── AcessoBancoDados.cs
│   └── DTO/
│       ├── LoginDTO.cs
│       └── LojaDTO.cs
├── Ui/                 # Contém arquivos de interface do usuário
│   ├── Frm_Login.cs
│   ├── Frm_Login.Designer.cs
│   ├── Frm_Login.resx
│   ├── Frm_Loja.cs
│   ├── Frm_Loja.Designer.cs
│   └── Frm_Loja.resx
├── Properties/         # Configurações do projeto
│   ├── AssemblyInfo.cs
│   ├── Resources.Designer.cs
│   ├── Resources.resx
│   ├── Settings.Designer.cs
│   └── Settings.settings
├── Resources/          # Arquivos de recursos do projeto
│   └── chilli beans.png
```

## 📂 Organização em Camadas

O projeto segue uma arquitetura em camadas para facilitar a manutenção e organização do código.

- **DTO (Data Transfer Object)**:
  - Define objetos de transferência de dados, como `LoginDTO.cs` e `LojaDTO.cs`.

- **BLL (Business Logic Layer)**:
  - Contém a lógica de negócios e validação, com classes como `LoginBLL.cs` e `LojaBLL.cs`.

- **DAL (Data Access Layer)**:
  - Responsável pelo acesso ao banco de dados, incluindo consultas e atualizações (`AcessoBancoDados.cs`).

- **UI (User Interface)**:
  - Contém as telas e interações do usuário, como `Frm_Login.cs` e `Frm_Loja.cs`.

## 🚀 Como Executar o Sistema

### 🔹 Configuração do Ambiente

1. **Instale os pré-requisitos**:
   - Visual Studio com suporte para **.NET Framework**.
   - Servidor **MySQL** configurado.
   - Dependências NuGet corretamente instaladas.

### 🔹 Executando o Projeto

2. **Passos para execução**:
   - Abra o arquivo `CRUDAltcel.sln` no Visual Studio.
   - Compile o projeto (`Ctrl + Shift + B` ou "Build > Build Solution").
   - Execute o sistema (`F5` ou "Start Debugging").

## 📚 Licença

Este projeto está licenciado sob a licença **MIT**. Consulte o arquivo [`LICENSE`](LICENSE) para mais detalhes.