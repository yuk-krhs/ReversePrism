using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DoubleValue> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Value                                    0001865C2950 ModelPrimitiveType double double double Double
    public partial class DoubleValue : DataModel
    {
        public double                                   Value                                   { get; set; }

        public static DoubleValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DoubleValue() { Pointer= p0 };

            value.Value                                     = GetDouble(new IntPtr(p + 0x018)); // 02466A532088 0x18 Value                       ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
