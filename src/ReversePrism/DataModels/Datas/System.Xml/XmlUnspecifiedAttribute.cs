using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 FSpecified                               ModelPrimitiveType bool bool bool Bool
    public partial class XmlUnspecifiedAttribute : DataModel
    {
        public bool                                     FSpecified                              { get; set; }

        public static XmlUnspecifiedAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlUnspecifiedAttribute() { Pointer= p0 };

            value.FSpecified                                = GetBool(new IntPtr(p + 0x028)); // 0x28 FSpecified                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
