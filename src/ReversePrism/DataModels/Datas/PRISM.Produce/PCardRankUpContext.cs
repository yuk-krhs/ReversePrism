using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 OnClickPlusButton                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 OnClickMinusButton                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 RemainingRankUpCount                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 070 rankUpIconBlinkValue                     ReactiveProperty`1<float> IL2CPP_TYPE_GENERICINST
    public partial class PCardRankUpContext
    {
        public int                                      RemainingRankUpCount                    { get; set; }

        public static PCardRankUpContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpContext();

            value.RemainingRankUpCount                      = GetInt32(new IntPtr(p + 0x068)); // 0270D5CE9940 0x68 RemainingRankUpCount        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
