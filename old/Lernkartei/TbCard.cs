//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lernkartei
{
    using System;
    using System.Collections.Generic;
    
    public partial class TbCard
    {
        public long CardID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public long fk_ThemeID { get; set; }
    }
}