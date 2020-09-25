# E-Bend
Formulário web de cadastro de dominadores profissionais (inspirado em Avatar- A lenda de Korra) com arquitetura MVC, Asp.Net e Bootstrap

INSTRUÇÕES:

É necessário um Gerenciador de Banco de dados para que o projeto seja testado corretamente. SQL Express é altamente recomendado.
No arquivo Web.config, altere a validação dos dados para as suas personalizadas: (User ID e Password)

<connectionStrings>
    <add name="Contexto"
         connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=Aluno;
                          Integrated Security=True;User ID=exemplo;Password=exemplo;
                          Encrypt=False;TrustServerCertificate=False"
         providerName="System.Data.SqlClient"/>
  </connectionStrings>
