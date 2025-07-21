using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetRankingListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankingListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_rankingList_codec              FieldCodec`1<EventRankingStatus> IL2CPP_TYPE_GENERICINST
    // 018 RankingList                              ModelClassListType RepeatedField`1<EventRankingStatus> RepeatedField`1<EventRankingStatus> List<EventRankingStatus> Pointer
    // 000 SongFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Song                                     ModelClassType SongStatus SongStatus SongStatus Pointer
    // 000 EventPointFieldNumber                    int IL2CPP_TYPE_I4
    // 028 EventPoint                               ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class GetRankingListReply : DataModel
    {
        public List<EventRankingStatus>?                RankingList                             { get; set; }
        public SongStatus?                              Song                                    { get; set; }
        public ProductWithAmountStatus?                 EventPoint                              { get; set; }

        public static GetRankingListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetRankingListReply() { Pointer= p0 };

            value.RankingList                               = GetObjectList<EventRankingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventRankingStatus.FromPointer); // 0x18 RankingList                 ( ModelClassListType RepeatedField`1<EventRankingStatus> RepeatedField`1<EventRankingStatus> List<EventRankingStatus> Pointer )
            value.Song                                      = GetObject<SongStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SongStatus.FromPointer); // 0x20 Song                        ( ModelClassType SongStatus SongStatus SongStatus Pointer )
            value.EventPoint                                = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x28 EventPoint                  ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
