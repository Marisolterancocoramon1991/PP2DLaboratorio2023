using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FormVentas : Form
    {
        Cliente? usuario;

        public FormVentas(Cliente cliente)
        {
            InitializeComponent();
            usuario = cliente;


        }




    }
}
