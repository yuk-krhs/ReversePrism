using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 CharacterIcons                           ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer
    // 030 CharacterIconsSummer                     ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer
    // 038 CharacterView                            ModelClassType GameObject GameObject GameObject Pointer
    // 040 CharacterViewSummer                      ModelClassType GameObject GameObject GameObject Pointer
    // 048 CurrentCharacterIcons                    ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer
    public partial class LiveMVOriginalMemberView : DataModel
    {
        public UITextMeshProUGUI?                       UnitNameText                            { get; set; }
        public List<LiveUnitEditCharacterIcon>?         CharacterIcons                          { get; set; }
        public List<LiveUnitEditCharacterIcon>?         CharacterIconsSummer                    { get; set; }
        public GameObject?                              CharacterView                           { get; set; }
        public GameObject?                              CharacterViewSummer                     { get; set; }
        public List<LiveUnitEditCharacterIcon>?         CurrentCharacterIcons                   { get; set; }

        public static LiveMVOriginalMemberView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVOriginalMemberView() { Pointer= p0 };

            value.UnitNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 UnitNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CharacterIcons                            = GetObjectList<LiveUnitEditCharacterIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveUnitEditCharacterIcon.FromPointer); // 0x28 CharacterIcons              ( ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer )
            value.CharacterIconsSummer                      = GetObjectList<LiveUnitEditCharacterIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveUnitEditCharacterIcon.FromPointer); // 0x30 CharacterIconsSummer        ( ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer )
            value.CharacterView                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 CharacterView               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CharacterViewSummer                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 CharacterViewSummer         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentCharacterIcons                     = GetObjectList<LiveUnitEditCharacterIcon>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveUnitEditCharacterIcon.FromPointer); // 0x48 CurrentCharacterIcons       ( ModelClassListType LiveUnitEditCharacterIcon[] LiveUnitEditCharacterIcon[] List<LiveUnitEditCharacterIcon> Pointer )

            return value;
        }
    }
}
