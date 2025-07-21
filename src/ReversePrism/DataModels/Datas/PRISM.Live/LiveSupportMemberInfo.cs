using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VocalSupports                            ValueTuple`2<LiveIdol, LiveIdol> IL2CPP_TYPE_GENERICINST
    // 020 DanceSupports                            ValueTuple`2<LiveIdol, LiveIdol> IL2CPP_TYPE_GENERICINST
    // 030 VisualSupports                           ValueTuple`2<LiveIdol, LiveIdol> IL2CPP_TYPE_GENERICINST
    // 040 MentalSupports                           ValueTuple`2<LiveIdol, LiveIdol> IL2CPP_TYPE_GENERICINST
    // 050 SupportBonusValue                        ModelPrimitiveType int int int Int32
    public partial class LiveSupportMemberInfo : DataModel
    {
        public int                                      SupportBonusValue                       { get; set; }

        public static LiveSupportMemberInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSupportMemberInfo() { Pointer= p0 };

            value.SupportBonusValue                         = GetInt32(new IntPtr(p + 0x050)); // 0x50 SupportBonusValue           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
