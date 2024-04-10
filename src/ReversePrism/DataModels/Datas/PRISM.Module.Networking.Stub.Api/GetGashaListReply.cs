using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_gashaList_codec                FieldCodec`1<GashaStatus> IL2CPP_TYPE_GENERICINST
    // 018 GashaList                                000185CDD3E8 ModelClassListType RepeatedField`1<GashaStatus> RepeatedField`1<GashaStatus> List<GashaStatus> Pointer
    // 000 GaugeListFieldNumber                     int IL2CPP_TYPE_I4
    // 010 _repeated_gaugeList_codec                FieldCodec`1<GashaPrismGaugeStatus> IL2CPP_TYPE_GENERICINST
    // 020 GaugeList                                000185CDC428 ModelClassListType RepeatedField`1<GashaPrismGaugeStatus> RepeatedField`1<GashaPrismGaugeStatus> List<GashaPrismGaugeStatus> Pointer
    // 000 ConvertExchangeIdListFieldNumber         int IL2CPP_TYPE_I4
    // 018 _repeated_convertExchangeIdList_codec    FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 028 ConvertExchangeIdList                    000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 ExchangeListFieldNumber                  int IL2CPP_TYPE_I4
    // 020 _repeated_exchangeList_codec             FieldCodec`1<GashaExchangeStatus> IL2CPP_TYPE_GENERICINST
    // 030 ExchangeList                             000185CDB638 ModelClassListType RepeatedField`1<GashaExchangeStatus> RepeatedField`1<GashaExchangeStatus> List<GashaExchangeStatus> Pointer
    // 000 RevertExchangeIdListFieldNumber          int IL2CPP_TYPE_I4
    // 028 _repeated_revertExchangeIdList_codec     FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 RevertExchangeIdList                     000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class GetGashaListReply : DataModel
    {
        public List<GashaStatus>?                       GashaList                               { get; set; }
        public List<GashaPrismGaugeStatus>?             GaugeList                               { get; set; }
        public List<string>?                            ConvertExchangeIdList                   { get; set; }
        public List<GashaExchangeStatus>?               ExchangeList                            { get; set; }
        public List<string>?                            RevertExchangeIdList                    { get; set; }

        public static GetGashaListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaListReply() { Pointer= p0 };

            value.GashaList                                 = GetObjectList<GashaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaStatus.FromPointer); // 02466199F3E0 0x18 GashaList                   ( 000185CDD3E8 ModelClassListType RepeatedField`1<GashaStatus> RepeatedField`1<GashaStatus> List<GashaStatus> Pointer )
            value.GaugeList                                 = GetObjectList<GashaPrismGaugeStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaPrismGaugeStatus.FromPointer); // 02466199F440 0x20 GaugeList                   ( 000185CDC428 ModelClassListType RepeatedField`1<GashaPrismGaugeStatus> RepeatedField`1<GashaPrismGaugeStatus> List<GashaPrismGaugeStatus> Pointer )
            value.ConvertExchangeIdList                     = GetStringList(new IntPtr(p + 0x028)); // 02466199F4A0 0x28 ConvertExchangeIdList       ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.ExchangeList                              = GetObjectList<GashaExchangeStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaExchangeStatus.FromPointer); // 02466199F500 0x30 ExchangeList                ( 000185CDB638 ModelClassListType RepeatedField`1<GashaExchangeStatus> RepeatedField`1<GashaExchangeStatus> List<GashaExchangeStatus> Pointer )
            value.RevertExchangeIdList                      = GetStringList(new IntPtr(p + 0x038)); // 02466199F560 0x38 RevertExchangeIdList        ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
