using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 AllowListToList                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 Untyped                                  XmlValueConverter IL2CPP_TYPE_CLASS
    // 008 UntypedList                              XmlValueConverter IL2CPP_TYPE_CLASS
    public partial class XmlUntypedConverter
    {
        public bool                                     AllowListToList                         { get; set; }

        public static XmlUntypedConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlUntypedConverter();

            value.AllowListToList                           = GetBool(new IntPtr(p + 0x030)); // 0270D75EA2A0 0x30 AllowListToList             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
