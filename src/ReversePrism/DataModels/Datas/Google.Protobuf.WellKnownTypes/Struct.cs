using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Struct> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FieldsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _map_fields_codec                        Codec<string, Value> IL2CPP_TYPE_GENERICINST
    // 018 fields_                                  MapField`2<string, Value> IL2CPP_TYPE_GENERICINST
    public partial class Struct
    {

        public static Struct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Struct();


            return value;
        }
    }
}
