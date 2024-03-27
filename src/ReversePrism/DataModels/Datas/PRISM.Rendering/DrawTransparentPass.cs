using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 profileTag                               string IL2CPP_TYPE_STRING
    // 008 profileSampler                           ProfileSampler IL2CPP_TYPE_CLASS
    // 010 RenderTargetIdentifiers                  000185CA0AC8 ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    // 018 DrawPassNames                            000185D086A8 ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 020 FilteringSettings                        0001865D1080 ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    public partial class DrawTransparentPass
    {
        public List<RenderTargetIdentifier>?            RenderTargetIdentifiers                 { get; set; }
        public List<ShaderTagId>?                       DrawPassNames                           { get; set; }
        public FilteringSettings                        FilteringSettings                       { get; set; }

        public static DrawTransparentPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawTransparentPass();

            value.RenderTargetIdentifiers                   = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x010)); // 0270D0AC1C80 0x10 RenderTargetIdentifiers     ( 000185CA0AC8 ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )
            value.DrawPassNames                             = GetEnumList<ShaderTagId>(new IntPtr(p + 0x018)); // 0270D0AC1CA0 0x18 DrawPassNames               ( 000185D086A8 ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.FilteringSettings                         = (FilteringSettings)GetInt32(new IntPtr(p + 0x020)); // 0270D0AC1CC0 0x20 FilteringSettings           ( 0001865D1080 ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )

            return value;
        }
    }
}
