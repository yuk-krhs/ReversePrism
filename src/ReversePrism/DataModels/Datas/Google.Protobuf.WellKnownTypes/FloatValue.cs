using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FloatValue> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Value                                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class FloatValue
    {
        public float                                    Value                                   { get; set; }

        public static FloatValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FloatValue();

            value.Value                                     = GetSingle(new IntPtr(p + 0x018)); // 0270DA4C7EE0 0x18 Value                       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
