## 1. Configuração
Abra o arquivo Web.config e procure pela tag **connectionStrings** na linha 11.
  
Altere o atributo **connectionString** do contexto principal da aplicação conforme abaixo.
  
Data Source=localhost;Initial Catalog=**DATABASE**;Persist Security Info=True;User ID=**USUARIO_SQL**;Password=**SENHA_SQL**
  
## 2. Base SQL
  
O arquivo **employee_DB.sq**l contém uma base para importação dos dados SQL, como também a tabela principal da aplicação.


## 3. Telas
Listagem de Funcionários
![Listagem de Funcionários](https://raw.githubusercontent.com/ronniegchagas/employeeRegister/master/pic_01_listar.png)

Cadastro de Funcionários
![Cadastro de Funcionários](https://raw.githubusercontent.com/ronniegchagas/employeeRegister/master/pic_02_cadastrar.png?raw=true)

Alteração de Funcionários
![Alteração de Funcionários](https://raw.githubusercontent.com/ronniegchagas/employeeRegister/master/pic_03_editar.png?raw=true)
