using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_prodotti_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Properties
        public struct Article
        {
            public string nome;
            public double prezzo;
            public int eliminato;
        }
        private string currentAction = null;

        #endregion

        #region Form Action
        private void txtb_ProductName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtb_ProductPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            currentAction = "CREATE";

            HideAll();

            lbl_TitleCreate.Show();
            lbl_ProductName.Show();
            lbl_ProductPrice.Show();
            txtb_ProductName.Show();
            txtb_ProductPrice.Show();
            btn_Confirm.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_NewProductName_Click(object sender, EventArgs e)
        {

        }
        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            currentAction = "UPDATE";

            HideAll();

            lbl_TitleUpdate.Show();
            lbl_ProductName.Show();
            lbl_NewProductName.Show();
            lbl_NewProductPrice.Show();
            txtb_ProductName.Show();
            txtb_NewProductName.Show();
            txtb_NewProductPrice.Show();
            btn_Confirm.Show();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            currentAction = "SEARCH";

            HideAll();

            lbl_TitleSearch.Show();
            lbl_ProductName.Show();
            txtb_ProductName.Show();
            btn_Confirm.Show();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            currentAction = "DELETE";

            HideAll();

            lbl_TitleDelete.Show();
            lbl_ProductName.Show();
            txtb_ProductName.Show();
            btn_Confirm.Show();
        }
        private void btn_LogicDelete_Click(object sender, EventArgs e)
        {
            currentAction = "LOGIC_DELETE";

            HideAll();

            lbl_TitleDelete.Show();
            lbl_ProductName.Show();
            txtb_ProductName.Show();
            btn_Confirm.Show();

        }
        private void btn_Recover_Click(object sender, EventArgs e)
        {
            currentAction = "RECOVER";

            HideAll();

            lbl_TitleRecover.Show();
            lbl_ProductName.Show();
            txtb_ProductName.Show();
            btn_Confirm.Show();
        }
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            currentAction = "OPEN_FILE";

            HideAll();

            lbl_TitleOpenFile.Show();
            btn_Confirm.Show();
        }
        private void btn_EmptyFile_Click(object sender, EventArgs e)
        {
            currentAction = "EMPTY_FILE";

            HideAll();

            lbl_TitleEmptyFile.Show();
            btn_Confirm.Show();
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            switch (currentAction)
            {
                case "CREATE":

                    if (txtb_ProductName.Text == "" || txtb_ProductPrice.Text == "")
                    {
                        MessageBox.Show("Inserire qualcosa.");
                    }
                    else
                    {
                        if (double.TryParse(txtb_ProductPrice.Text, out _) || float.TryParse(txtb_ProductPrice.Text, out _) || int.TryParse(txtb_ProductPrice.Text, out _))
                        {
                            AddProduct(txtb_ProductName.Text, double.Parse(txtb_ProductPrice.Text.Replace(".", ",")), 0, "Articoli.csv");

                            MessageBox.Show("Prodotto salvato con successo!");
                        }
                        else
                        {
                            MessageBox.Show("Inserisci un valore numerico nella casella del prezzo.");
                        }
                    }

                    break;

                case "SEARCH":

                    Article[] articoli = Search(txtb_ProductName.Text);
                    string[] response = new string[articoli.Length];
                    string deleted = "";
                    bool found = false;
                    
                    for (int i = 0; i < articoli.Length; i++)
                    {
                        if (string.IsNullOrEmpty(articoli[i].nome))
                            continue;
                    
                        found = true;
                        deleted = "";
                    
                        if (articoli[i].eliminato == 1)
                            deleted = "Eliminato";
                    
                        response[i] = $"Articolo: {articoli[i].nome} {articoli[i].prezzo.ToString()}€ {deleted}";
                    }
                    
                    if(found == false)
                        MessageBox.Show($"Nessun articolo trovato con il nome: {txtb_ProductName.Text}");
                    else
                        MessageBox.Show(string.Join("\n", response));

                    break;

                case "DELETE":

                    if(DeleteByName(txtb_ProductName.Text) == false)
                        MessageBox.Show("Nessun prodotto da eliminare!");
                    
                    else
                        MessageBox.Show($"Prodotti eliminati con successo!");

                    break;

                case "UPDATE":

                    Article[] productsToUpdate = Search(txtb_ProductName.Text);

                    if (DeleteByName(txtb_ProductName.Text) == false)
                        MessageBox.Show("Nessun prodotto da modificare!");

                    else
                    {
                        if (txtb_NewProductName.Text == "" || txtb_NewProductPrice.Text == "")
                        {
                            MessageBox.Show("Inserire qualcosa.");
                        }
                        else
                        {
                            if (double.TryParse(txtb_NewProductPrice.Text, out _) || float.TryParse(txtb_NewProductPrice.Text, out _) || int.TryParse(txtb_NewProductPrice.Text, out _))
                            {
                                for (int i = 0; i < productsToUpdate.Length; i++)
                                {
                                    AddProduct(txtb_NewProductName.Text, double.Parse(txtb_NewProductPrice.Text), productsToUpdate[i].eliminato, "Articoli.csv");
                                }
                                MessageBox.Show("Prodotti modificati con successo!");
                            }
                            else
                            {
                                MessageBox.Show("Inserisci un valore numerico nella casella del prezzo.");
                            }
                        }
                    }

                    break;

                case "RECOVER":

                    Article[] productsToRecover = Search(txtb_ProductName.Text);

                    if (DeleteByName(txtb_ProductName.Text) == false)
                        MessageBox.Show("Nessun prodotto da recuperare!");

                    else
                    {
                        for (int i = 0; i < productsToRecover.Length; i++)
                        {
                            AddProduct(productsToRecover[i].nome, productsToRecover[i].prezzo, 0, "Articoli.csv");
                        }

                        MessageBox.Show("Prodotti recuperati con successo!");
                    }

                    break;

                case "LOGIC_DELETE":

                    Article[] productsToDelete = Search(txtb_ProductName.Text);

                    if (DeleteByName(txtb_ProductName.Text) == false)
                        MessageBox.Show("Nessun prodotto da eliminare!");

                    else
                    {
                        for (int i = 0; i < productsToDelete.Length; i++)
                        {
                            AddProduct(productsToDelete[i].nome, productsToDelete[i].prezzo, 1, "Articoli.csv");
                        }

                        MessageBox.Show("Prodotti eliminati con successo!");
                    }

                    break;

                case "OPEN_FILE":

                    string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Articoli.csv");

                    Process.Start(filePath);

                    break;

                case "EMPTY_FILE":

                    DeleteAllLines();

                    MessageBox.Show("File svuotato con successo!");

                    break;
            }

            DeleteEmptyLines();
        }
        #endregion

        #region Actions
        private void AddProduct(string nome, double prezzo, int eliminato, string filePath)
        {
            var oStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);

            sw.WriteLine($"{nome};{prezzo};{eliminato}");
            sw.Close();
        }
        private bool DeleteByName(string nome)
        {
            if (Search(nome).Length == 0)
                return false;
            
            else
            {
                Article[] articoli_validi = Search(nome, true);
                string[] fileLines = new string[articoli_validi.Length];

                for (int i = 0; i < articoli_validi.Length; i++)
                {
                    if (string.IsNullOrEmpty(articoli_validi[i].nome))
                        continue;

                    fileLines[i] = $"{articoli_validi[i].nome};{articoli_validi[i].prezzo};{articoli_validi[i].eliminato}";
                }

                File.WriteAllLines("Articoli.csv", fileLines);

                return true;
            }
        }
        private void DeleteEmptyLines()
        {
            StreamReader file = new StreamReader("Articoli.csv");
            string fileLine = null;
            int count = 0;

            do
            {
                fileLine = file.ReadLine();

                if (string.IsNullOrEmpty(fileLine) == false)
                    count++;

            }
            while (!file.EndOfStream);

            file.Close();
            file.Dispose();

            file = new StreamReader("Articoli.csv");
            string[] validLines = new string[count];
            int j = 0;

            do
            {
                fileLine = file.ReadLine();

                if (string.IsNullOrEmpty(fileLine) == false)
                {
                    validLines[j] = fileLine;
                    j++;
                }
            }
            while (!file.EndOfStream);

            file.Close();
            file.Dispose();

            File.WriteAllLines("Articoli.csv", validLines);
        }
        private Article[] Search(string nome, bool opposite = false)
        {
            Article[] products = ReadFile();
            Article product;
            Article[] valid = new Article[products.Length];
            int j = 0;

            for (int i = 0; i < products.Length; i++)
            {
                product = products[i];

                if((opposite == false && product.nome.ToUpper() == nome.ToUpper()) || (opposite == true && product.nome.ToUpper() != nome.ToUpper()))
                {
                    valid[j] = product;
                    j++;
                }
            }

            Article[] response = new Article[j];
            j = 0;

            for (int i = 0; i < valid.Length; i++)
            {
                if (string.IsNullOrEmpty(valid[i].nome) == false)
                {
                    response[j] = valid[i];
                    j++;
                }
            }

            return response;
        }
        private Article[] ReadFile(string FilePath = "Articoli.csv")
        {
            StreamReader file = new StreamReader(FilePath);
            string fileLine = null;
            int count = 0;

            do
            {
                fileLine = file.ReadLine();

                if (string.IsNullOrEmpty(fileLine) == false)
                    count++;
                
            }
            while (!file.EndOfStream);

            file.Close();
            file.Dispose();

            file = new StreamReader(FilePath);
            string[] splittedLine = new string[3];
            Article[] articoli = new Article[count];
            int j = 0;

            do
            {
                fileLine = file.ReadLine();

                if (fileLine != null)
                {
                    splittedLine = fileLine.Split(';');

                    if (string.IsNullOrEmpty(splittedLine[0]) == false)
                    {
                        Article articolo = new Article();
                        articolo.nome = splittedLine[0];
                        articolo.prezzo = double.Parse(splittedLine[1]);
                        articolo.eliminato = int.Parse(splittedLine[2]);
                        
                        articoli[j] = articolo;
                        j++;
                    }
                }
            }
            while (!file.EndOfStream);

            file.Close();
            file.Dispose();

            return articoli;
        }
        private void DeleteAllLines()
        {
            string FilePath = "Articoli.csv";
            var oStream = new FileStream(FilePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);

            sw.Close();
            File.WriteAllText("Articoli.csv", string.Empty);
            sw.Close();
        }
        private void HideAll()
        {
            lbl_TitleRecover.Hide();
            lbl_ProductName.Hide();
            lbl_NewProductName.Hide();
            lbl_NewProductPrice.Hide();
            lbl_ProductPrice.Hide();
            lbl_TitleCreate.Hide();
            lbl_TitleDelete.Hide();
            lbl_TitleRecover.Hide();
            lbl_TitleSearch.Hide();
            lbl_TitleUpdate.Hide();
            txtb_ProductName.Hide();
            txtb_NewProductName.Hide();
            txtb_ProductPrice.Hide();
            txtb_NewProductPrice.Hide();
            lbl_TitleEmptyFile.Hide();
            lbl_TitleOpenFile.Hide();
            btn_Confirm.Hide();
        }
        #endregion
    }
}
