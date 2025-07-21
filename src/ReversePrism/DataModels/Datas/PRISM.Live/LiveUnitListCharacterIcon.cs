using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 Empty                                    ModelClassType GameObject GameObject GameObject Pointer
    public partial class LiveUnitListCharacterIcon : DataModel
    {
        public PFIdolIconView?                          Icon                                    { get; set; }
        public GameObject?                              Empty                                   { get; set; }

        public static LiveUnitListCharacterIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitListCharacterIcon() { Pointer= p0 };

            value.Icon                                      = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 Icon                        ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.Empty                                     = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 Empty                       ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
