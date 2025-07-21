using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Exception                                ModelPrimitiveType string string string String
    public partial class NotNullAttribute : DataModel
    {
        public string                                   Exception                               { get; set; }

        public static NotNullAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotNullAttribute() { Pointer= p0 };

            value.Exception                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Exception                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
