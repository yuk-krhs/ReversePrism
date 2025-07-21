using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Point                                    ValueTuple`2<long, long> IL2CPP_TYPE_GENERICINST
    // 020 Grade                                    ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32
    public partial class LiveResultAllSongEventIdolViewModel : DataModel
    {
        public EventRankGrade                           Grade                                   { get; set; }

        public static LiveResultAllSongEventIdolViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultAllSongEventIdolViewModel() { Pointer= p0 };

            value.Grade                                     = (EventRankGrade)GetInt32(new IntPtr(p + 0x020)); // 0x20 Grade                       ( ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32 )

            return value;
        }
    }
}
