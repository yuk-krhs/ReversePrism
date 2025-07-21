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
    // 000 RankingViewTypeFieldNumber               int IL2CPP_TYPE_I4
    // 018 RankingViewType                          ModelEnumType EventRankingViewType EventRankingViewType EventRankingViewType Int32
    // 000 MstEventRankingIdFieldNumber             int IL2CPP_TYPE_I4
    // 01C MstEventRankingId                        ModelPrimitiveType int int int Int32
    public partial class GetRankingArgs : DataModel
    {
        public EventRankingViewType                     RankingViewType                         { get; set; }
        public int                                      MstEventRankingId                       { get; set; }

        public static GetRankingArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetRankingArgs() { Pointer= p0 };

            value.RankingViewType                           = (EventRankingViewType)GetInt32(new IntPtr(p + 0x018)); // 0x18 RankingViewType             ( ModelEnumType EventRankingViewType EventRankingViewType EventRankingViewType Int32 )
            value.MstEventRankingId                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstEventRankingId           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
