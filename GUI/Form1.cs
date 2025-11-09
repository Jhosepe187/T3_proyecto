using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();
        Arbol arbol = new Arbol();
        Pila pila = new Pila();

        public Form1()
        {
            InitializeComponent();
            grpRegistrar.Visible = false;
            txtSalida.Visible = false; // Inicialmente oculto
        }

        private void btnRegistrarMaterial_Click(object sender, EventArgs e)
        {
            grpRegistrar.Visible = true;
            txtSalida.Visible = false;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            txtSalida.Visible = true; // Hacer visible el TextBox
            txtSalida.Text = ""; // Limpiar el texto antes de procesar y mostrar
            if (cola.EsVacio())
            {
                txtSalida.Text = "No hay materiales en la cola para procesar.";
                return;
            }
            while (!cola.EsVacio())
            {
                Material m = cola.Desencolar();
                arbol.Insertar(m);
                pila.Apilar(m);
                txtSalida.AppendText($"Procesado: {m}\r\n");
            }
            txtSalida.AppendText("\nTodos los materiales han sido clasificados y guardados en el historial.");
        }

        private void btnMostrarCola_Click(object sender, EventArgs e)
        {
            txtSalida.Visible = true; // Hacer visible el TextBox
            txtSalida.Text = ""; // Limpiar el texto antes de mostrar
            if (cola.EsVacio())
            {
                txtSalida.Text = "No hay materiales en la cola.";
                return;
            }
            Nodo aux = cola.frente;
            while (aux != null)
            {
                txtSalida.AppendText(aux.dato.ToString() + Environment.NewLine);
                aux = aux.sig;
            }
        }

        private void btnClasificados_Click(object sender, EventArgs e)
        {
            txtSalida.Visible = true; // Hacer visible el TextBox
            txtSalida.Text = ""; // Limpiar el texto antes de mostrar
            if (arbol.raiz_principal == null)
            {
                txtSalida.Text = "No hay materiales clasificados.";
                return;
            }
            MostrarArbolEnOrden(arbol.raiz_principal);
        }

        private void MostrarArbolEnOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                MostrarArbolEnOrden(raiz.izq);
                txtSalida.AppendText(raiz.dato.ToString() + Environment.NewLine);
                MostrarArbolEnOrden(raiz.der);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            txtSalida.Visible = true; // Hacer visible el TextBox
            txtSalida.Text = ""; // Limpiar el texto antes de mostrar
            Nodo aux = pila.cima;
            if (aux == null)
            {
                txtSalida.Text = "No hay historial disponible.";
                return;
            }
            while (aux != null)
            {
                txtSalida.AppendText(aux.dato.ToString() + Environment.NewLine);
                aux = aux.sig;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int tipoNum;
            if (!int.TryParse(txtTipo.Text, out tipoNum) || tipoNum < 1 || tipoNum > 4)
            {
                MessageBox.Show("Ingrese un número válido (1-4).");
                return;
            }
                string tipoTexto = "";
                switch (tipoNum)
                {
                    case 1:
                        tipoTexto = "Plástico";
                        break;
                    case 2:
                        tipoTexto = "Vidrio";
                        break;
                    case 3:
                        tipoTexto = "Papel";
                        break;
                    case 4:
                        tipoTexto = "Metal";
                        break;
                    default:
                        tipoTexto = "Desconocido";
                        break;
                }
                string nombre = txtNombre.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Ingrese un nombre para el material.");
                    return;
                }
                Material nuevo = new Material(tipoTexto, nombre);
                cola.Encolar(nuevo);
                txtSalida.Visible = true;
                txtSalida.Text = $"Material '{nombre}' de tipo '{tipoTexto}' registrado correctamente.";
                grpRegistrar.Visible = false;
                txtTipo.Clear();
                txtNombre.Clear();
            }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

