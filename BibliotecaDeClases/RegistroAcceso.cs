﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    
    public  class RegistroAcceso
    {
        private string usuario;     
        private string nombreFrm;

        public string Usuario { get => usuario; set => usuario = value; }

        public string NombreFrm { get => nombreFrm; set => nombreFrm = value; }



        public RegistroAcceso(string usuario, string nombreFrm)
        {
            this.Usuario = usuario;
            this.NombreFrm = nombreFrm;
        }
        /// <summary>
        /// Evento que se ejecuta cuando el formulario se abre.
        /// Registra la acción de abrir el formulario en los movimientos de usuario.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        public void OnFrmAbierto(object sender, EventArgs e)
        {
            string accion = "Abrio";
            MovimientosUsuariosHandler  movimientosUsuarioHandler = new MovimientosUsuariosHandler();
            movimientosUsuarioHandler.add(Usuario, accion, NombreFrm);
        }

        /// <summary>
        /// Evento que se ejecuta cuando el formulario se cierra.
        /// Registra la acción de cerrar el formulario en los movimientos de usuario.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        public void OnFrmCerrado(object sender, EventArgs e)
        {
            string accion = "Cerro";
            MovimientosUsuariosHandler movimientosUsuarioHandler = new MovimientosUsuariosHandler();
            movimientosUsuarioHandler.add(Usuario, accion, NombreFrm);
        }

        

    }
}
