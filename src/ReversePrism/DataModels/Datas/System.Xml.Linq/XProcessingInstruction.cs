using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Target                                   000186671BA0 ModelPrimitiveType string string string String
    // 030 Data                                     000186671BA0 ModelPrimitiveType string string string String
    public partial class XProcessingInstruction
    {
        public string                                   Target                                  { get; set; }
        public string                                   Data                                    { get; set; }

        public static XProcessingInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XProcessingInstruction();

            value.Target                                    = GetString(new IntPtr(p + 0x028)); // 0270D886FF60 0x28 Target                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Data                                      = GetString(new IntPtr(p + 0x030)); // 0270D886FF80 0x30 Data                        ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
