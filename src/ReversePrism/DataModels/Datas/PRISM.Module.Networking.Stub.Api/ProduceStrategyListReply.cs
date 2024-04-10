using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceStrategyListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 ProduceStrategyListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_produceStrategyList_codec      FieldCodec`1<ProduceStrategyStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProduceStrategyList                      000185CEC478 ModelClassListType RepeatedField`1<ProduceStrategyStatus> RepeatedField`1<ProduceStrategyStatus> List<ProduceStrategyStatus> Pointer
    public partial class ProduceStrategyListReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public List<ProduceStrategyStatus>?             ProduceStrategyList                     { get; set; }

        public static ProduceStrategyListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceStrategyListReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 02466255D700 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.ProduceStrategyList                       = GetObjectList<ProduceStrategyStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceStrategyStatus.FromPointer); // 02466255D760 0x20 ProduceStrategyList         ( 000185CEC478 ModelClassListType RepeatedField`1<ProduceStrategyStatus> RepeatedField`1<ProduceStrategyStatus> List<ProduceStrategyStatus> Pointer )

            return value;
        }
    }
}
