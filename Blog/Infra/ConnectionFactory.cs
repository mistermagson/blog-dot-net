using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Infra
{
    public class ConnectionFactory
    {
        public static SqlConnection CriaConexaoAberta()
        {
            // Criar o arquivo de configuração
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            // Acessando o arquivo de configuração
            IConfiguration configuration = builder.Build();

            // Obtendo a string de conexão carregada no arquivo
            string stringConexao = configuration.GetConnectionString("Blog");

            // Abrindo a conexão
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }
    }
}
