using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 FileName                                 ModelPrimitiveType string string string String
    // 098 FusionLog                                ModelPrimitiveType string string string String
    public partial class FileLoadException : DataModel
    {
        public string                                   FileName                                { get; set; }
        public string                                   FusionLog                               { get; set; }

        public static FileLoadException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileLoadException() { Pointer= p0 };

            value.FileName                                  = GetString(new IntPtr(p + 0x090)); // 0x90 FileName                    ( ModelPrimitiveType string string string String )
            value.FusionLog                                 = GetString(new IntPtr(p + 0x098)); // 0x98 FusionLog                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
