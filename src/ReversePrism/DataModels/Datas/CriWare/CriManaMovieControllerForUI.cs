using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 Target                                   000186692590 ModelClassType Graphic Graphic Graphic Pointer
    // 0A8 UseOriginalMaterial                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B0 OriginalMaterial                         00018660BDD0 ModelClassType Material Material Material Pointer
    public partial class CriManaMovieControllerForUI : DataModel
    {
        public Graphic?                                 Target                                  { get; set; }
        public bool                                     UseOriginalMaterial                     { get; set; }
        public Material?                                OriginalMaterial                        { get; set; }

        public static CriManaMovieControllerForUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaMovieControllerForUI() { Pointer= p0 };

            value.Target                                    = GetObject<Graphic>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Graphic.FromPointer); // 0245A43FC550 0xA0 Target                      ( 000186692590 ModelClassType Graphic Graphic Graphic Pointer )
            value.UseOriginalMaterial                       = GetBool(new IntPtr(p + 0x0A8)); // 0245A43FC570 0xA8 UseOriginalMaterial         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OriginalMaterial                          = GetObject<Material>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Material.FromPointer); // 0245A43FC590 0xB0 OriginalMaterial            ( 00018660BDD0 ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
