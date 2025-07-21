using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 010 InputUssClassName                        ModelPrimitiveType string string string String
    public partial class UnsignedIntegerField : DataModel
    {
        public string                                   InputUssClassName                       { get; set; }

        public static UnsignedIntegerField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsignedIntegerField() { Pointer= p0 };

            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0x10 InputUssClassName           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
