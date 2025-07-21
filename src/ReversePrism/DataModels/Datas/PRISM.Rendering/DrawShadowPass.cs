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
    // 010 ShaderTagIdList                          ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 018 RenderTargetIdentifiers                  ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    public partial class DrawShadowPass : DataModel
    {
        public List<ShaderTagId>?                       ShaderTagIdList                         { get; set; }
        public List<RenderTargetIdentifier>?            RenderTargetIdentifiers                 { get; set; }

        public static DrawShadowPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawShadowPass() { Pointer= p0 };

            value.ShaderTagIdList                           = GetEnumList<ShaderTagId>(new IntPtr(p + 0x010)); // 0x10 ShaderTagIdList             ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.RenderTargetIdentifiers                   = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x018)); // 0x18 RenderTargetIdentifiers     ( ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )

            return value;
        }
    }
}
