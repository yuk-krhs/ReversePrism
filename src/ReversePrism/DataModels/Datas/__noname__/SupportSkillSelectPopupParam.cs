using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 GetSkill                                 0001865DBEE0 ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer
    // 098 SupportSkillList                         000185CE54F8 ModelClassListType List`1<IInProducePotentialSupportSkillStatus> List`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer
    // 0A0 MaxSlot                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A4 IsSkipConfirm                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A8 OnFinishGetSkillFlow                     000186679A00 ModelClassType Action Action Action Pointer
    public partial class SupportSkillSelectPopupParam
    {
        public IPotentialSupportSkillStatus?            GetSkill                                { get; set; }
        public List<IInProducePotentialSupportSkillStatus>? SupportSkillList                        { get; set; }
        public int                                      MaxSlot                                 { get; set; }
        public bool                                     IsSkipConfirm                           { get; set; }
        public Action?                                  OnFinishGetSkillFlow                    { get; set; }

        public static SupportSkillSelectPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillSelectPopupParam();

            value.GetSkill                                  = GetObject<IPotentialSupportSkillStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0270D5CF5678 0x90 GetSkill                    ( 0001865DBEE0 ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer )
            value.SupportSkillList                          = GetObjectList<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 0270D5CF5698 0x98 SupportSkillList            ( 000185CE54F8 ModelClassListType List`1<IInProducePotentialSupportSkillStatus> List`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer )
            value.MaxSlot                                   = GetInt32(new IntPtr(p + 0x0A0)); // 0270D5CF56B8 0xA0 MaxSlot                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsSkipConfirm                             = GetBool(new IntPtr(p + 0x0A4)); // 0270D5CF56D8 0xA4 IsSkipConfirm               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OnFinishGetSkillFlow                      = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0270D5CF56F8 0xA8 OnFinishGetSkillFlow        ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
