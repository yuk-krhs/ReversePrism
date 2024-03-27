using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WebworkerPath                            0001866722E0 ModelPrimitiveType string string string String
    // 018 HeapSize                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class WebGLConfig
    {
        public string                                   WebworkerPath                           { get; set; }
        public int                                      HeapSize                                { get; set; }

        public static WebGLConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebGLConfig();

            value.WebworkerPath                             = GetString(new IntPtr(p + 0x010)); // 0270D117CD68 0x10 WebworkerPath               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HeapSize                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D117CD88 0x18 HeapSize                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
