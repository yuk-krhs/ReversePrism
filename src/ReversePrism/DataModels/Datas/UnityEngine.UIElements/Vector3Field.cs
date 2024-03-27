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
    // 010 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    public partial class Vector3Field
    {
        public string                                   InputUssClassName                       { get; set; }

        public static Vector3Field? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector3Field();

            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 027005086C30 0x10 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
