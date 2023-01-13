using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Crud
{
    public partial class Form1 : Form
    {
      private  MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=db_agenda";

        private int ?id_contato_selecionado = null;
        public Form1()
        {
            InitializeComponent();



            LSTcontato.View = View.Details;
            LSTcontato.LabelEdit = true;
            LSTcontato.AllowColumnReorder= true;
            LSTcontato.FullRowSelect= true;
            LSTcontato.GridLines=true;

            LSTcontato.Columns.Add("ID", 30, HorizontalAlignment.Left);
            LSTcontato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            LSTcontato.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            LSTcontato.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            carregar_contatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               Conexao = new MySqlConnection(data_source);

                Conexao.Open();


                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                if (id_contato_selecionado == null)
                {
                    //insert
                    cmd.CommandText = "INSERT INTO contato (nome, email, telefone) VALUES (@nome, @email, @telefone) ";



                    cmd.Parameters.AddWithValue("@nome", TXTnome.Text);
                    cmd.Parameters.AddWithValue("@email", TXTemail.Text);
                    cmd.Parameters.AddWithValue("@telefone", TXTtelefone.Text);

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato Inserido com Sucesso!",
                                "Sucesso!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                }
                else
                {
                    //atualização dos contatos
                    cmd.CommandText = "UPDATE contato SET nome=@nome, email=@email, telefone=@telefone " +
                                        "WHERE id=@id ";



                    cmd.Parameters.AddWithValue("@nome", TXTnome.Text);
                    cmd.Parameters.AddWithValue("@email", TXTemail.Text);
                    cmd.Parameters.AddWithValue("@telefone", TXTtelefone.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);


                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato Atualizado com Sucesso!",
                                "Sucesso!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                }

                zerar_formulario();

                carregar_contatos();

          
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu " + ex.Message,
                             "Erro",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();


                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM contato WHERE nome LIKE @q OR email LIKE @q";



                cmd.Parameters.AddWithValue("@q", "%" + TXTbuscar.Text + "%");
              
                cmd.Prepare();


                MySqlDataReader reader = cmd.ExecuteReader();

                LSTcontato.Items.Clear();

                while(reader.Read())
                {
                    String[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),

                    };
                  
                    
                    LSTcontato.Items.Add(new ListViewItem(row));
                }


            } 
                 catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu " + ex.Message,
                             "Erro",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.Close();
            }

          
        }

        private void carregar_contatos()
        {

            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();


                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM contato ORDER BY id DESC";



              

                cmd.Prepare();

                            
                MySqlDataReader reader = cmd.ExecuteReader();

                LSTcontato.Items.Clear();

                while (reader.Read())
                {
                    String[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),

                    };
                  

                    LSTcontato.Items.Add(new ListViewItem(row));
                }


            } 
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu " + ex.Message,
                             "Erro",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.Close();
            }


        }

        private void LSTcontato_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = LSTcontato.SelectedItems;
            
            foreach(ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                TXTnome.Text = item.SubItems[1].Text;
                TXTemail.Text = item.SubItems[2].Text;
                TXTtelefone.Text = item.SubItems[3].Text;
                
                button3.Visible = true;


            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zerar_formulario();

        }
        
        private void zerar_formulario()
        {
            id_contato_selecionado = null;

            TXTnome.Text = string.Empty;
            TXTemail.Text = "";
            TXTtelefone.Text = "";
            TXTnome.Focus();
            
            button3.Visible=false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            excluir_contato();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            excluir_contato();
        }

        private void excluir_contato()
        {
            try
            {
                DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Ops, tem certeza?", MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (conf == DialogResult.Yes)
                {
                    Conexao = new MySqlConnection(data_source);

                    Conexao.Open();


                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = "DELETE FROM contato WHERE id=@id ";

                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Contato Excluído com Sucesso!",
                              "Sucesso!",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                    carregar_contatos();
                    
                    zerar_formulario();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu " + ex.Message,
                             "Erro",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
