using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 SkillNodes                               000185CA8678 ModelClassListType SupportSkillNode[] SupportSkillNode[] List<SupportSkillNode> Pointer
    // 068 NumText                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ConfirmSkillListButton                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 SelectedIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C IsClose                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07D IsMaxSlot                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GetInheritanceSkillPopupContent
    {
        public List<SupportSkillNode>?                  SkillNodes                              { get; set; }
        public UITextMeshProUGUI?                       NumText                                 { get; set; }
        public UIButton?                                ConfirmSkillListButton                  { get; set; }
        public int                                      SelectedIndex                           { get; set; }
        public bool                                     IsClose                                 { get; set; }
        public bool                                     IsMaxSlot                               { get; set; }

        public static GetInheritanceSkillPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetInheritanceSkillPopupContent();

            value.SkillNodes                                = GetObjectList<SupportSkillNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0270D5CD95D8 0x60 SkillNodes                  ( 000185CA8678 ModelClassListType SupportSkillNode[] SupportSkillNode[] List<SupportSkillNode> Pointer )
            value.NumText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5CD95F8 0x68 NumText                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmSkillListButton                    = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5CD9618 0x70 ConfirmSkillListButton      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x078)); // 0270D5CD9638 0x78 SelectedIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsClose                                   = GetBool(new IntPtr(p + 0x07C)); // 0270D5CD9658 0x7C IsClose                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMaxSlot                                 = GetBool(new IntPtr(p + 0x07D)); // 0270D5CD9678 0x7D IsMaxSlot                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
