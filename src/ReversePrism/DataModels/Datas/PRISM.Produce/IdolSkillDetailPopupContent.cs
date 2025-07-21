using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 Icon                                     ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer
    // 068 SkillName                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 Cost                                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 Description                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class IdolSkillDetailPopupContent : DataModel
    {
        public IdolSkillIcon?                           Icon                                    { get; set; }
        public UITextMeshProUGUI?                       SkillName                               { get; set; }
        public UITextMeshProUGUI?                       Cost                                    { get; set; }
        public UITextMeshProUGUI?                       Description                             { get; set; }

        public static IdolSkillDetailPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillDetailPopupContent() { Pointer= p0 };

            value.Icon                                      = GetObject<IdolSkillIcon>(new IntPtr(p + 0x060), ReversePrism.DataModels.IdolSkillIcon.FromPointer); // 0x60 Icon                        ( ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer )
            value.SkillName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 SkillName                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Cost                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 Cost                        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Description                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 Description                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
