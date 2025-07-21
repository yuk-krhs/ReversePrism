using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_UnlimitedRect                          Rect IL2CPP_TYPE_VALUETYPE
    // 010 K_FullNormalizedRect                     ModelEnumType Rect Rect Rect Int32
    // 010 view                                     Stack`1<Matrix4x4> IL2CPP_TYPE_GENERICINST
    // 018 scissor                                  Stack`1<Rect> IL2CPP_TYPE_GENERICINST
    // 020 RenderTexture                            ModelClassListType List`1<RenderTexture> List`1<RenderTexture> List<RenderTexture> Pointer
    // 028 DefaultMaterial                          ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    public partial class DrawParams : DataModel
    {
        public Rect                                     K_FullNormalizedRect                    { get; set; }
        public List<RenderTexture>?                     RenderTexture                           { get; set; }
        public List<Material>?                          DefaultMaterial                         { get; set; }

        public static DrawParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawParams() { Pointer= p0 };

            value.K_FullNormalizedRect                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 K_FullNormalizedRect        ( ModelEnumType Rect Rect Rect Int32 )
            value.RenderTexture                             = GetObjectList<RenderTexture>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x20 RenderTexture               ( ModelClassListType List`1<RenderTexture> List`1<RenderTexture> List<RenderTexture> Pointer )
            value.DefaultMaterial                           = GetObjectList<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 DefaultMaterial             ( ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )

            return value;
        }
    }
}
