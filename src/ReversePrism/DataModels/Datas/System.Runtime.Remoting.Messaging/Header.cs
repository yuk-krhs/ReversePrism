using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HeaderNamespace                          ModelPrimitiveType string string string String
    // 018 MustUnderstand                           ModelPrimitiveType bool bool bool Bool
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 Value                                    <object> IL2CPP_TYPE_OBJECT
    public partial class Header : DataModel
    {
        public string                                   HeaderNamespace                         { get; set; }
        public bool                                     MustUnderstand                          { get; set; }
        public string                                   Name                                    { get; set; }

        public static Header? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Header() { Pointer= p0 };

            value.HeaderNamespace                           = GetString(new IntPtr(p + 0x010)); // 0x10 HeaderNamespace             ( ModelPrimitiveType string string string String )
            value.MustUnderstand                            = GetBool(new IntPtr(p + 0x018)); // 0x18 MustUnderstand              ( ModelPrimitiveType bool bool bool Bool )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
