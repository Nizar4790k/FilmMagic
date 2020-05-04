using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmMagic.Models;


namespace FilmMagic.Views.Cliente
{


    public partial class AgregarOActualizar : Form
    {

        private Models.Cliente mCliente;
        private FilmMagicEntities mDb;
        



        public AgregarOActualizar()
        {
       
            mDb = new FilmMagicEntities();

            InitializeComponent();
       
          
        }

    
        



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



     


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            if (mCliente == null)
            {
               mCliente = new Models.Cliente();
            }
           
            

            mCliente.Nombre = txtNombre.Text.ToString();
            mCliente.Apellido = txtApellido.Text.ToString();
            mCliente.Cedula = txtCedula.Text.ToString();
            mCliente.Telefono = txtTelefono.Text.ToString();
            mCliente.Estado = radActivo.Checked;


        
             mDb.Clientes.Add(mCliente);
         
         

            
            
            mDb.SaveChanges();

            Console.WriteLine("Cliente agregado con exito");
           



        }




    }
}
