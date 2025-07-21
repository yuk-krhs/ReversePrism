using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReferenceCount                           ModelPrimitiveType int int int Int32
    public partial class DefaultReferenceResolver : DataModel
    {
        public int                                      ReferenceCount                          { get; set; }

        public static DefaultReferenceResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultReferenceResolver() { Pointer= p0 };

            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 ReferenceCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
