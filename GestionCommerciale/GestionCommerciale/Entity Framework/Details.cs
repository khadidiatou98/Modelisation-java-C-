//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCommerciale.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Details
    {
        public int article_id { get; set; }
        public int commande_id { get; set; }
        public Nullable<int> quantite { get; set; }
        public Nullable<decimal> prix { get; set; }
        public Nullable<decimal> montant { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual Commande Commande { get; set; }
    }
}
