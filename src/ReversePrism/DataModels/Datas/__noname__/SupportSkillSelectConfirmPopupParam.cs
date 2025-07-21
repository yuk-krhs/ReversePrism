using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 RemoveSkill                              ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer
    // 098 RemoveIndex                              ModelPrimitiveType int int int Int32
    // 0A0 GetSkill                                 ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer
    // 0A8 OnFinishGetSkillFlow                     ModelClassType Action Action Action Pointer
    public partial class SupportSkillSelectConfirmPopupParam : DataModel
    {
        public IPotentialSupportSkillStatus?            RemoveSkill                             { get; set; }
        public int                                      RemoveIndex                             { get; set; }
        public IPotentialSupportSkillStatus?            GetSkill                                { get; set; }
        public Action?                                  OnFinishGetSkillFlow                    { get; set; }

        public static SupportSkillSelectConfirmPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillSelectConfirmPopupParam() { Pointer= p0 };

            value.RemoveSkill                               = GetObject<IPotentialSupportSkillStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0x90 RemoveSkill                 ( ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer )
            value.RemoveIndex                               = GetInt32(new IntPtr(p + 0x098)); // 0x98 RemoveIndex                 ( ModelPrimitiveType int int int Int32 )
            value.GetSkill                                  = GetObject<IPotentialSupportSkillStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0xA0 GetSkill                    ( ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer )
            value.OnFinishGetSkillFlow                      = GetObject<Action>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Action.FromPointer); // 0xA8 OnFinishGetSkillFlow        ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
