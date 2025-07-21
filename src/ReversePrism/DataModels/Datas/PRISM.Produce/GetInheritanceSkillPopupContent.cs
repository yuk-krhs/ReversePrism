using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 SkillNodes                               ModelClassListType SupportSkillNode[] SupportSkillNode[] List<SupportSkillNode> Pointer
    // 068 NumText                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ConfirmSkillListButton                   ModelClassType UIButton UIButton UIButton Pointer
    // 078 SelectedIndex                            ModelPrimitiveType int int int Int32
    // 07C IsClose                                  ModelPrimitiveType bool bool bool Bool
    // 07D IsMaxSlot                                ModelPrimitiveType bool bool bool Bool
    public partial class GetInheritanceSkillPopupContent : DataModel
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
            var value   = new GetInheritanceSkillPopupContent() { Pointer= p0 };

            value.SkillNodes                                = GetObjectList<SupportSkillNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x60 SkillNodes                  ( ModelClassListType SupportSkillNode[] SupportSkillNode[] List<SupportSkillNode> Pointer )
            value.NumText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 NumText                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmSkillListButton                    = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 ConfirmSkillListButton      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x078)); // 0x78 SelectedIndex               ( ModelPrimitiveType int int int Int32 )
            value.IsClose                                   = GetBool(new IntPtr(p + 0x07C)); // 0x7C IsClose                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsMaxSlot                                 = GetBool(new IntPtr(p + 0x07D)); // 0x7D IsMaxSlot                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
