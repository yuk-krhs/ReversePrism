using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceCardDeckStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 018 ProduceCardList                          ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    public partial class ProduceCardDeckStatus : DataModel
    {
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }

        public static ProduceCardDeckStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardDeckStatus() { Pointer= p0 };

            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0x18 ProduceCardList             ( ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )

            return value;
        }
    }
}
