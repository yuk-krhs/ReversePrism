using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 GetSkill                                 0001865DBEE0 ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer
    // 098 PopupMode                                0001865D0C00 ModelEnumType Mode Mode Mode Int32
    // 0A0 OnFinishGetSkillFlow                     000186679A00 ModelClassType Action Action Action Pointer
    public partial class SupportSkillConfirmPopupParam : DataModel
    {
        public IPotentialSupportSkillStatus?            GetSkill                                { get; set; }
        public Mode                                     PopupMode                               { get; set; }
        public Action?                                  OnFinishGetSkillFlow                    { get; set; }

        public static SupportSkillConfirmPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillConfirmPopupParam() { Pointer= p0 };

            value.GetSkill                                  = GetObject<IPotentialSupportSkillStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 024664D8DD30 0x90 GetSkill                    ( 0001865DBEE0 ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer )
            value.PopupMode                                 = (Mode)GetInt32(new IntPtr(p + 0x098)); // 024664D8DD50 0x98 PopupMode                   ( 0001865D0C00 ModelEnumType Mode Mode Mode Int32 )
            value.OnFinishGetSkillFlow                      = GetObject<Action>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Action.FromPointer); // 024664D8DD70 0xA0 OnFinishGetSkillFlow        ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
