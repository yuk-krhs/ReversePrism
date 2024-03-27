using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Invalid                                  RendererListParams IL2CPP_TYPE_VALUETYPE
    // 010 CullingResults                           000186665910 ModelEnumType CullingResults CullingResults CullingResults Int32
    // 020 DrawSettings                             0001865C5020 ModelEnumType DrawingSettings DrawingSettings DrawingSettings Int32
    // 0E4 FilteringSettings                        0001865D12A0 ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 0FC TagName                                  000186664640 ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 100 IsPassTagName                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 108 tagValues                                Nullable`1<NativeArray`1<ShaderTagId>> IL2CPP_TYPE_GENERICINST
    // 120 stateBlocks                              Nullable`1<NativeArray`1<RenderStateBlock>> IL2CPP_TYPE_GENERICINST
    public partial class RendererListParams
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
            var value   = new RendererListParams();

            value.CullingResults                            = (CullingResults)GetInt32(new IntPtr(p + 0x010)); // 0270068CED80 0x10 CullingResults              ( 000186665910 ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.DrawSettings                              = (DrawingSettings)GetInt32(new IntPtr(p + 0x020)); // 0270068CEDA0 0x20 DrawSettings                ( 0001865C5020 ModelEnumType DrawingSettings DrawingSettings DrawingSettings Int32 )
            value.FilteringSettings                         = (FilteringSettings)GetInt32(new IntPtr(p + 0x0E4)); // 0270068CEDC0 0xE4 FilteringSettings           ( 0001865D12A0 ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.TagName                                   = (ShaderTagId)GetInt32(new IntPtr(p + 0x0FC)); // 0270068CEDE0 0xFC TagName                     ( 000186664640 ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.IsPassTagName                             = GetBool(new IntPtr(p + 0x100)); // 0270068CEE00 0x100 IsPassTagName               ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
