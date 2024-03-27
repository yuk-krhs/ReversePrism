using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 <ProduceCards>k__BackingField            IEnumerable`1<IProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 098 RankUpCountMax                           0001865F4260 ModelPrimitiveType int int int Int32
    // 0A0 <OnCompleteRankUp>k__BackingField        Action`1<ProduceNextOrderType> IL2CPP_TYPE_GENERICINST
    public partial class PCardRankUpPopupParam
    {
        public int                                      RankUpCountMax                          { get; set; }

        public static PCardRankUpPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpPopupParam();

            value.RankUpCountMax                            = GetInt32(new IntPtr(p + 0x098)); // 0270D5CEBF40 0x98 RankUpCountMax              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
