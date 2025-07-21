using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CommandBuffer                            ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 018 CullResults                              ModelEnumType CullingResults CullingResults CullingResults Int32
    // 028 CameraData                               ModelEnumType CameraData CameraData CameraData Int32
    // 238 LightData                                ModelEnumType LightData LightData LightData Int32
    // 260 ShadowData                               ModelEnumType ShadowData ShadowData ShadowData Int32
    // 2B0 PostProcessingData                       ModelEnumType PostProcessingData PostProcessingData PostProcessingData Int32
    // 2BC SupportsDynamicBatching                  ModelPrimitiveType bool bool bool Bool
    // 2C0 PerObjectData                            ModelEnumType PerObjectData PerObjectData PerObjectData Int32
    // 2C4 PostProcessingEnabled                    ModelPrimitiveType bool bool bool Bool
    public partial class RenderingData : DataModel
    {
        public CommandBuffer?                           CommandBuffer                           { get; set; }
        public CullingResults                           CullResults                             { get; set; }
        public CameraData                               CameraData                              { get; set; }
        public LightData                                LightData                               { get; set; }
        public ShadowData                               ShadowData                              { get; set; }
        public PostProcessingData                       PostProcessingData                      { get; set; }
        public bool                                     SupportsDynamicBatching                 { get; set; }
        public PerObjectData                            PerObjectData                           { get; set; }
        public bool                                     PostProcessingEnabled                   { get; set; }

        public static RenderingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderingData() { Pointer= p0 };

            value.CommandBuffer                             = GetObject<CommandBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x10 CommandBuffer               ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.CullResults                               = (CullingResults)GetInt32(new IntPtr(p + 0x018)); // 0x18 CullResults                 ( ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.CameraData                                = (CameraData)GetInt32(new IntPtr(p + 0x028)); // 0x28 CameraData                  ( ModelEnumType CameraData CameraData CameraData Int32 )
            value.LightData                                 = (LightData)GetInt32(new IntPtr(p + 0x238)); // 0x238 LightData                   ( ModelEnumType LightData LightData LightData Int32 )
            value.ShadowData                                = (ShadowData)GetInt32(new IntPtr(p + 0x260)); // 0x260 ShadowData                  ( ModelEnumType ShadowData ShadowData ShadowData Int32 )
            value.PostProcessingData                        = (PostProcessingData)GetInt32(new IntPtr(p + 0x2B0)); // 0x2B0 PostProcessingData          ( ModelEnumType PostProcessingData PostProcessingData PostProcessingData Int32 )
            value.SupportsDynamicBatching                   = GetBool(new IntPtr(p + 0x2BC)); // 0x2BC SupportsDynamicBatching     ( ModelPrimitiveType bool bool bool Bool )
            value.PerObjectData                             = (PerObjectData)GetInt32(new IntPtr(p + 0x2C0)); // 0x2C0 PerObjectData               ( ModelEnumType PerObjectData PerObjectData PerObjectData Int32 )
            value.PostProcessingEnabled                     = GetBool(new IntPtr(p + 0x2C4)); // 0x2C4 PostProcessingEnabled       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
