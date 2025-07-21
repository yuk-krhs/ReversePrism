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
    // 010 RenderTargetIdentifiers                  ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    public partial class DrawEffectBufferPass : DataModel
    {
        public List<RenderTargetIdentifier>?            RenderTargetIdentifiers                 { get; set; }

        public static DrawEffectBufferPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawEffectBufferPass() { Pointer= p0 };

            value.RenderTargetIdentifiers                   = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x010)); // 0x10 RenderTargetIdentifiers     ( ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )

            return value;
        }
    }
}
