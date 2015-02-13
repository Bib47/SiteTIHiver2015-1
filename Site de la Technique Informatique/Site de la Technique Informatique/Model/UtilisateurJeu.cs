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
    
    public partial class UtilisateurJeu
    {
        public UtilisateurJeu()
        {
            this.LogJeu = new HashSet<LogJeu>();
            this.OffreEmploiJeuSet = new HashSet<OffreEmploiJeuSet>();
            this.MessageForumJeu = new HashSet<MessageForumJeu>();
            this.ConsultationForumJeu = new HashSet<ConsultationForumJeu>();
            this.EnteteForumJeu = new HashSet<EnteteForumJeu>();
        }
    
        public int IDUtilisateur { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string courriel { get; set; }
        public string hashMotDepasse { get; set; }
        public string pathPhotoProfil { get; set; }
        public string photoDescription { get; set; }
        public string temoignage { get; set; }
        public Nullable<System.DateTime> dateTemoignage { get; set; }
        public bool compteActif { get; set; }
        public short typeDeCompte { get; set; }
    
        public virtual ICollection<LogJeu> LogJeu { get; set; }
        public virtual ICollection<OffreEmploiJeuSet> OffreEmploiJeuSet { get; set; }
        public virtual ICollection<MessageForumJeu> MessageForumJeu { get; set; }
        public virtual ICollection<ConsultationForumJeu> ConsultationForumJeu { get; set; }
        public virtual ICollection<EnteteForumJeu> EnteteForumJeu { get; set; }
    }
}
