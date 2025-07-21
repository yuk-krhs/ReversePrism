using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 InvalidCultureName                       ModelPrimitiveType string string string String
    // 0A0 _invalidCultureId                        Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CultureNotFoundException : DataModel
    {
        public string                                   InvalidCultureName                      { get; set; }

        public static CultureNotFoundException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureNotFoundException() { Pointer= p0 };

            value.InvalidCultureName                        = GetString(new IntPtr(p + 0x098)); // 0x98 InvalidCultureName          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
