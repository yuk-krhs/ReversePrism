using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Invalid                                  RendererListParams IL2CPP_TYPE_VALUETYPE
    // 010 CullingResults                           ModelEnumType CullingResults CullingResults CullingResults Int32
    // 020 DrawSettings                             ModelEnumType DrawingSettings DrawingSettings DrawingSettings Int32
    // 0E4 FilteringSettings                        ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 0FC TagName                                  ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 100 IsPassTagName                            ModelPrimitiveType bool bool bool Bool
    // 108 tagValues                                Nullable`1<NativeArray`1<ShaderTagId>> IL2CPP_TYPE_GENERICINST
    // 120 stateBlocks                              Nullable`1<NativeArray`1<RenderStateBlock>> IL2CPP_TYPE_GENERICINST
    public partial class RendererListParams : DataModel
    {
        public CullingResults                           CullingResults                          { get; set; }
        public DrawingSettings                          DrawSettings                            { get; set; }
        public FilteringSettings                        FilteringSettings                       { get; set; }
        public ShaderTagId                              TagName                                 { get; set; }
        public bool                                     IsPassTagName                           { get; set; }

        public static RendererListParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererListParams() { Pointer= p0 };

            value.CullingResults                            = (CullingResults)GetInt32(new IntPtr(p + 0x010)); // 0x10 CullingResults              ( ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.DrawSettings                              = (DrawingSettings)GetInt32(new IntPtr(p + 0x020)); // 0x20 DrawSettings                ( ModelEnumType DrawingSettings DrawingSettings DrawingSettings Int32 )
            value.FilteringSettings                         = (FilteringSettings)GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 FilteringSettings           ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.TagName                                   = (ShaderTagId)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC TagName                     ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.IsPassTagName                             = GetBool(new IntPtr(p + 0x100)); // 0x100 IsPassTagName               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
