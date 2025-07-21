using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 Mode                                     ModelEnumType Mode Mode Mode Int32
    // 068 GetSkill                                 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 070 GetSkillText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 NotGetSkillText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 ConfirmSkillText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class SupportSkillConfirmPopupContent : DataModel
    {
        public Mode                                     Mode                                    { get; set; }
        public SupportSkillNode?                        GetSkill                                { get; set; }
        public UITextMeshProUGUI?                       GetSkillText                            { get; set; }
        public UITextMeshProUGUI?                       NotGetSkillText                         { get; set; }
        public UITextMeshProUGUI?                       ConfirmSkillText                        { get; set; }

        public static SupportSkillConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillConfirmPopupContent() { Pointer= p0 };

            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x060)); // 0x60 Mode                        ( ModelEnumType Mode Mode Mode Int32 )
            value.GetSkill                                  = GetObject<SupportSkillNode>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x68 GetSkill                    ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.GetSkillText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 GetSkillText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NotGetSkillText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 NotGetSkillText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmSkillText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 ConfirmSkillText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
