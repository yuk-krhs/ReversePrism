using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 AnimatorWithEvent                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    public partial class PCardAndSkillUIAppealEffect : DataModel
    {
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }

        public static PCardAndSkillUIAppealEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardAndSkillUIAppealEffect() { Pointer= p0 };

            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 024665B408B0 0x48 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )

            return value;
        }
    }
}
