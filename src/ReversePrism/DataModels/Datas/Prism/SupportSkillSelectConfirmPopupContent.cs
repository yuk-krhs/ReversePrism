using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 RemoveSkill                              0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 068 GetSkill                                 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 070 Prm                                      0001865D20D0 ModelClassType SupportSkillSelectConfirmPopupParam SupportSkillSelectConfirmPopupParam SupportSkillSelectConfirmPopupParam Pointer
    public partial class SupportSkillSelectConfirmPopupContent : DataModel
    {
        public SupportSkillNode?                        RemoveSkill                             { get; set; }
        public SupportSkillNode?                        GetSkill                                { get; set; }
        public SupportSkillSelectConfirmPopupParam?     Prm                                     { get; set; }

        public static SupportSkillSelectConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillSelectConfirmPopupContent() { Pointer= p0 };

            value.RemoveSkill                               = GetObject<SupportSkillNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 024664D93828 0x60 RemoveSkill                 ( 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.GetSkill                                  = GetObject<SupportSkillNode>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 024664D93848 0x68 GetSkill                    ( 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.Prm                                       = GetObject<SupportSkillSelectConfirmPopupParam>(new IntPtr(p + 0x070), ReversePrism.DataModels.SupportSkillSelectConfirmPopupParam.FromPointer); // 024664D93868 0x70 Prm                         ( 0001865D20D0 ModelClassType SupportSkillSelectConfirmPopupParam SupportSkillSelectConfirmPopupParam SupportSkillSelectConfirmPopupParam Pointer )

            return value;
        }
    }
}
