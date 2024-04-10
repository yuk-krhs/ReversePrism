using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolIcon                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 BlankObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ChallengeTourIdolIcon : DataModel
    {
        public PFIdolIconView?                          IdolIcon                                { get; set; }
        public GameObject?                              BlankObject                             { get; set; }

        public static ChallengeTourIdolIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourIdolIcon() { Pointer= p0 };

            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 02466A227A30 0x20 IdolIcon                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.BlankObject                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466A227A50 0x28 BlankObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
