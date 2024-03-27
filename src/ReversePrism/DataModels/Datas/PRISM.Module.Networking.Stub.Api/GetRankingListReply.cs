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
    // 018 RankingList                              000185CD5928 ModelClassListType RepeatedField`1<EventRankingStatus> RepeatedField`1<EventRankingStatus> List<EventRankingStatus> Pointer
    // 000 SongFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Song                                     00018652B0A0 ModelClassType SongStatus SongStatus SongStatus Pointer
    // 000 EventPointFieldNumber                    int IL2CPP_TYPE_I4
    // 028 EventPoint                               0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class GetRankingListReply
    {
        public List<EventRankingStatus>?                RankingList                             { get; set; }
        public SongStatus?                              Song                                    { get; set; }
        public ProductWithAmountStatus?                 EventPoint                              { get; set; }

        public static GetRankingListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetRankingListReply();

            value.RankingList                               = GetObjectList<EventRankingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventRankingStatus.FromPointer); // 0270D1014018 0x18 RankingList                 ( 000185CD5928 ModelClassListType RepeatedField`1<EventRankingStatus> RepeatedField`1<EventRankingStatus> List<EventRankingStatus> Pointer )
            value.Song                                      = GetObject<SongStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SongStatus.FromPointer); // 0270D1014058 0x20 Song                        ( 00018652B0A0 ModelClassType SongStatus SongStatus SongStatus Pointer )
            value.EventPoint                                = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1014098 0x28 EventPoint                  ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
