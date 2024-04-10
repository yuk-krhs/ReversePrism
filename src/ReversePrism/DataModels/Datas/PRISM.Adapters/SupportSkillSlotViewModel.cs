using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportSkill                             00018657DEF0 ModelClassType IInProducePotentialSupportSkillStatus IInProducePotentialSupportSkillStatus IInProducePotentialSupportSkillStatus Pointer
    public partial class SupportSkillSlotViewModel : DataModel
    {
        public IInProducePotentialSupportSkillStatus?   SupportSkill                            { get; set; }

        public static SupportSkillSlotViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillSlotViewModel() { Pointer= p0 };

            value.SupportSkill                              = GetObject<IInProducePotentialSupportSkillStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IInProducePotentialSupportSkillStatus.FromPointer); // 024666555270 0x10 SupportSkill                ( 00018657DEF0 ModelClassType IInProducePotentialSupportSkillStatus IInProducePotentialSupportSkillStatus IInProducePotentialSupportSkillStatus Pointer )

            return value;
        }
    }
}
