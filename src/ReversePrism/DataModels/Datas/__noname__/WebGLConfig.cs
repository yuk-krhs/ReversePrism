using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WebworkerPath                            ModelPrimitiveType string string string String
    // 018 HeapSize                                 ModelPrimitiveType int int int Int32
    public partial class WebGLConfig : DataModel
    {
        public string                                   WebworkerPath                           { get; set; }
        public int                                      HeapSize                                { get; set; }

        public static WebGLConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebGLConfig() { Pointer= p0 };

            value.WebworkerPath                             = GetString(new IntPtr(p + 0x010)); // 0x10 WebworkerPath               ( ModelPrimitiveType string string string String )
            value.HeapSize                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HeapSize                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
