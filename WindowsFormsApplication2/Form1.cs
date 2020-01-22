using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            btMod.Enabled = false;
            btRech.Enabled = false;

        }

        OleDbConnection cnx = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/pc/Desktop/GestionDeProduit/WindowsFormsApplication2/Oualid.accdb");
        OleDbCommand cmd;
      
        public void afficher()
        {

            comboBCat.Items.Clear();
            string req = "select * from Produit";
            cmd = new OleDbCommand(req,cnx);
            OleDbDataReader dr;
            cnx.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBCat.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cnx.Close();
            comboBCat.SelectedIndex = 0;

        }

        public void clear()
        {
            comboBCat.Text = "";
            textBRef.Clear();
            textBDes.Clear();
            textBPu.Clear();
            textBTva.Clear();
        }

        private void form1_load(object sender, EventArgs e)
        {
            afficher();
        }
        public void btAjou_Click(object sender, EventArgs e)
        {
            cmd = cnx.CreateCommand();
            cnx.Open();
            cmd.CommandText = "Insert into Produit Values('" + textBRef.Text + "','" + textBDes.Text + "','" + comboBCat.Text + "','" + textBTva.Text + "','" + textBPu.Text + "')";
            cmd.Connection = cnx;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Produit ajouté avec succes! :) ");
            cnx.Close();
            
            afficher();
            clear();
        }
        private void comboBCat_SelectedIndexChanged(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void btRech_Click(object sender, EventArgs e)
        {
            cnx.Open();
            string req = "select * from Produit where Reference='{0}'";

            string query = string.Format(req, textBRef.Text);

            cmd = new OleDbCommand(query, cnx);
            OleDbDataReader dr;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBRef.Text = dr["Reference"].ToString();
                textBDes.Text = dr["Designation"].ToString();
                comboBCat.Text = dr["Categorie"].ToString();
                textBPu.Text = dr["Prix_Unitaire"].ToString();
                textBTva.Text = dr["TVA"].ToString();
            }
            else
            {
                MessageBox.Show("Aucun produit avec cette reference n'a été trouvé ");
            }

            dr.Close();
            cnx.Close();
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            cmd = cnx.CreateCommand();
            cnx.Open();

            string req = "UPDATE Produit SET Designation = '"+ textBDes.Text + "' , Categorie = '"+ comboBCat.Text +"' , Prix_Unitaire = '"+ textBPu.Text + "' , TVA =' "+ textBTva.Text +"' WHERE Reference = '"+ textBRef.Text + "' ";
            cmd = new OleDbCommand(req, cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Produit modifié avec success!");
            clear();
            cnx.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void btSup_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBRef_TextChanged(object sender, EventArgs e)
        {
            btMod.Enabled = true;
            btRech.Enabled = true;
        }
    }
}
    

