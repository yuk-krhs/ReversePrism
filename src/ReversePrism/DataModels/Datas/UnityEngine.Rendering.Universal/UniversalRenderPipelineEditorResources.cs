using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Shaders                                  ModelClassType ShaderResources ShaderResources ShaderResources Pointer
    // 020 Materials                                ModelClassType MaterialResources MaterialResources MaterialResources Pointer
    public partial class UniversalRenderPipelineEditorResources : DataModel
    {
        public ShaderResources?                         Shaders                                 { get; set; }
        public MaterialResources?                       Materials                               { get; set; }

        public static UniversalRenderPipelineEditorResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalRenderPipelineEditorResources() { Pointer= p0 };

            value.Shaders                                   = GetObject<ShaderResources>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShaderResources.FromPointer); // 0x18 Shaders                     ( ModelClassType ShaderResources ShaderResources ShaderResources Pointer )
            value.Materials                                 = GetObject<MaterialResources>(new IntPtr(p + 0x020), ReversePrism.DataModels.MaterialResources.FromPointer); // 0x20 Materials                   ( ModelClassType MaterialResources MaterialResources MaterialResources Pointer )

            return value;
        }
    }
}
