using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VersionAdded                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class OptionalFieldAttribute
    {
        public int                                      VersionAdded                            { get; set; }

        public static OptionalFieldAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionalFieldAttribute();

            value.VersionAdded                              = GetInt32(new IntPtr(p + 0x010)); // 027004D65C90 0x10 VersionAdded                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
