using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Shaders                                  00018659B980 ModelClassType Shaders Shaders Shaders Pointer
    // 020 ComputeShaders                           00018659B4C0 ModelClassType ComputeShaders ComputeShaders ComputeShaders Pointer
    public partial class PostProcessResources
    {
        public Shaders?                                 Shaders                                 { get; set; }
        public ComputeShaders?                          ComputeShaders                          { get; set; }

        public static PostProcessResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessResources();

            value.Shaders                                   = GetObject<Shaders>(new IntPtr(p + 0x018), ReversePrism.DataModels.Shaders.FromPointer); // 02700611F580 0x18 Shaders                     ( 00018659B980 ModelClassType Shaders Shaders Shaders Pointer )
            value.ComputeShaders                            = GetObject<ComputeShaders>(new IntPtr(p + 0x020), ReversePrism.DataModels.ComputeShaders.FromPointer); // 02700611F5A0 0x20 ComputeShaders              ( 00018659B4C0 ModelClassType ComputeShaders ComputeShaders ComputeShaders Pointer )

            return value;
        }
    }
}
