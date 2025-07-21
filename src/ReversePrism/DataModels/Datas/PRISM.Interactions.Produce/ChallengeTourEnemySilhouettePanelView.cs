using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ShilhouetteParent                        ModelClassType Transform Transform Transform Pointer
    // 028 InstanceObject                           ModelClassType GameObject GameObject GameObject Pointer
    public partial class ChallengeTourEnemySilhouettePanelView : DataModel
    {
        public Transform?                               ShilhouetteParent                       { get; set; }
        public GameObject?                              InstanceObject                          { get; set; }

        public static ChallengeTourEnemySilhouettePanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourEnemySilhouettePanelView() { Pointer= p0 };

            value.ShilhouetteParent                         = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ShilhouetteParent           ( ModelClassType Transform Transform Transform Pointer )
            value.InstanceObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 InstanceObject              ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
