using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lut3DBaker                               ModelClassType ComputeShader ComputeShader ComputeShader Pointer
    // 018 Texture3dLerp                            ModelClassType ComputeShader ComputeShader ComputeShader Pointer
    public partial class ComputeShaders : DataModel
    {
        public ComputeShader?                           Lut3DBaker                              { get; set; }
        public ComputeShader?                           Texture3dLerp                           { get; set; }

        public static ComputeShaders? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComputeShaders() { Pointer= p0 };

            value.Lut3DBaker                                = GetObject<ComputeShader>(new IntPtr(p + 0x010), ReversePrism.DataModels.ComputeShader.FromPointer); // 0x10 Lut3DBaker                  ( ModelClassType ComputeShader ComputeShader ComputeShader Pointer )
            value.Texture3dLerp                             = GetObject<ComputeShader>(new IntPtr(p + 0x018), ReversePrism.DataModels.ComputeShader.FromPointer); // 0x18 Texture3dLerp               ( ModelClassType ComputeShader ComputeShader ComputeShader Pointer )

            return value;
        }
    }
}
