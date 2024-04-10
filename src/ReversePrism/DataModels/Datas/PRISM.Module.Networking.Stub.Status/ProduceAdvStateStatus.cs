using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAdvStateStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsReadFieldNumber                        int IL2CPP_TYPE_I4
    // 018 IsRead                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ReadOptionNumberListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_readOptionNumberList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 ReadOptionNumberList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class ProduceAdvStateStatus : DataModel
    {
        public bool                                     IsRead                                  { get; set; }
        public List<int>?                               ReadOptionNumberList                    { get; set; }

        public static ProduceAdvStateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAdvStateStatus() { Pointer= p0 };

            value.IsRead                                    = GetBool(new IntPtr(p + 0x018)); // 02466108BB30 0x18 IsRead                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReadOptionNumberList                      = GetInt32List(new IntPtr(p + 0x020)); // 02466108BB90 0x20 ReadOptionNumberList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
