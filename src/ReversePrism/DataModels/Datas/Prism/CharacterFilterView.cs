using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AllToggleButton                          00018669D390 ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer
    // 028 UnitAllToggleButtons                     000185B839E0 ModelClassListType GroupToggleButton[] GroupToggleButton[] List<GroupToggleButton> Pointer
    // 030 CharacterToggleButtons                   000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
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

            value.AllToggleButton                           = GetObject<GroupToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.GroupToggleButton.FromPointer); // 024664CE5D20 0x20 AllToggleButton             ( 00018669D390 ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer )
            value.UnitAllToggleButtons                      = GetObjectList<GroupToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.GroupToggleButton.FromPointer); // 024664CE5D40 0x28 UnitAllToggleButtons        ( 000185B839E0 ModelClassListType GroupToggleButton[] GroupToggleButton[] List<GroupToggleButton> Pointer )
            value.CharacterToggleButtons                    = GetObjectList<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 024664CE5D60 0x30 CharacterToggleButtons      ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )

            return value;
        }
    }
}
