using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveEventIdolResultStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 BeforePointFieldNumber                   int IL2CPP_TYPE_I4
    // 020 BeforePoint                              ModelPrimitiveType long long long Int64
    // 000 AfterPointFieldNumber                    int IL2CPP_TYPE_I4
    // 028 AfterPoint                               ModelPrimitiveType long long long Int64
    // 000 RankGradeFieldNumber                     int IL2CPP_TYPE_I4
    // 030 RankGrade                                ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32
    public partial class LiveEventIdolResultStatus : DataModel
    {
        public int                                      MstIdolId                               { get; set; }
        public long                                     BeforePoint                             { get; set; }
        public long                                     AfterPoint                              { get; set; }
        public EventRankGrade                           RankGrade                               { get; set; }

        public static LiveEventIdolResultStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventIdolResultStatus() { Pointer= p0 };

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.BeforePoint                               = GetInt64(new IntPtr(p + 0x020)); // 0x20 BeforePoint                 ( ModelPrimitiveType long long long Int64 )
            value.AfterPoint                                = GetInt64(new IntPtr(p + 0x028)); // 0x28 AfterPoint                  ( ModelPrimitiveType long long long Int64 )
            value.RankGrade                                 = (EventRankGrade)GetInt32(new IntPtr(p + 0x030)); // 0x30 RankGrade                   ( ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32 )

            return value;
        }
    }
}
