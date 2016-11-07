using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicoWab.Models
{
    public class PatientModel
    {
        private int _id;
        private string _pseudo;
        private string _pwd;
        private string _nom;
        private string _prenom;
        private bool? _sexe;
        private DateTime _dateNaissance;
        private int _numero;
        private string _rue;
        private int _cp;
        private string _localite;
        private string _pays;
        private string _tel1;
        private string _tel2;
        private string _email;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        public string Pseudo
        {
            get { return _pseudo; }
            set { _pseudo = value; }
        }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        [Required]
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        [Required]
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        [Required]
        public bool? Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }

        [Required]
        [Display(Name = "Date de naissance")]
        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }
        [Display(Name = "N°")]
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Rue
        {
            get { return _rue; }
            set { _rue = value; }
        }

        [Display(Name = "CP")]
        public int Cp
        {
            get { return _cp; }
            set { _cp = value; }
        }
        [Display(Name = "Localité")]
        public string Localite
        {
            get { return _localite; }
            set { _localite = value; }
        }
        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Tel 1")]
        public string Tel1
        {
            get { return _tel1; }
            set { _tel1 = value; }
        }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Tel 2")]
        public string Tel2
        {
            get { return _tel2; }
            set { _tel2 = value; }
        }
        [DataType(DataType.EmailAddress)]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}