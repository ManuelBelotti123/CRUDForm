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
            //condizioni di partenza
            LabelMod.Visible = false;
            InputMod.Visible = false;
            InvioMod.Visible = false;
        }

        //carica il form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AggButton_Click(object sender, EventArgs e)
        {
            //funzione che aggiunge un elemento
            Aggiunta(array, ref dim, Input.Text);
            //aggiorno la ListView
            liststampa.Items.Add(Input.Text);
        }

        private void CancElem_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(array, Input.Text, dim);
            if (pos == -1)
            {
                liststampa.Items.Clear();
                liststampa.Items.Add("Elemento non trovato");
            }
            else
            {
                cancella(array, pos, ref dim);
                liststampa.Items.Clear();
            }
        }

        private void ModificaElem_Click(object sender, EventArgs e)
        {
            LabelMod.Visible = true;
            InputMod.Visible = true;
            InvioMod.Visible = true;
        }

        private void InvioMod_Click(object sender, EventArgs e)
        {
            int pos = Ricerca(array, Input.Text, dim);
            if (pos == -1)
            {
                liststampa.Items.Clear();
                liststampa.Items.Add("Elemento non trovato");
            }
            else
            {
                modifica(array, InputMod.Text, pos);
                liststampa.Items.Clear();
            }
            LabelMod.Visible = false;
            InputMod.Visible = false;
            InvioMod.Visible = false;
        }

        private void SortFun_Click(object sender, EventArgs e)
        {
            Sort(array, dim);
        }

        private void ContaElemRipetuti_Click(object sender, EventArgs e)
        {
            liststampa.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                liststampa.Items.Add(array[i] + ": " + ContaElemR(array, i, dim));
            }
        }

        private void NomeLunCor_Click(object sender, EventArgs e)
        {
            liststampa.Items.Clear();
            //elemento più lungo
            liststampa.Items.Add("L'elemento più lungo è in posizione " + NomLunCor(array, dim, true));
            //elemento più corto
            liststampa.Items.Add("L'elemento più corto è in posizione " + NomLunCor(array, dim, false));
        }

        private void StampaArr_Click(object sender, EventArgs e)
        {
            stampa(array, dim);
        }

        //funzioni servizio
        public void Aggiunta(string[] array, ref int dim, string elemento)
        {
            //trasformo in minuscolo la stringa
            elemento = elemento.ToLower();
            //inserisco l'elemento nella prima posizione disponibile dell'array
            array[dim] = elemento;
            //incremento la dimensione
            dim++;
        }

        public int Ricerca(string[] array, string elemricercato, int dim)
        {
            int pos = -1;
            //trasformo in minuscolo la stringa
            elemricercato = elemricercato.ToLower();
            //ciclo di ricerca
            for (int i = 0; i < dim; i++)
            {
                if (array[i] == elemricercato)
                {
                    pos = i;
                }
            }
            return pos;
        }

        public void cancella(string[] array, int pos, ref int dim)
        {
            for (int i = pos; i < dim; i++)
            {
                array[pos] = array[pos + 1];
            }
            dim--;
        }

        public void modifica(string[] array, string elemricercato, int pos)
        {
            array[pos] = elemricercato;
        }

        public void stampa(string[] array, int dim)
        {
            liststampa.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                liststampa.Items.Add(array[i]);
            }
        }

        public void Sort(string[] array, int dim)
        {
            //dichiarazioni
            int x, y;
            string sup;
            //bubblesort
            for (x = 0; x < dim - 1; x++)
            {
                //confronta le coppie 
                for (y = 0; y < dim - 1 - x; y++)
                {
                    //nel caso trovo una coppia da scambiare
                    if (string.Compare(array[y], array[y + 1]) > 0)
                    {
                        sup = array[y];
                        //avviene lo scambio
                        array[y] = array[y + 1];
                        array[y + 1] = sup;
                    }
                }
            }
        }

        public int ContaElemR(string[] array, int pos, int dim)
        {
            //dichiarazione del contatore
            int cont = 0;
            //ciclo svolto per ogni stringa dell'array
            for (int i = 0; i < dim; i++)
            {
                if (array[pos] == array[i])
                {
                    cont++;
                }
            }
            return cont;
        }

        public int NomLunCor(string[] array, int dim, bool c)
        {
            int pos = 0;
            for (int i = 0; i < dim; i++)
            {
                //elemento più lungo
                if (c)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        if (array[i].Length < array[j].Length)
                        {
                            pos = j;
                        }
                    }
                }
                //elemento più corto
                else
                {
                    for (int j = 0; j < dim; j++)
                    {
                        if (array[i].Length > array[j].Length)
                        {
                            pos = j;
                        }
                    }
                }
            }
            return pos;
        }
    }
}
