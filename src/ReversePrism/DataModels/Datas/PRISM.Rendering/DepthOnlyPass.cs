using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProfileTag                               string IL2CPP_TYPE_STRING
    // 000 ProfileSampler                           ProfileSampler IL2CPP_TYPE_CLASS
    // 010 DrawPassNames                            ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 018 FilteringSettings                        ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 030 RenderTargetIdentifiers                  ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    public partial class DepthOnlyPass : DataModel
    {
        public List<ShaderTagId>?                       DrawPassNames                           { get; set; }
        public FilteringSettings                        FilteringSettings                       { get; set; }
        public List<RenderTargetIdentifier>?            RenderTargetIdentifiers                 { get; set; }

        public static DepthOnlyPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOnlyPass() { Pointer= p0 };

            value.DrawPassNames                             = GetEnumList<ShaderTagId>(new IntPtr(p + 0x010)); // 0x10 DrawPassNames               ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.FilteringSettings                         = (FilteringSettings)GetInt32(new IntPtr(p + 0x018)); // 0x18 FilteringSettings           ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.RenderTargetIdentifiers                   = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x030)); // 0x30 RenderTargetIdentifiers     ( ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )

            return value;
        }
    }
}
