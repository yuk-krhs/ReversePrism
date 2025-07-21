using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_CullingResults                         ModelEnumType CullingResults CullingResults CullingResults Int32
    // 020 M_LightIndex                             ModelPrimitiveType int int int Int32
    // 024 M_UseRenderingLayerMaskTest              ModelPrimitiveType int int int Int32
    // 028 M_SplitData                              ModelEnumType ShadowSplitData ShadowSplitData ShadowSplitData Int32
    // 124 M_ObjectsFilter                          ModelEnumType ShadowObjectsFilter ShadowObjectsFilter ShadowObjectsFilter Int32
    // 128 M_ProjectionType                         ModelEnumType BatchCullingProjectionType BatchCullingProjectionType BatchCullingProjectionType Int32
    public partial class ShadowDrawingSettings : DataModel
    {
        public CullingResults                           M_CullingResults                        { get; set; }
        public int                                      M_LightIndex                            { get; set; }
        public int                                      M_UseRenderingLayerMaskTest             { get; set; }
        public ShadowSplitData                          M_SplitData                             { get; set; }
        public ShadowObjectsFilter                      M_ObjectsFilter                         { get; set; }
        public BatchCullingProjectionType               M_ProjectionType                        { get; set; }

        public static ShadowDrawingSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowDrawingSettings() { Pointer= p0 };

            value.M_CullingResults                          = (CullingResults)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_CullingResults            ( ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.M_LightIndex                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_LightIndex                ( ModelPrimitiveType int int int Int32 )
            value.M_UseRenderingLayerMaskTest               = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_UseRenderingLayerMaskTest ( ModelPrimitiveType int int int Int32 )
            value.M_SplitData                               = (ShadowSplitData)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_SplitData                 ( ModelEnumType ShadowSplitData ShadowSplitData ShadowSplitData Int32 )
            value.M_ObjectsFilter                           = (ShadowObjectsFilter)GetInt32(new IntPtr(p + 0x124)); // 0x124 M_ObjectsFilter             ( ModelEnumType ShadowObjectsFilter ShadowObjectsFilter ShadowObjectsFilter Int32 )
            value.M_ProjectionType                          = (BatchCullingProjectionType)GetInt32(new IntPtr(p + 0x128)); // 0x128 M_ProjectionType            ( ModelEnumType BatchCullingProjectionType BatchCullingProjectionType BatchCullingProjectionType Int32 )

            return value;
        }
    }
}
