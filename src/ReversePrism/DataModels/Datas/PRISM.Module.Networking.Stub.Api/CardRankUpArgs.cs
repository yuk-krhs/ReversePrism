using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CardRankUpArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankUpCardIdListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_rankUpCardIdList_codec         FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 RankUpCardIdList                         000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class CardRankUpArgs
    {
        public List<string>?                            RankUpCardIdList                        { get; set; }

        public static CardRankUpArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardRankUpArgs();

            value.RankUpCardIdList                          = GetStringList(new IntPtr(p + 0x018)); // 0270D252AB70 0x18 RankUpCardIdList            ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
