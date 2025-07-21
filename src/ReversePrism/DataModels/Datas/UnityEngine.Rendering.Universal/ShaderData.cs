using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Instance                               ShaderData IL2CPP_TYPE_CLASS
    // 010 M_LightDataBuffer                        ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 018 M_LightIndicesBuffer                     ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 020 M_AdditionalLightShadowParamsStructuredBuffer ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 028 M_AdditionalLightShadowSliceMatricesStructuredBuffer ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    public partial class ShaderData : DataModel
    {
        public ComputeBuffer?                           M_LightDataBuffer                       { get; set; }
        public ComputeBuffer?                           M_LightIndicesBuffer                    { get; set; }
        public ComputeBuffer?                           M_AdditionalLightShadowParamsStructuredBuffer { get; set; }
        public ComputeBuffer?                           M_AdditionalLightShadowSliceMatricesStructuredBuffer { get; set; }

        public static ShaderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderData() { Pointer= p0 };

            value.M_LightDataBuffer                         = GetObject<ComputeBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x10 M_LightDataBuffer           ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.M_LightIndicesBuffer                      = GetObject<ComputeBuffer>(new IntPtr(p + 0x018), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x18 M_LightIndicesBuffer        ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.M_AdditionalLightShadowParamsStructuredBuffer = GetObject<ComputeBuffer>(new IntPtr(p + 0x020), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x20 M_AdditionalLightShadowParamsStructuredBuffer ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.M_AdditionalLightShadowSliceMatricesStructuredBuffer = GetObject<ComputeBuffer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x28 M_AdditionalLightShadowSliceMatricesStructuredBuffer ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )

            return value;
        }
    }
}
