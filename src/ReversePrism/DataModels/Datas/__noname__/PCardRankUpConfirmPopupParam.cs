using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 <RankUpProduceCards>k__BackingField      IReadOnlyCollection`1<IProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 098 RankUpCountMax                           0001865F4260 ModelPrimitiveType int int int Int32
    public partial class PCardRankUpConfirmPopupParam
    {
        public int                                      RankUpCountMax                          { get; set; }

        public static PCardRankUpConfirmPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpConfirmPopupParam();

            value.RankUpCountMax                            = GetInt32(new IntPtr(p + 0x098)); // 0270D5CEB0E0 0x98 RankUpCountMax              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
