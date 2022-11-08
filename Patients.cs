//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Policlinic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patients()
        {
            this.SickLeave = new HashSet<SickLeave>();
            this.Visits = new HashSet<Visits>();
            this.Direction = new HashSet<Direction>();
        }
    
        public int Patient_id { get; set; }
        public long Policy { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public int Floor_id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string FIO
        {
            get
            {
                string _fio = Name + " " + Lastname + " " + Patronymic;
                return _fio;
            }
        }

        public virtual Floor Floor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SickLeave> SickLeave { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visits> Visits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Direction> Direction { get; set; }
    }
}