using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 410 IsImageInline                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MultiColumnHeaderColumnIcon
    {
        public bool                                     IsImageInline                           { get; set; }

        public static MultiColumnHeaderColumnIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnHeaderColumnIcon();

            value.IsImageInline                             = GetBool(new IntPtr(p + 0x410)); // 0270068A1270 0x410 IsImageInline               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
