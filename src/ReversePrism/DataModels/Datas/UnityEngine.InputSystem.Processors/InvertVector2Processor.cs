using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InvertX                                  ModelPrimitiveType bool bool bool Bool
    // 011 InvertY                                  ModelPrimitiveType bool bool bool Bool
    public partial class InvertVector2Processor : DataModel
    {
        public bool                                     InvertX                                 { get; set; }
        public bool                                     InvertY                                 { get; set; }

        public static InvertVector2Processor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvertVector2Processor() { Pointer= p0 };

            value.InvertX                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 InvertX                     ( ModelPrimitiveType bool bool bool Bool )
            value.InvertY                                   = GetBool(new IntPtr(p + 0x011)); // 0x11 InvertY                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
