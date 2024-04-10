using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProfileRankingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankingTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 RankingType                              000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProfileRankingStatus : DataModel
    {
        public EventRankingType                         RankingType                             { get; set; }
        public int                                      Rank                                    { get; set; }

        public static ProfileRankingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileRankingStatus() { Pointer= p0 };

            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x018)); // 024662688A80 0x18 RankingType                 ( 000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x01C)); // 024662688AC0 0x1C Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
