//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;

    public partial class Lending : IIdRecord
    {
        public Lending()
        {
            this.Books = new HashSet<LentBook>();
        }
    
        
    	public int Id { get; set; }
        
    	public System.DateTime EndDate { get; set; }
        
    	public System.DateTime LendingDate { get; set; }
        
    	public Nullable<System.DateTime> ReturnDate { get; set; }
        
    	public int ClientId { get; set; }
        
    	public int LendingEmployeeId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ICollection<LentBook> Books { get; set; }
        public virtual Employee LendingEmployee { get; set; }
    }
}
