using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Value> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NullValueFieldNumber                     int IL2CPP_TYPE_I4
    // 000 NumberValueFieldNumber                   int IL2CPP_TYPE_I4
    // 000 StringValueFieldNumber                   int IL2CPP_TYPE_I4
    // 000 BoolValueFieldNumber                     int IL2CPP_TYPE_I4
    // 000 StructValueFieldNumber                   int IL2CPP_TYPE_I4
    // 000 ListValueFieldNumber                     int IL2CPP_TYPE_I4
    // 018 kind_                                    <object> IL2CPP_TYPE_OBJECT
    // 020 KindCase                                 ModelEnumType KindOneofCase KindOneofCase KindOneofCase Int32
    public partial class Value : DataModel
    {
        public KindOneofCase                            KindCase                                { get; set; }

        public static Value? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Value() { Pointer= p0 };

            value.KindCase                                  = (KindOneofCase)GetInt32(new IntPtr(p + 0x020)); // 0x20 KindCase                    ( ModelEnumType KindOneofCase KindOneofCase KindOneofCase Int32 )

            return value;
        }
    }
}
