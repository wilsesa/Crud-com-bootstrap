using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class Conexao
    {
        #region Atributos
        //Atributos:
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;
        #endregion Atributos
        #region Abrir Conexão
        //Método para abrir Conexao
        protected void AbrirConexao()
        {
            try
            {
                //Connection String
                Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Crud_Bootstrap;Integrated Security=True");  
                Con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion Abrir Conexão
        #region Fechar Conexão
        //Método para Fechar Conexao
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion Fechar Conexão
    }
}
