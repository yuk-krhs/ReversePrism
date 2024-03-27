using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 FileName                                 000186672F10 ModelPrimitiveType string string string String
    // 098 FusionLog                                000186672F10 ModelPrimitiveType string string string String
    public partial class FileLoadException
    {
        public string                                   FileName                                { get; set; }
        public string                                   FusionLog                               { get; set; }

        public static FileLoadException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileLoadException();

            value.FileName                                  = GetString(new IntPtr(p + 0x090)); // 0270D6E1AC38 0x90 FileName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.FusionLog                                 = GetString(new IntPtr(p + 0x098)); // 0270D6E1AC58 0x98 FusionLog                   ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
