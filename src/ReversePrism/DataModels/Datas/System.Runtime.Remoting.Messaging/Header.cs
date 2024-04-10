using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HeaderNamespace                          0001866722E0 ModelPrimitiveType string string string String
    // 018 MustUnderstand                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 Name                                     0001866722E0 ModelPrimitiveType string string string String
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

            value.HeaderNamespace                           = GetString(new IntPtr(p + 0x010)); // 024666C5FDB0 0x10 HeaderNamespace             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MustUnderstand                            = GetBool(new IntPtr(p + 0x018)); // 024666C5FDD0 0x18 MustUnderstand              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 024666C5FDF0 0x20 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
