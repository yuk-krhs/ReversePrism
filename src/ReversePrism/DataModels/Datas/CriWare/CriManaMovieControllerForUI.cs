using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 Target                                   ModelClassType Graphic Graphic Graphic Pointer
    // 0A8 UseOriginalMaterial                      ModelPrimitiveType bool bool bool Bool
    // 0B0 OriginalMaterial                         ModelClassType Material Material Material Pointer
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

            value.Target                                    = GetObject<Graphic>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Graphic.FromPointer); // 0xA0 Target                      ( ModelClassType Graphic Graphic Graphic Pointer )
            value.UseOriginalMaterial                       = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 UseOriginalMaterial         ( ModelPrimitiveType bool bool bool Bool )
            value.OriginalMaterial                          = GetObject<Material>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Material.FromPointer); // 0xB0 OriginalMaterial            ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
