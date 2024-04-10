using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 Mode                                     0001865D0990 ModelEnumType Mode Mode Mode Int32
    // 068 GetSkill                                 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 070 GetSkillText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 NotGetSkillText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 ConfirmSkillText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
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

            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x060)); // 024664D8DC70 0x60 Mode                        ( 0001865D0990 ModelEnumType Mode Mode Mode Int32 )
            value.GetSkill                                  = GetObject<SupportSkillNode>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 024664D8DC90 0x68 GetSkill                    ( 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.GetSkillText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664D8DCB0 0x70 GetSkillText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NotGetSkillText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664D8DCD0 0x78 NotGetSkillText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmSkillText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664D8DCF0 0x80 ConfirmSkillText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
