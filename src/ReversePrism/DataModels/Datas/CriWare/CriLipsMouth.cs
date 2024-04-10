using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HasExistingNativeHandle                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 handle                                   <int> IL2CPP_TYPE_I
    public partial class CriLipsMouth : DataModel
    {
        public bool                                     HasExistingNativeHandle                 { get; set; }

        public static CriLipsMouth? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsMouth() { Pointer= p0 };

            value.HasExistingNativeHandle                   = GetBool(new IntPtr(p + 0x020)); // 02466BC252C0 0x20 HasExistingNativeHandle     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
