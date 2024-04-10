using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      000186671BA0 ModelPrimitiveType string string string String
    // 018 Value                                    <object> IL2CPP_TYPE_OBJECT
    public partial class NameObjectEntry : DataModel
    {
        public string                                   Key                                     { get; set; }

        public static NameObjectEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameObjectEntry() { Pointer= p0 };

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 024667BDC290 0x10 Key                         ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
