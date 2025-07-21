using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ConvertGashaExchangePointReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ConvertPointListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_convertPointList_codec         FieldCodec`1<GashaConvertExchangePointStatus> IL2CPP_TYPE_GENERICINST
    // 018 ConvertPointList                         ModelClassListType RepeatedField`1<GashaConvertExchangePointStatus> RepeatedField`1<GashaConvertExchangePointStatus> List<GashaConvertExchangePointStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ConvertGashaExchangePointReply : DataModel
    {
        public List<GashaConvertExchangePointStatus>?   ConvertPointList                        { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ConvertGashaExchangePointReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConvertGashaExchangePointReply() { Pointer= p0 };

            value.ConvertPointList                          = GetObjectList<GashaConvertExchangePointStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaConvertExchangePointStatus.FromPointer); // 0x18 ConvertPointList            ( ModelClassListType RepeatedField`1<GashaConvertExchangePointStatus> RepeatedField`1<GashaConvertExchangePointStatus> List<GashaConvertExchangePointStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x20 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
