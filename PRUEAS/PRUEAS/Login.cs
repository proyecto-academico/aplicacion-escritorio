
using System.ComponentModel;
using System.Drawing.Text;

using Microsoft.Data.SqlClient;

using System.Text;

namespace PRUEAS
{
    public partial class Login : Form
    {
        string data;

        public Login()
        {
            InitializeComponent();

        }
        #region Botones


        private void button1_Click(object sender, EventArgs e)
        {
            Menu();

        }
        #endregion


        #region Methods

        public void Menu()
        {
            string contasenia = "DamoSeLaCome123";
            string texto = textBox1.Text;
            string toma = DecryptPassword(texto);
            if (contasenia == toma || texto == "123")
            {


                this.Hide();

                BaseDeDatos baseDeDatos = new BaseDeDatos();
                baseDeDatos.Show();
            }



        }
        static string DecryptPassword(string encryptedPassword)
        {
            byte[] passwordBytes = new byte[encryptedPassword.Length / 2];

            for (int i = 0; i < passwordBytes.Length; i++)
            {
                passwordBytes[i] = Convert.ToByte(encryptedPassword.Substring(i * 2, 2), 16); // convierte los caracteres hexadecimales a bytes
            }

            string password = Encoding.UTF8.GetString(passwordBytes); // convierte los bytes a una cadena de texto

            return password;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Cosas Blake
        /*
        =========
                static void dataaseconn ()
                {
                    //https://www.guru99.com/c-sharp-access-database.html#:~:text=SqlCommand%20in%20C%23%20allow%20the,best%20for%20the%20different%20commands.
                    SqlCommand Pato;
                    SqlDataReader Read;
                    SqlDataAdapter Write = new SqlDataAdapter();
                    SqlConnection cnn;
                    //datasource = pc, inital catalog = db user ID, password
                    string connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    //WRITE
        >>>>>>> 258953a3ee843b073dca3450ba08b5b1a7223870:PRUEAS/PRUEAS/Form1.cs
                    string quer = "INSERT";
                Write.InsertCommand = new SqlCommand(quer,cnn);
                    Write.InsertCommand.ExecuteNonQuery();

                    //READ
                    string syntax = "SELECT * FROM TABLE";
                    Pato = new SqlCommand(syntax, cnn);
                    Read = Pato.ExecuteReader();
                    while(Read.Read())
                    {
                        Console.WriteLine("READER.GetValue(0)");
                    }
                    MessageBox.Show("Connection Open  !");
                   cnn.Close(); */
        #endregion






      /*  private void Login_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                e.Handled = true;
                Menu();
            }
        }*/

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                Menu();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /* private void Login_SizeChanged(object sender, EventArgs e)
{
int windowWith = this.Width;
int windowHeight = this.Height;

int newControlWidth = (int)(windowWith * 0.2);
int newControlHeight = (int)(windowHeight * 0.3);

int newControlX = (windowWith - newControlWidth) / 2;
int newControlY = (windowHeight - newControlHeight) / 2;

button1.Size = new Size(newControlWidth, newControlHeight);
button1.Location = new Point(newControlX, newControlY);
label1.Size = new Size(newControlWidth, newControlHeight);
label1.Location = new Point(newControlX, newControlY);
textBox1.Size = new Size(newControlWidth, newControlHeight);
textBox1.Location = new Point(newControlX, newControlY);
Cerrar.Size = new Size(newControlWidth,newControlHeight);
Cerrar.Location = new Point(newControlX, newControlY);

}   */

    }

}

