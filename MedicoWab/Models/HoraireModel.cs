using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MedicoWab.Models
{
    public class HoraireModel
    {
        private int _id;
        private string _jour;
        private TimeSpan _debMat;
        private TimeSpan _finMat;
        private TimeSpan _debAprem;
        private TimeSpan _finAprem;
        private DateTime _debDate;
        private DateTime _finDate;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Jour
        {
            get { return _jour; }
            set { _jour = value; }
        }
        public TimeSpan DebMat
        {
            get { return _debMat; }
            set { _debMat = value; }
        }
        public TimeSpan FinMat
        {
            get { return _finMat; }
            set { _finMat = value; }
        }
        public TimeSpan DebAprem
        {
            get { return _debAprem; }
            set { _debAprem = value; }
        }
        public TimeSpan FinAprem
        {
            get { return _finAprem; }
            set { _finAprem = value; }
        }
        public DateTime DebDate
        {
            get { return _debDate; }
            set { _debDate = value; }
        }

        public DateTime FinDate
        {
            get { return _finDate; }
            set { _finDate = value; }
        }


        public List<HoraireModel> GetAll()
        {
            List<HoraireModel> laliste = new List<HoraireModel>();
            // 1 - Connexion
            SqlConnection oConn = new SqlConnection();

            // 1.1 - Chemin vers le serveur ==> ConnectionString
            oConn.ConnectionString = @"Data Source=26R2-14\WADSQL;Initial Catalog=MedicoDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            
            // 1.2 - Ouvrir la connexion
            try
            {
                oConn.Open();
                // 2 - Commande
                SqlCommand oCmd = new SqlCommand(@"SELECT * FROM Horaire WHERE DebDate <= GETDATE() AND FinDate >= GETDATE()", oConn);

                // Forme longue:
                    // SqlCommand oCmd = new SqlCommand();
                    // oCmd.Connection = oConn;
                    // oCmd.CommandText = @"SELECT * FROM Horaire WHERE DebDate <= GETDATE() AND FinDate >= GETDATE()";

                // 3 - Execute

                SqlDataReader oDr = oCmd.ExecuteReader();

                // 3.1 - lire toutes les lignes

                while (oDr.Read())
                {
                    HoraireModel HM = new HoraireModel();
                    HM.Id = (int) oDr["IdHoraire"];
                    HM.Jour = oDr["Jour"].ToString();
                    HM.DebMat = (TimeSpan)oDr["DebMat"];
                    HM.FinMat = (TimeSpan)oDr["FinMat"];
                    HM.DebAprem = (TimeSpan)oDr["DebAprem"];
                    HM.FinAprem = (TimeSpan)oDr["FinAprem"];
                    HM.DebDate = (DateTime)oDr["DebDate"];
                    HM.FinDate = (DateTime)oDr["FinDate"];
                    laliste.Add(HM);
                }

                // 3.2 - Fermer le reader

                oDr.Close();

                // 4 - Fermer la connexion

                oConn.Close();

            }
            catch (Exception)
            {
                
                throw;
            }

            return laliste;
        }
    }
}