using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  DisplayNameAttribute IL2CPP_TYPE_CLASS
    // 010 DisplayNameValue                         000186671910 ModelPrimitiveType string string string String
    public partial class DisplayNameAttribute : DataModel
    {
        public string                                   DisplayNameValue                        { get; set; }

        public static DisplayNameAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisplayNameAttribute() { Pointer= p0 };

            value.DisplayNameValue                          = GetString(new IntPtr(p + 0x010)); // 024667B7C4E0 0x10 DisplayNameValue            ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
