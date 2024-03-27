using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Next                                     000186572400 ModelClassType XAttribute XAttribute XAttribute Pointer
    // 028 Name                                     00018657AE30 ModelClassType XName XName XName Pointer
    // 030 Value                                    000186671BA0 ModelPrimitiveType string string string String
    public partial class XAttribute
    {
        public XAttribute?                              Next                                    { get; set; }
        public XName?                                   Name                                    { get; set; }
        public string                                   Value                                   { get; set; }

        public static XAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XAttribute();

            value.Next                                      = GetObject<XAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.XAttribute.FromPointer); // 0270D8881090 0x20 Next                        ( 000186572400 ModelClassType XAttribute XAttribute XAttribute Pointer )
            value.Name                                      = GetObject<XName>(new IntPtr(p + 0x028), ReversePrism.DataModels.XName.FromPointer); // 0270D88810B0 0x28 Name                        ( 00018657AE30 ModelClassType XName XName XName Pointer )
            value.Value                                     = GetString(new IntPtr(p + 0x030)); // 0270D88810D0 0x30 Value                       ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
