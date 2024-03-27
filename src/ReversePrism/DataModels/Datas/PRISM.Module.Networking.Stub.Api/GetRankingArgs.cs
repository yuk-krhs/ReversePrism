using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetRankingArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RankingTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 01C RankingType                              000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 000 RankingViewTypeFieldNumber               int IL2CPP_TYPE_I4
    // 020 RankingViewType                          000186763670 ModelEnumType EventRankingViewType EventRankingViewType EventRankingViewType Int32
    public partial class GetRankingArgs
    {
        public int                                      MstEventId                              { get; set; }
        public EventRankingType                         RankingType                             { get; set; }
        public EventRankingViewType                     RankingViewType                         { get; set; }

        public static GetRankingArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetRankingArgs();

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 0270D1011220 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x01C)); // 0270D1011260 0x1C RankingType                 ( 000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.RankingViewType                           = (EventRankingViewType)GetInt32(new IntPtr(p + 0x020)); // 0270D10112A0 0x20 RankingViewType             ( 000186763670 ModelEnumType EventRankingViewType EventRankingViewType EventRankingViewType Int32 )

            return value;
        }
    }
}
