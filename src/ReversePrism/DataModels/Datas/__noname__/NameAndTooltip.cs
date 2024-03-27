using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Tooltip                                  0001866722E0 ModelPrimitiveType string string string String
    public partial class NameAndTooltip
    {
        public string                                   Name                                    { get; set; }
        public string                                   Tooltip                                 { get; set; }

        public static NameAndTooltip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameAndTooltip();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D9079C80 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Tooltip                                   = GetString(new IntPtr(p + 0x018)); // 0270D9079CA0 0x18 Tooltip                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
