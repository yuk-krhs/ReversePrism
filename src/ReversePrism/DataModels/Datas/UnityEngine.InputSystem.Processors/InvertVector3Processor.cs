using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InvertX                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 InvertY                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 InvertZ                                  000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class InvertVector3Processor
    {
        public bool                                     InvertX                                 { get; set; }
        public bool                                     InvertY                                 { get; set; }
        public bool                                     InvertZ                                 { get; set; }

        public static InvertVector3Processor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvertVector3Processor();

            value.InvertX                                   = GetBool(new IntPtr(p + 0x010)); // 0270D783B8A8 0x10 InvertX                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.InvertY                                   = GetBool(new IntPtr(p + 0x011)); // 0270D783B8C8 0x11 InvertY                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.InvertZ                                   = GetBool(new IntPtr(p + 0x012)); // 0270D783B8E8 0x12 InvertZ                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
