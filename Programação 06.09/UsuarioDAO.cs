using Programação_06._09;
using Programação_06;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tauaneProj
{
    internal class UsuarioDAO
    {
        public List<Usuario> SelectUsuario()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Tabela2";

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();


                while (dr.Read())
                {

                    Usuario objeto = new Usuario(


                    (int)dr["ID"],

                    (string)dr["nome"],

                    (string)dr["Email"],

                    (string)dr["Senha"],

                    (string)dr["CPF"]


                    );

                    usuarios.Add(objeto);

                }
                dr.Close();

                return usuarios;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }

        }
        public List<Usuario> SelectUsuario1()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Tabela1";

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();


                while (dr.Read())
                {

                    Usuario objeto = new Usuario(

                    (int)dr["ID"],
                    (string)dr["Rua"],
                     (string)dr["Bairro"],
                     (string)dr["Numero_Casa"]
                    );

                    usuarios.Add(objeto);

                }
                dr.Close();

                return usuarios;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }

        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public void InsertUsuario(Usuario usuario)
        {
            string email = usuario.Email;
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Tabela2 VALUES 
            (@Nome, @Email, @Senha, @CPF)";

            sqlCommand.Parameters.AddWithValue("@Nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@Email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@CPF", usuario.CPF);
            sqlCommand.Parameters.AddWithValue("@Senha", usuario.senha);

            if (IsValidEmail(email) == true)
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Criado Com Sucesso Seu Cadastro",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email invalido",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

        }
        public void InsertUsuario1(Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Tabela1 VALUES 
            (@Rua, @Bairro, @Numero)";

            sqlCommand.Parameters.AddWithValue("@Rua", usuario.rua);
            sqlCommand.Parameters.AddWithValue("@Bairro", usuario.Bairro);
            sqlCommand.Parameters.AddWithValue("@Numero", usuario.Numero);

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Criado Com Sucesso Seu Cadastro",
            "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);


        }
        public void UpdateUsuario(Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Tabela2 SET 
            nome= @nome,
            Email= @email, 
            senha= @senha,
            CPF= @CPF
            WHERE ID=@id";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@CPF", usuario.CPF);
            sqlCommand.Parameters.AddWithValue("@senha", usuario.senha);
            sqlCommand.Parameters.AddWithValue("@id", usuario.Id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("EDITADA COM SUCESSO!",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }
        public void UpdateUsuario1(Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Tabela1 SET 
            Rua = @Rua,
            Bairro = @Bairro,
            Numero_Casa=@Numero
            WHERE ID = @ID";

            sqlCommand.Parameters.AddWithValue("@Rua", usuario.rua);
            sqlCommand.Parameters.AddWithValue("@Bairro", usuario.Bairro);
            sqlCommand.Parameters.AddWithValue("@Numero", usuario.Numero);
            sqlCommand.Parameters.AddWithValue("@ID", usuario.Id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("EDITADA COM SUCESSO!",
               "AVISO",
            MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }
        public void DeletUsuario(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Tabela2 WHERE ID = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Excluido com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        public void DeleteUsuario1(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Tabela1 WHERE ID = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Excluido com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        public void loginUsuario(Usuario usuario)
        {


            // Conexão com o banco de dados
            Connection connect = new Connection();
            SqlConnection connection = connect.ReturnConnection();

            // Consulta SQL para verificar se o usuário existe
            string query = "SELECT ID FROM Tabela2 WHERE Email=@Email AND Senha=@Senha";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Senha", usuario.senha);
            int userId = Convert.ToInt32(command.ExecuteScalar());

            if (userId > 0)
            {
                MessageBox.Show("Login feito com sucesso");
                Form4 form4 = new Form4(userId);
                form4.Show();
            }
            else
            {
                MessageBox.Show("Erro ao fazer login");
            }

            connect.CloseConnection();
        }


    }
}
