using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 FileName                                 000186671910 ModelPrimitiveType string string string String
    // 098 FusionLog                                000186671910 ModelPrimitiveType string string string String
    public partial class BadImageFormatException : DataModel
    {
        public string                                   FileName                                { get; set; }
        public string                                   FusionLog                               { get; set; }

        public static BadImageFormatException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadImageFormatException() { Pointer= p0 };

            value.FileName                                  = GetString(new IntPtr(p + 0x090)); // 0246669DF638 0x90 FileName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.FusionLog                                 = GetString(new IntPtr(p + 0x098)); // 0246669DF658 0x98 FusionLog                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
