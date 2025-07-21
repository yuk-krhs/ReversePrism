using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AllToggleButton                          ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer
    // 028 UnitAllToggleButtons                     ModelClassListType GroupToggleButton[] GroupToggleButton[] List<GroupToggleButton> Pointer
    // 030 CharacterToggleButtons                   ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    public partial class CharacterFilterView : DataModel
    {
        public GroupToggleButton?                       AllToggleButton                         { get; set; }
        public List<GroupToggleButton>?                 UnitAllToggleButtons                    { get; set; }
        public List<ToggleButton>?                      CharacterToggleButtons                  { get; set; }

        public static CharacterFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterFilterView() { Pointer= p0 };

            value.AllToggleButton                           = GetObject<GroupToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.GroupToggleButton.FromPointer); // 0x20 AllToggleButton             ( ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer )
            value.UnitAllToggleButtons                      = GetObjectList<GroupToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.GroupToggleButton.FromPointer); // 0x28 UnitAllToggleButtons        ( ModelClassListType GroupToggleButton[] GroupToggleButton[] List<GroupToggleButton> Pointer )
            value.CharacterToggleButtons                    = GetObjectList<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x30 CharacterToggleButtons      ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )

            return value;
        }
    }
}
