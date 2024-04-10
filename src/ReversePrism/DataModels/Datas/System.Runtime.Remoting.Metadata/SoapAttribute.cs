using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAttribute                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 ProtXmlNamespace                         000186671E00 ModelPrimitiveType string string string String
    // 020 ReflectInfo                              <object> IL2CPP_TYPE_OBJECT
    public partial class SoapAttribute : DataModel
    {
        public bool                                     UseAttribute                            { get; set; }
        public string                                   ProtXmlNamespace                        { get; set; }

        public static SoapAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoapAttribute() { Pointer= p0 };

            value.UseAttribute                              = GetBool(new IntPtr(p + 0x010)); // 024666C2B7B8 0x10 UseAttribute                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProtXmlNamespace                          = GetString(new IntPtr(p + 0x018)); // 024666C2B7D8 0x18 ProtXmlNamespace            ( 000186671E00 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
