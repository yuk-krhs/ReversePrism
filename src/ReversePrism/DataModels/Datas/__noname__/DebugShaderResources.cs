using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DebugReplacementPS                       ModelClassType Shader Shader Shader Pointer
    // 018 HdrDebugViewPS                           ModelClassType Shader Shader Shader Pointer
    public partial class DebugShaderResources : DataModel
    {
        public Shader?                                  DebugReplacementPS                      { get; set; }
        public Shader?                                  HdrDebugViewPS                          { get; set; }

        public static DebugShaderResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugShaderResources() { Pointer= p0 };

            value.DebugReplacementPS                        = GetObject<Shader>(new IntPtr(p + 0x010), ReversePrism.DataModels.Shader.FromPointer); // 0x10 DebugReplacementPS          ( ModelClassType Shader Shader Shader Pointer )
            value.HdrDebugViewPS                            = GetObject<Shader>(new IntPtr(p + 0x018), ReversePrism.DataModels.Shader.FromPointer); // 0x18 HdrDebugViewPS              ( ModelClassType Shader Shader Shader Pointer )

            return value;
        }
    }
}
