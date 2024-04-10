using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ListValue> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValuesFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _repeated_values_codec                   FieldCodec`1<Value> IL2CPP_TYPE_GENERICINST
    // 018 Values                                   000185CF7BA8 ModelClassListType RepeatedField`1<Value> RepeatedField`1<Value> List<Value> Pointer
    public partial class ListValue : DataModel
    {
        public List<Value>?                             Values                                  { get; set; }

        public static ListValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListValue() { Pointer= p0 };

            value.Values                                    = GetObjectList<Value>(new IntPtr(p + 0x018), ReversePrism.DataModels.Value.FromPointer); // 02466A4E65E0 0x18 Values                      ( 000185CF7BA8 ModelClassListType RepeatedField`1<Value> RepeatedField`1<Value> List<Value> Pointer )

            return value;
        }
    }
}
