using MedicoWab.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicoWab.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult TestAjax()
        {
            return View();
        }
        // GET: Patient
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Inscription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inscription(PatientModel model)
        {
            if (ModelState.IsValid)
            {
                // connection à la base de données
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=26R2-14\WADSQL;Initial Catalog=MedicoDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                db.Open();

                // Exécuter la requête INSERT
                SqlCommand cmd = db.CreateCommand(); // création de la commande

                cmd.CommandText = @"INSERT INTO [Patient](pseudo, pwd, nom, prenom, sexe, dateNaissance, num, rue, cp, localite, pays, tel1, tel2, email)
                                       VALUES ('" + model.Pseudo
                                                  + "', '" + model.Pwd
                                                  + "', '" + model.Nom
                                                  + "','" + model.Prenom
                                                  + "','" + model.Sexe
                                                  + "','" + model.DateNaissance.Date.ToString("yyyy-MM-dd HH:mm:ss")
                                                  + "','" + model.Numero
                                                  + "','" + model.Rue
                                                  + "','" + model.Cp
                                                  + "','" + model.Localite
                                                  + "','" + model.Pays
                                                  + "','" + model.Tel1
                                                  + "','" + model.Tel2
                                                  + "','" + model.Email
                                                  + "')"; // on écrit la requête SQL
                cmd.ExecuteNonQuery(); // exécution de la requête

                // fermeture de la connection à la bdd
                db.Close();

                return RedirectToAction("ConfirmationInscription");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult ConfirmationInscription()
        {

            return View();
        }
    }
}