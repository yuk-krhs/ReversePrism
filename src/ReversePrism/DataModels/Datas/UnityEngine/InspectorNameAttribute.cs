using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayName                              0001866736C0 ModelPrimitiveType string string string String
    public partial class InspectorNameAttribute : DataModel
    {
        public string                                   DisplayName                             { get; set; }

        public static InspectorNameAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectorNameAttribute() { Pointer= p0 };

            value.DisplayName                               = GetString(new IntPtr(p + 0x010)); // 0245A23C28A0 0x10 DisplayName                 ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
