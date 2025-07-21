using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MissionId                                ModelPrimitiveType int int int Int32
    public partial class SpecialMissionHintPopupViewModel : DataModel
    {
        public int                                      MissionId                               { get; set; }

        public static SpecialMissionHintPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionHintPopupViewModel() { Pointer= p0 };

            value.MissionId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MissionId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
