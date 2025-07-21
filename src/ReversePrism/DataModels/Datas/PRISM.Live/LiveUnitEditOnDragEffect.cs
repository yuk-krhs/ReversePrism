using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ArrowIcon                                ModelClassType GameObject GameObject GameObject Pointer
    // 028 Tween                                    ModelClassType Tween Tween Tween Pointer
    public partial class LiveUnitEditOnDragEffect : DataModel
    {
        public GameObject?                              ArrowIcon                               { get; set; }
        public Tween?                                   Tween                                   { get; set; }

        public static LiveUnitEditOnDragEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditOnDragEffect() { Pointer= p0 };

            value.ArrowIcon                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ArrowIcon                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x028), ReversePrism.DataModels.Tween.FromPointer); // 0x28 Tween                       ( ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
