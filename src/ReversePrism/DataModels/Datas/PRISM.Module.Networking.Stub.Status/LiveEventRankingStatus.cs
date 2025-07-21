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
    // 018 RankingType                              ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Rank                                     ModelPrimitiveType int int int Int32
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Point                                    ModelPrimitiveType long long long Int64
    // 000 MstEventRankingIdFieldNumber             int IL2CPP_TYPE_I4
    // 028 MstEventRankingId                        ModelPrimitiveType int int int Int32
    // 000 RankGradeFieldNumber                     int IL2CPP_TYPE_I4
    // 02C RankGrade                                ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32
    public partial class LiveEventRankingStatus : DataModel
    {
        public EventRankingType                         RankingType                             { get; set; }
        public int                                      Rank                                    { get; set; }
        public long                                     Point                                   { get; set; }
        public int                                      MstEventRankingId                       { get; set; }
        public EventRankGrade                           RankGrade                               { get; set; }

        public static LiveEventRankingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingStatus() { Pointer= p0 };

            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x018)); // 0x18 RankingType                 ( ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Rank                        ( ModelPrimitiveType int int int Int32 )
            value.Point                                     = GetInt64(new IntPtr(p + 0x020)); // 0x20 Point                       ( ModelPrimitiveType long long long Int64 )
            value.MstEventRankingId                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstEventRankingId           ( ModelPrimitiveType int int int Int32 )
            value.RankGrade                                 = (EventRankGrade)GetInt32(new IntPtr(p + 0x02C)); // 0x2C RankGrade                   ( ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32 )

            return value;
        }
    }
}
