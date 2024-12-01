using System;
using System.Data;
using System.Data.SqlClient;

public class ClasseConexao
{
    private SqlConnection conexao;

    public SqlConnection conectar()
    {
        try
        {
            string strConexao = @"Data Source=EMANOEL;Initial Catalog=BD_CARTAO_ZELAR;Integrated Security=True;Encrypt=False";
            conexao = new SqlConnection(strConexao);
            conexao.Open();
            return conexao;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao conectar: " + ex.Message);
            desconectar();
            return null;
        }
    }

    public void desconectar()
    {
        if (conexao != null && conexao.State == ConnectionState.Open)
        {
            conexao.Close();
            conexao.Dispose();
            conexao = null;
        }
    }

    public DataTable executarSQL(string comando_sql)
    {
        try
        {
            if (conectar() == null)
            {
                throw new Exception("Falha na conexão.");
            }

            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao))
            {
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds.Tables[0];
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao executar SQL: " + ex.Message);
            return null;
        }
        finally
        {
            desconectar();
        }
    }

    public bool manutencaoDB(string comando_sql)
    {
        try
        {
            if (conectar() == null)
            {
                throw new Exception("Falha na conexão.");
            }

            using (SqlCommand comando = new SqlCommand(comando_sql, conexao))
            {
                comando.ExecuteNonQuery(); // Alterado para ExecuteNonQuery
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao executar manutenção DB: " + ex.Message);
            return false;
        }
        finally
        {
            desconectar();
        }
    }

    public int manutencaoDB_Parametros(SqlCommand comando)
    {
        try
        {
            if (conectar() == null)
            {
                throw new Exception("Falha na conexão.");
            }

            comando.Connection = conexao;
            return comando.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao executar manutenção com parâmetros: " + ex.Message);
            throw; // Re-lançar a exceção para que o formulário possa capturar a mensagem
        }
        finally
        {
            desconectar();
        }
    }
    /*
    public bool autenticarUsuario(string email, string senha, out int userId)
    {
        userId = 0;
        try
        {
            string sql = "SELECT idComercio FROM comercio WHERE emailResponsavel = @Email AND senhaResponsavel = @Senha";
            using (SqlCommand comando = new SqlCommand(sql, conectar()))
            {
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Senha", senha); // Use hash e salt na produção

                var result = comando.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao autenticar usuário: " + ex.Message);
        }
        return false;
    }
    */
}
