using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Tooltip                                  ModelPrimitiveType string string string String
    public partial class NameAndTooltip : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Tooltip                                 { get; set; }

        public static NameAndTooltip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameAndTooltip() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Tooltip                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Tooltip                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
