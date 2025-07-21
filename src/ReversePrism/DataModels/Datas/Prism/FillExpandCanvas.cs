using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CopyImage                                ModelPrimitiveType bool bool bool Bool
    // 028 CopyMaterial                             ModelClassType Material Material Material Pointer
    // 030 MagX                                     ModelPrimitiveType bool bool bool Bool
    // 031 MagY                                     ModelPrimitiveType bool bool bool Bool
    // 038 OriginalImage                            ModelClassType GameObject GameObject GameObject Pointer
    public partial class FillExpandCanvas : DataModel
    {
        public bool                                     CopyImage                               { get; set; }
        public Material?                                CopyMaterial                            { get; set; }
        public bool                                     MagX                                    { get; set; }
        public bool                                     MagY                                    { get; set; }
        public GameObject?                              OriginalImage                           { get; set; }

        public static FillExpandCanvas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FillExpandCanvas() { Pointer= p0 };

            value.CopyImage                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 CopyImage                   ( ModelPrimitiveType bool bool bool Bool )
            value.CopyMaterial                              = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 CopyMaterial                ( ModelClassType Material Material Material Pointer )
            value.MagX                                      = GetBool(new IntPtr(p + 0x030)); // 0x30 MagX                        ( ModelPrimitiveType bool bool bool Bool )
            value.MagY                                      = GetBool(new IntPtr(p + 0x031)); // 0x31 MagY                        ( ModelPrimitiveType bool bool bool Bool )
            value.OriginalImage                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 OriginalImage               ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
