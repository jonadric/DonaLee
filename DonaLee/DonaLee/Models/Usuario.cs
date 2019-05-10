using System;
using System.Collections.Generic;
using System.Text;

namespace LibrosApp.Models
{
    public class Usuario
    {
        public String Nombres__c { get; set; }
        public String Apellidos__c { get; set; }
        public String Correo__c { get; set; }
        public String Contrasenia__c { get; set; }
        public String Id { get; set; }

        public Usuario()
        {

        }
        public Usuario(String correo, String contrasenia)
        {
            this.Correo__c = correo;
            this.Contrasenia__c = contrasenia;
        }

        public Usuario(String nombres, String apellidos, String correo, String contrasenia)
        {
            this.Nombres__c = nombres;
            this.Apellidos__c = apellidos;
            this.Correo__c = correo;
            this.Contrasenia__c = contrasenia;
        }
    }
}
