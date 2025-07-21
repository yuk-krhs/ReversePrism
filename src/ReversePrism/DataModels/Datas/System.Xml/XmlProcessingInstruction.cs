using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Target                                   ModelPrimitiveType string string string String
    // 028 Data                                     ModelPrimitiveType string string string String
    public partial class XmlProcessingInstruction : DataModel
    {
        public string                                   Target                                  { get; set; }
        public string                                   Data                                    { get; set; }

        public static XmlProcessingInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlProcessingInstruction() { Pointer= p0 };

            value.Target                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Target                      ( ModelPrimitiveType string string string String )
            value.Data                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Data                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
