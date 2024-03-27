using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RecordTimeArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 KindFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Kind                                     000186671910 ModelPrimitiveType string string string String
    public partial class RecordTimeArgs
    {
        public string                                   Kind                                    { get; set; }

        public static RecordTimeArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecordTimeArgs();

            value.Kind                                      = GetString(new IntPtr(p + 0x018)); // 0270D2D1E118 0x18 Kind                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
