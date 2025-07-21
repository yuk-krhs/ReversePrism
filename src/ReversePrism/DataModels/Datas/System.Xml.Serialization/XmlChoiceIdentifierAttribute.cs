using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemberName                               ModelPrimitiveType string string string String
    public partial class XmlChoiceIdentifierAttribute : DataModel
    {
        public string                                   MemberName                              { get; set; }

        public static XmlChoiceIdentifierAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlChoiceIdentifierAttribute() { Pointer= p0 };

            value.MemberName                                = GetString(new IntPtr(p + 0x010)); // 0x10 MemberName                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
