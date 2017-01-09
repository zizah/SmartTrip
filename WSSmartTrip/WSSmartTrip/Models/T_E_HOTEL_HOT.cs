//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSSmartTrip.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_E_HOTEL_HOT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_E_HOTEL_HOT()
        {
            this.T_E_ALIAS_ALI = new HashSet<T_E_ALIAS_ALI>();
            this.T_E_AVIS_AVI = new HashSet<T_E_AVIS_AVI>();
            this.T_E_PHOTO_PHO = new HashSet<T_E_PHOTO_PHO>();
            this.T_R_EQUIPEMENT_EQU = new HashSet<T_R_EQUIPEMENT_EQU>();
            this.T_E_ABONNE_ABO = new HashSet<T_E_ABONNE_ABO>();
            this.T_E_HOTEL_HOT1 = new HashSet<T_E_HOTEL_HOT>();
            this.T_E_HOTEL_HOT2 = new HashSet<T_E_HOTEL_HOT>();
        }
    
        public decimal HOT_ID { get; set; }
        public decimal HTR_ID { get; set; }
        public decimal PRX_ID { get; set; }
        public string HOT_NOM { get; set; }
        public string HOT_DESCRIPTION { get; set; }
        public string HOT_ADRLIGNE1 { get; set; }
        public string HOT_ADRLIGNE2 { get; set; }
        public string HOT_CP { get; set; }
        public string HOT_VILLE { get; set; }
        public string HOT_ETAT { get; set; }
        public decimal PAY_ID { get; set; }
        public float HOT_LATITUDE { get; set; }
        public float HOT_LONGITUDE { get; set; }
        public decimal IND_INDICATIF { get; set; }
        public decimal CAT_NBETOILES { get; set; }
        public string HOT_TEL { get; set; }
        public string HOT_MEL { get; set; }
        public string HOT_SITEWEB { get; set; }
        public Nullable<decimal> HOT_NBCHAMBRES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_ALIAS_ALI> T_E_ALIAS_ALI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_AVIS_AVI> T_E_AVIS_AVI { get; set; }
        public virtual T_R_CATEGORIEHOTEL_CAT T_R_CATEGORIEHOTEL_CAT { get; set; }
        public virtual T_R_INDICATIFTEL_IND T_R_INDICATIFTEL_IND { get; set; }
        public virtual T_R_PAYS_PAY T_R_PAYS_PAY { get; set; }
        public virtual T_R_FOURCHETTEPRIX_PRX T_R_FOURCHETTEPRIX_PRX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_PHOTO_PHO> T_E_PHOTO_PHO { get; set; }
        public virtual T_E_HOTELIER_HTR T_E_HOTELIER_HTR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_R_EQUIPEMENT_EQU> T_R_EQUIPEMENT_EQU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_ABONNE_ABO> T_E_ABONNE_ABO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_HOTEL_HOT> T_E_HOTEL_HOT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_E_HOTEL_HOT> T_E_HOTEL_HOT2 { get; set; }
    }
}
