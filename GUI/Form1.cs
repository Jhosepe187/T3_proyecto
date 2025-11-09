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
        Arbol Arbol = new Arbol();
        Pila Pila = new Pila(); 
        public Form1()
        {
            InitializeComponent();
            grpRegistrar1.Visible = false;

        }

        private void btton_RegistrarMaterial_Click(object sender, EventArgs e)
        {
            grpRegistrar1.Visible = true;
            int tipoNum = int.Parse(txtBox_TipoMaterial.Text);
            if (!int.TryParse(txtBox_TipoMaterial.Text, out tipoNum) || tipoNum < 1 || tipoNum > 4)
            {
                MessageBox.Show("Tipo inválido. Operación cancelada.");
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
            grpRegistrar1.Visible = false;

            Console.Write("Ingrese el nombre del material: ");
            string nombre = Console.ReadLine();

            Material nuevo = new Material(tipoTexto, nombre);
            cola.Encolar(nuevo);

            Console.WriteLine($"Material '{nombre}' de tipo '{tipoTexto}' registrado correctamente.");

        }

       
    }
}
