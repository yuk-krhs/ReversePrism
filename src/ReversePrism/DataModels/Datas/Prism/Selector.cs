using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectorName                             ModelPrimitiveType string string string String
    // 018 LabelName                                ModelPrimitiveType string string string String
    public partial class Selector : DataModel
    {
        public string                                   SelectorName                            { get; set; }
        public string                                   LabelName                               { get; set; }

        public static Selector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Selector() { Pointer= p0 };

            value.SelectorName                              = GetString(new IntPtr(p + 0x010)); // 0x10 SelectorName                ( ModelPrimitiveType string string string String )
            value.LabelName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 LabelName                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
