using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_Name                                   string IL2CPP_TYPE_STRING
    // 000 beforeRendering                          ProfilingSampler IL2CPP_TYPE_CLASS
    // 008 mainRenderingOpaque                      ProfilingSampler IL2CPP_TYPE_CLASS
    // 010 MainRenderingTransparent                 ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 018 AfterRendering                           ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    public partial class RenderBlock : DataModel
    {
        public ProfilingSampler?                        MainRenderingTransparent                { get; set; }
        public ProfilingSampler?                        AfterRendering                          { get; set; }

        public static RenderBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderBlock() { Pointer= p0 };

            value.MainRenderingTransparent                  = GetObject<ProfilingSampler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x10 MainRenderingTransparent    ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.AfterRendering                            = GetObject<ProfilingSampler>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x18 AfterRendering              ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )

            return value;
        }
    }
}
