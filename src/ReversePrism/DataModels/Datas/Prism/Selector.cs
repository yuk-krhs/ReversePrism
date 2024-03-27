using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectorName                             0001866722E0 ModelPrimitiveType string string string String
    // 018 LabelName                                0001866722E0 ModelPrimitiveType string string string String
    public partial class Selector
    {
        public string                                   SelectorName                            { get; set; }
        public string                                   LabelName                               { get; set; }

        public static Selector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Selector();

            value.SelectorName                              = GetString(new IntPtr(p + 0x010)); // 0270041BF268 0x10 SelectorName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LabelName                                 = GetString(new IntPtr(p + 0x018)); // 0270041BF288 0x18 LabelName                   ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
