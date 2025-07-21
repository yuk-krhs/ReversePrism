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
    // 012 InvertZ                                  ModelPrimitiveType bool bool bool Bool
    public partial class InvertVector3Processor : DataModel
    {
        public bool                                     InvertX                                 { get; set; }
        public bool                                     InvertY                                 { get; set; }
        public bool                                     InvertZ                                 { get; set; }

        public static InvertVector3Processor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvertVector3Processor() { Pointer= p0 };

            value.InvertX                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 InvertX                     ( ModelPrimitiveType bool bool bool Bool )
            value.InvertY                                   = GetBool(new IntPtr(p + 0x011)); // 0x11 InvertY                     ( ModelPrimitiveType bool bool bool Bool )
            value.InvertZ                                   = GetBool(new IntPtr(p + 0x012)); // 0x12 InvertZ                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
