using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDForm
{
    public partial class Form1 : Form
    {
        //dichiarazioni
        public int dim;
        public string[] array;

        //funzioni evento
        //costruttore della classe
        public Form1()
        {
            InitializeComponent();
            //inizializzazioni e dimensionamenti
            array = new string[100];
            dim = 0;
        }

        //carica il form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AggButton_Click(object sender, EventArgs e)
        {
            //funzione che aggiunge un elemento
            aggiunta(array, ref dim, Input.Text);
            //aggiorno la ListView
            liststampa.Items.Add(Input.Text);
        }

        //funzioni servizio
        public void aggiunta(string[] array, ref int dim, string elemento)
        {
            //inserisco l'elemento nella prima posizione disponibile dell'array
            array[dim] = elemento;
            //incremento la dimensione
            dim++;
        }
    }
}
