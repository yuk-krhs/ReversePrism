using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  ModelClassType IEventRankingService IEventRankingService IEventRankingService Pointer
    // 018 EventId                                  ModelPrimitiveType int int int Int32
    // 020 RankingReply                             ModelClassType IGetPvpRankingReply IGetPvpRankingReply IGetPvpRankingReply Pointer
    public partial class PvpRankingModel : DataModel
    {
        public IEventRankingService?                    Service                                 { get; set; }
        public int                                      EventId                                 { get; set; }
        public IGetPvpRankingReply?                     RankingReply                            { get; set; }

        public static PvpRankingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpRankingModel() { Pointer= p0 };

            value.Service                                   = GetObject<IEventRankingService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEventRankingService.FromPointer); // 0x10 Service                     ( ModelClassType IEventRankingService IEventRankingService IEventRankingService Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.RankingReply                              = GetObject<IGetPvpRankingReply>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGetPvpRankingReply.FromPointer); // 0x20 RankingReply                ( ModelClassType IGetPvpRankingReply IGetPvpRankingReply IGetPvpRankingReply Pointer )

            return value;
        }
    }
}
