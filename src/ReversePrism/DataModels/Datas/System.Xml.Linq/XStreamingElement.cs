using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     00018657AE30 ModelClassType XName XName XName Pointer
    // 018 content                                  <object> IL2CPP_TYPE_OBJECT
    public partial class XStreamingElement
    {
        public XName?                                   Name                                    { get; set; }

        public static XStreamingElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XStreamingElement();

            value.Name                                      = GetObject<XName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XName.FromPointer); // 0270DBC17A88 0x10 Name                        ( 00018657AE30 ModelClassType XName XName XName Pointer )

            return value;
        }
    }
}
