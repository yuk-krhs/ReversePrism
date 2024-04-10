using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 PlayableAppeal                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PCardAndSkillAppealEffectModel : DataModel
    {
        public int                                      PlayableAppeal                          { get; set; }

        public static PCardAndSkillAppealEffectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardAndSkillAppealEffectModel() { Pointer= p0 };

            value.PlayableAppeal                            = GetInt32(new IntPtr(p + 0x030)); // 024665B40660 0x30 PlayableAppeal              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
