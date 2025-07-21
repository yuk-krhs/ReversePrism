using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 PlaneCollider                            ModelClassType MagicaPlaneCollider MagicaPlaneCollider MagicaPlaneCollider Pointer
    public partial class MagicaBodyParamPlaneColliderController : DataModel
    {
        public MagicaPlaneCollider?                     PlaneCollider                           { get; set; }

        public static MagicaBodyParamPlaneColliderController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaBodyParamPlaneColliderController() { Pointer= p0 };

            value.PlaneCollider                             = GetObject<MagicaPlaneCollider>(new IntPtr(p + 0x040), ReversePrism.DataModels.MagicaPlaneCollider.FromPointer); // 0x40 PlaneCollider               ( ModelClassType MagicaPlaneCollider MagicaPlaneCollider MagicaPlaneCollider Pointer )

            return value;
        }
    }
}
