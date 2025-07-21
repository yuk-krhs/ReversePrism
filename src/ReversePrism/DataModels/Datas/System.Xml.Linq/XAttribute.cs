using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Next                                     ModelClassType XAttribute XAttribute XAttribute Pointer
    // 028 Name                                     ModelClassType XName XName XName Pointer
    // 030 Value                                    ModelPrimitiveType string string string String
    public partial class XAttribute : DataModel
    {
        public XAttribute?                              Next                                    { get; set; }
        public XName?                                   Name                                    { get; set; }
        public string                                   Value                                   { get; set; }

        public static XAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XAttribute() { Pointer= p0 };

            value.Next                                      = GetObject<XAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.XAttribute.FromPointer); // 0x20 Next                        ( ModelClassType XAttribute XAttribute XAttribute Pointer )
            value.Name                                      = GetObject<XName>(new IntPtr(p + 0x028), ReversePrism.DataModels.XName.FromPointer); // 0x28 Name                        ( ModelClassType XName XName XName Pointer )
            value.Value                                     = GetString(new IntPtr(p + 0x030)); // 0x30 Value                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
