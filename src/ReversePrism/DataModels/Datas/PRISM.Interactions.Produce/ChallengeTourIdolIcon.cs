using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolIcon                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 BlankObject                              ModelClassType GameObject GameObject GameObject Pointer
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

            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 IdolIcon                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.BlankObject                               = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 BlankObject                 ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
