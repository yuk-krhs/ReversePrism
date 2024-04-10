using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 Target                                   00018665F3A0 ModelClassType Renderer Renderer Renderer Pointer
    // 0A8 UseOriginalMaterial                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B0 OriginalMaterial                         00018660BDD0 ModelClassType Material Material Material Pointer
    public partial class CriManaMovieController : DataModel
    {
        public Renderer?                                Target                                  { get; set; }
        public bool                                     UseOriginalMaterial                     { get; set; }
        public Material?                                OriginalMaterial                        { get; set; }

        public static CriManaMovieController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaMovieController() { Pointer= p0 };

            value.Target                                    = GetObject<Renderer>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Renderer.FromPointer); // 024664FBDFE8 0xA0 Target                      ( 00018665F3A0 ModelClassType Renderer Renderer Renderer Pointer )
            value.UseOriginalMaterial                       = GetBool(new IntPtr(p + 0x0A8)); // 024664FBE008 0xA8 UseOriginalMaterial         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OriginalMaterial                          = GetObject<Material>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Material.FromPointer); // 024664FBE028 0xB0 OriginalMaterial            ( 00018660BDD0 ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
