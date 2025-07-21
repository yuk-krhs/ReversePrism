using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 SphereCollider                           ModelClassType MagicaSphereCollider MagicaSphereCollider MagicaSphereCollider Pointer
    // 048 Radius                                   ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    public partial class MagicaBodyParamSphereColliderController : DataModel
    {
        public MagicaSphereCollider?                    SphereCollider                          { get; set; }
        public BodyParamFloatProperty?                  Radius                                  { get; set; }

        public static MagicaBodyParamSphereColliderController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaBodyParamSphereColliderController() { Pointer= p0 };

            value.SphereCollider                            = GetObject<MagicaSphereCollider>(new IntPtr(p + 0x040), ReversePrism.DataModels.MagicaSphereCollider.FromPointer); // 0x40 SphereCollider              ( ModelClassType MagicaSphereCollider MagicaSphereCollider MagicaSphereCollider Pointer )
            value.Radius                                    = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x48 Radius                      ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )

            return value;
        }
    }
}
