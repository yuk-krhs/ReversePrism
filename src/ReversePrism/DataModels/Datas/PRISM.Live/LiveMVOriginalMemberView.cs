using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 CharacterIcons                           000185B91990 ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer
    public partial class LiveMVOriginalMemberView : DataModel
    {
        public UITextMeshProUGUI?                       UnitNameText                            { get; set; }
        public List<LiveUnitEditCharacterIcon>?         CharacterIcons                          { get; set; }

        public static LiveMVOriginalMemberView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVOriginalMemberView() { Pointer= p0 };

            value.UnitNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651FD540 0x20 UnitNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CharacterIcons                            = GetObjectList<LiveUnitEditCharacterIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveUnitEditCharacterIcon.FromPointer); // 0246651FD560 0x28 CharacterIcons              ( 000185B91990 ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer )

            return value;
        }
    }
}
