using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 GetSkill                                 ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer
    // 098 SupportSkillList                         ModelClassListType List`1<IInProducePotentialSupportSkillStatus> List`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer
    // 0A0 MaxSlot                                  ModelPrimitiveType int int int Int32
    // 0A4 IsSkipConfirm                            ModelPrimitiveType bool bool bool Bool
    // 0A8 OnFinishGetSkillFlow                     ModelClassType Action Action Action Pointer
    public partial class SupportSkillSelectPopupParam : DataModel
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
            var value   = new SupportSkillSelectPopupParam() { Pointer= p0 };

            value.GetSkill                                  = GetObject<IPotentialSupportSkillStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0x90 GetSkill                    ( ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer )
            value.SupportSkillList                          = GetObjectList<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 0x98 SupportSkillList            ( ModelClassListType List`1<IInProducePotentialSupportSkillStatus> List`1<IInProducePotentialSupportSkillStatus> List<IInProducePotentialSupportSkillStatus> Pointer )
            value.MaxSlot                                   = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 MaxSlot                     ( ModelPrimitiveType int int int Int32 )
            value.IsSkipConfirm                             = GetBool(new IntPtr(p + 0x0A4)); // 0xA4 IsSkipConfirm               ( ModelPrimitiveType bool bool bool Bool )
            value.OnFinishGetSkillFlow                      = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0xA8 OnFinishGetSkillFlow        ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
