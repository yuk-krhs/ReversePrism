using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdFieldNumber                            int IL2CPP_TYPE_I4
    // 018 Id                                       000186671910 ModelPrimitiveType string string string String
    // 000 MstProduceCardIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceCardId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardRankFieldNumber                      int IL2CPP_TYPE_I4
    // 024 CardRank                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceCardContentGroupListFieldNumber   int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardContentGroupList_codec FieldCodec`1<ProduceCardContentGroupStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceCardContentGroupList              000185CEACD8 ModelClassListType RepeatedField`1<ProduceCardContentGroupStatus> RepeatedField`1<ProduceCardContentGroupStatus> List<ProduceCardContentGroupStatus> Pointer
    public partial class ProduceCardStatus : DataModel
    {
        public string                                   Id                                      { get; set; }
        public int                                      MstProduceCardId                        { get; set; }
        public int                                      CardRank                                { get; set; }
        public List<ProduceCardContentGroupStatus>?     ProduceCardContentGroupList             { get; set; }

        public static ProduceCardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardStatus() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 02466109B700 0x18 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.MstProduceCardId                          = GetInt32(new IntPtr(p + 0x020)); // 02466109B740 0x20 MstProduceCardId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardRank                                  = GetInt32(new IntPtr(p + 0x024)); // 02466109B780 0x24 CardRank                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceCardContentGroupList               = GetObjectList<ProduceCardContentGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardContentGroupStatus.FromPointer); // 02466109B7E0 0x28 ProduceCardContentGroupList ( 000185CEACD8 ModelClassListType RepeatedField`1<ProduceCardContentGroupStatus> RepeatedField`1<ProduceCardContentGroupStatus> List<ProduceCardContentGroupStatus> Pointer )

            return value;
        }
    }
}
