using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolId                                   ModelPrimitiveType int int int Int32
    // 018 Point                                    ModelPrimitiveType long long long Int64
    // 020 Grade                                    ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32
    public partial class LiveEventRankingIdolSelfRankCellViewModel : DataModel
    {
        public int                                      IdolId                                  { get; set; }
        public long                                     Point                                   { get; set; }
        public EventRankGrade                           Grade                                   { get; set; }

        public static LiveEventRankingIdolSelfRankCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingIdolSelfRankCellViewModel() { Pointer= p0 };

            value.IdolId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 IdolId                      ( ModelPrimitiveType int int int Int32 )
            value.Point                                     = GetInt64(new IntPtr(p + 0x018)); // 0x18 Point                       ( ModelPrimitiveType long long long Int64 )
            value.Grade                                     = (EventRankGrade)GetInt32(new IntPtr(p + 0x020)); // 0x20 Grade                       ( ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32 )

            return value;
        }
    }
}
