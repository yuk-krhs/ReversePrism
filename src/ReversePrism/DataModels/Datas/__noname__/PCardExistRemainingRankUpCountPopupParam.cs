using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CurrentRankUpCount                       0001865F4260 ModelPrimitiveType int int int Int32
    // 094 RankUpCountMax                           0001865F4260 ModelPrimitiveType int int int Int32
    // 098 <OnClickButton>k__BackingField           Action`1<int> IL2CPP_TYPE_GENERICINST
    public partial class PCardExistRemainingRankUpCountPopupParam : DataModel
    {
        public int                                      CurrentRankUpCount                      { get; set; }
        public int                                      RankUpCountMax                          { get; set; }

        public static PCardExistRemainingRankUpCountPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardExistRemainingRankUpCountPopupParam() { Pointer= p0 };

            value.CurrentRankUpCount                        = GetInt32(new IntPtr(p + 0x090)); // 024665D3B530 0x90 CurrentRankUpCount          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RankUpCountMax                            = GetInt32(new IntPtr(p + 0x094)); // 024665D3B550 0x94 RankUpCountMax              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
