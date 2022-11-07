//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Atestados.Datos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Atestado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Atestado()
        {
            this.Archivo = new HashSet<Archivo>();
            this.Evaluacion = new HashSet<Evaluacion>();
            this.AtestadoXPersona = new HashSet<AtestadoXPersona>();
            this.EvaluaciónXAtestado = new HashSet<EvaluaciónXAtestado>();
        }
    
        public int AtestadoID { get; set; }
        public string Nombre { get; set; }
        public int NumeroAutores { get; set; }
        public string Observaciones { get; set; }
        public string Codigo { get; set; }
        public System.DateTime HoraCreacion { get; set; }
        public Nullable<int> Enviado { get; set; }
        public Nullable<int> Descargado { get; set; }
        public Nullable<int> CantidadHoras { get; set; }
        public string Lugar { get; set; }
        public string CatalogoTipo { get; set; }
        public string Enlace { get; set; }
        public int PaisID { get; set; }
        public int PersonaID { get; set; }
        public int RubroID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Archivo> Archivo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluacion> Evaluacion { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Rubro Rubro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AtestadoXPersona> AtestadoXPersona { get; set; }
        public virtual DominioIdioma DominioIdioma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvaluaciónXAtestado> EvaluaciónXAtestado { get; set; }
        public virtual Fecha Fecha { get; set; }
        public virtual InfoEditorial InfoEditorial { get; set; }
    }
}
