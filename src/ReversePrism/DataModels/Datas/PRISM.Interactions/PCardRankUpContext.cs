using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 rankUpIconBlinkValue                     ReactiveProperty`1<float> IL2CPP_TYPE_GENERICINST
    // 068 OnClickPlusButton                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 OnClickMinusButton                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 RemainingRankUpCount                     ModelPrimitiveType int int int Int32
    public partial class PCardRankUpContext : DataModel
    {
        public int                                      RemainingRankUpCount                    { get; set; }

        public static PCardRankUpContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpContext() { Pointer= p0 };

            value.RemainingRankUpCount                      = GetInt32(new IntPtr(p + 0x078)); // 0x78 RemainingRankUpCount        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
