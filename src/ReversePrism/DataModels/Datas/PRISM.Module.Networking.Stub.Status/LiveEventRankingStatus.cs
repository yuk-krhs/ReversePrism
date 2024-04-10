using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveEventRankingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankingTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 RankingType                              000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Point                                    0001865F7700 ModelPrimitiveType long long long Int64
    public partial class LiveEventRankingStatus : DataModel
    {
        public EventRankingType                         RankingType                             { get; set; }
        public int                                      Rank                                    { get; set; }
        public long                                     Point                                   { get; set; }

        public static LiveEventRankingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingStatus() { Pointer= p0 };

            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x018)); // 0246622E8F80 0x18 RankingType                 ( 000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x01C)); // 0246622E8FC0 0x1C Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Point                                     = GetInt64(new IntPtr(p + 0x020)); // 0246622E9000 0x20 Point                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
