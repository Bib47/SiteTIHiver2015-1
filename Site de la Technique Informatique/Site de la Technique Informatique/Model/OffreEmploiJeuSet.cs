//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Site_de_la_Technique_Informatique.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OffreEmploiJeuSet
    {
        public int IDOffreEmploi { get; set; }
        public string titreOffre { get; set; }
        public string descriptionOffre { get; set; }
        public System.DateTime dateOffre { get; set; }
        public Nullable<System.DateTime> dateExpiration { get; set; }
        public System.DateTime dateDebutOffre { get; set; }
        public string pathPDFDescription { get; set; }
        public decimal salaire { get; set; }
        public short nbHeureSemaine { get; set; }
        public string adresseTravail { get; set; }
        public string noTelephone { get; set; }
        public string noTelecopieur { get; set; }
        public string courrielOffre { get; set; }
        public string personneRessource { get; set; }
        public int EmployeurJeuIDEmployeur { get; set; }
        public int UtilisateurJeuIDUtilisateur { get; set; }
        public int VilleIDVille { get; set; }
    
        public virtual UtilisateurJeu UtilisateurJeu { get; set; }
        public virtual Ville Ville { get; set; }
    }
}
