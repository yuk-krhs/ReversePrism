using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_ShadowGroup                            ModelPrimitiveType int int int Int32
    // 028 M_ShadowCasters                          ModelClassListType List`1<ShadowCaster2D> List`1<ShadowCaster2D> List<ShadowCaster2D> Pointer
    public partial class ShadowCasterGroup2D : DataModel
    {
        public int                                      M_ShadowGroup                           { get; set; }
        public List<ShadowCaster2D>?                    M_ShadowCasters                         { get; set; }

        public static ShadowCasterGroup2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowCasterGroup2D() { Pointer= p0 };

            value.M_ShadowGroup                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_ShadowGroup               ( ModelPrimitiveType int int int Int32 )
            value.M_ShadowCasters                           = GetObjectList<ShadowCaster2D>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShadowCaster2D.FromPointer); // 0x28 M_ShadowCasters             ( ModelClassListType List`1<ShadowCaster2D> List`1<ShadowCaster2D> List<ShadowCaster2D> Pointer )

            return value;
        }
    }
}
