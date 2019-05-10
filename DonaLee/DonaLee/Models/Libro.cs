using System;
using System.Collections.Generic;
using System.Text;

namespace LibrosApp.Models
{
    public class Libro
    {
        public String Anio__c { get; set; }
        public String Autor__c { get; set; }
        public String Editorial__c { get; set; }
        public String Id { get; set; }
        public String Imagen__c { get; set; }
        public String ISBN__c { get; set; }
        public String Titulo__c { get; set; }
        public String Genero__c { get; set; }
        public String Descripcion__c { get; set; }
        public String Valoracion__c { get; set; }
        public Libro()
        {

        }

        public override String ToString()
        {
            return "LIBRO [" + "Id :" + Id + " " + "ISBN__c :" + ISBN__c + " " + "Titulo__c :" + Titulo__c + " " 
                + "Editorial__c :" + Editorial__c + " " + "Autor__c :" + Autor__c + " " + "Anio__c :" 
                + Anio__c + " " + "Imagen__c :" + Imagen__c + " " + "Genero__c :" + Genero__c + " " 
                + "Descripcion__c :" + Descripcion__c + "]";
        }
    }
}