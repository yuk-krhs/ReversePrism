using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_typeName                               000186671910 ModelPrimitiveType string string string String
    public partial class TypeLoadExceptionHolder : DataModel
    {
        public string                                   M_typeName                              { get; set; }

        public static TypeLoadExceptionHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeLoadExceptionHolder() { Pointer= p0 };

            value.M_typeName                                = GetString(new IntPtr(p + 0x010)); // 024666C98580 0x10 M_typeName                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
