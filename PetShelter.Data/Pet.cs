//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetShelter.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet()
        {
            this.Adoptions = new HashSet<Adoption>();
            this.DissolutionOfAdoptions = new HashSet<DissolutionOfAdoption>();
        }
    
        public int PetID { get; set; }
        public string Familly { get; set; }
        public byte[] Image { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool Neutralized { get; set; }
        public string Name { get; set; }
        public string Unusual { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string Breed { get; set; }
        public string Disease { get; set; }
        public int Weight { get; set; }
        public Nullable<int> AnimalRegistrationNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adoption> Adoptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DissolutionOfAdoption> DissolutionOfAdoptions { get; set; }
    }
}