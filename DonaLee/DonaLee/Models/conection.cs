using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DonaLee.Models;


namespace DonaLee.Models
{
    public class conection
    {
        FirebaseClient firebase = new FirebaseClient("https://donalee-37b9f.firebaseio.com/");
        public async Task<List<Usuario>> GetAllUsers()
        {

            return (await firebase
              .Child("Users")
              .OnceAsync<Usuario>()).Select(item => new Usuario
              {
                  NombresUsuario = item.Object.NombresUsuario,
                  ApellidosUsuario = item.Object.ApellidosUsuario,
                  ContraseniaUsuario = item.Object.ContraseniaUsuario,
                  CorreoUsuario = item.Object.CorreoUsuario,
                  IdUsuario = item.Object.IdUsuario
              }).ToList();
        }

        public async Task AddPerson(int IdUsuario, string NombresUsuario)
            {

                await firebase
                  .Child("Users")
                  .PostAsync(new Usuario() { IdUsuario = IdUsuario, NombresUsuario = NombresUsuario });
            }

            public async Task<Usuario> GetPerson(int IdUsuario)
            {
                var allUsers = await GetAllUsers();
                await firebase
                  .Child("Users")
                  .OnceAsync<Usuario>();
                return allUsers.Where(a => a.IdUsuario == IdUsuario).FirstOrDefault();
            }

            public async Task UpdatePerson(int IdUsuario, string NombresUsuario)
            {
                var toUpdatePerson = (await firebase
                  .Child("Users")
                  .OnceAsync<Usuario>()).Where(a => a.Object.IdUsuario == IdUsuario).FirstOrDefault();

                await firebase
                  .Child("Users")
                  .Child(toUpdatePerson.Key)
                  .PutAsync(new Usuario() { IdUsuario = IdUsuario, NombresUsuario = NombresUsuario });
            }

            public async Task DeletePerson(int IdUsuario)
            {
                var toDeletePerson = (await firebase
                  .Child("Users")
                  .OnceAsync<Usuario>()).Where(a => a.Object.IdUsuario == IdUsuario).FirstOrDefault();
                await firebase.Child("Users").Child(toDeletePerson.Key).DeleteAsync();

            }
        

    }
}
