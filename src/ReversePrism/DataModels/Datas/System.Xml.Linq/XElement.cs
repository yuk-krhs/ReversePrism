using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Name                                     00018657AE30 ModelClassType XName XName XName Pointer
    // 038 LastAttr                                 000186572400 ModelClassType XAttribute XAttribute XAttribute Pointer
    public partial class XElement
    {
        public XName?                                   Name                                    { get; set; }
        public XAttribute?                              LastAttr                                { get; set; }

        public static XElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XElement();

            value.Name                                      = GetObject<XName>(new IntPtr(p + 0x030), ReversePrism.DataModels.XName.FromPointer); // 0270D8882250 0x30 Name                        ( 00018657AE30 ModelClassType XName XName XName Pointer )
            value.LastAttr                                  = GetObject<XAttribute>(new IntPtr(p + 0x038), ReversePrism.DataModels.XAttribute.FromPointer); // 0270D8882270 0x38 LastAttr                    ( 000186572400 ModelClassType XAttribute XAttribute XAttribute Pointer )

            return value;
        }
    }
}
