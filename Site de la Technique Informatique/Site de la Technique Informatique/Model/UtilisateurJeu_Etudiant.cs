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
    
    public partial class UtilisateurJeu_Etudiant
    {
        public int IDEtudiant { get; set; }
        public System.DateTime dateNaissance { get; set; }
        public System.DateTime dateInscription { get; set; }
        public bool valideTemoignage { get; set; }
        public bool valideCourriel { get; set; }
        public int IDUtilisateur { get; set; }
    
        public virtual UtilisateurJeu UtilisateurJeu { get; set; }
    }
}