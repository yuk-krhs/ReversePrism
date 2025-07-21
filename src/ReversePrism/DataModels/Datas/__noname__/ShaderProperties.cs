using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BoxMin                                   int IL2CPP_TYPE_I4
    // 004 BoxMax                                   int IL2CPP_TYPE_I4
    // 008 ProbePosition                            int IL2CPP_TYPE_I4
    // 00C MipScaleOffset                           int IL2CPP_TYPE_I4
    // 010 Count                                    ModelPrimitiveType int int int Int32
    // 014 Atlas                                    ModelPrimitiveType int int int Int32
    public partial class ShaderProperties : DataModel
    {
        public int                                      Count                                   { get; set; }
        public int                                      Atlas                                   { get; set; }

        public static ShaderProperties? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderProperties() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Atlas                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Atlas                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
