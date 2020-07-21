using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        //Regras de negócio da nossa aplicação - consultas! INSERT, UPDATE, DELETE, SELECT, OBTERPORID
        #region Método para gravar dados...INSERT
        public void Gravar(Pessoa p)
        {
            try
            {
                //Abrimos a conexão
                AbrirConexao();
                Cmd = new SqlCommand("Insert into Pessoa (Nome,Endereco,Email) Values (@v1,@v2,@v3)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.ExecuteNonQuery();  //Executa o método Insert
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar cliente!!!" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion
        #region Método para atualizar dados... UPDATE
        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("Update Pessoa Set Nome=@v1, Endereco=@v2, Email=@v3 Where Codigo=@v4", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualziar o cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion
        #region Método para excluir dados....DELETE
        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("Delete From Pessoa Where Codigo=@v4", Con);
                Cmd.Parameters.AddWithValue("@v4", Codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o cliente:..." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion
        #region Método para obter uma Pessoa pelo Código (Chave Primária)
        public Pessoa PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("Select * From Pessoa Where Codigo=@v4", Con);
                Cmd.Parameters.AddWithValue("@v4", Codigo);
                Dr = Cmd.ExecuteReader();       //Ejecuta a leitura das informações no BD.

                Pessoa p = null;    //Criando um objeto ou ponteiro (criando espaço na memoria)

                if (Dr.Read())
                {
                    p = new Pessoa();
                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                }
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesqjuisar o Cliente:..." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion
        #region Método para listar os clientes cadastrados...
        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("Select * From Pessoa", Con);
                Dr = Cmd.ExecuteReader();   //lee os registros obtenidos

                List<Pessoa> lista = new List<Pessoa>();    //Lista vazia

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os clientes..." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        #endregion
    }
}
