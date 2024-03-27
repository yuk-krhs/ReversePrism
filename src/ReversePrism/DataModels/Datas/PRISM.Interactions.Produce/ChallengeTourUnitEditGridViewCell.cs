using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 FUnitIcon                                00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 038 SettingsObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ChallengeTourUnitEditGridViewCell
    {
        public FUnitIconView?                           FUnitIcon                               { get; set; }
        public GameObject?                              SettingsObject                          { get; set; }

        public static ChallengeTourUnitEditGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditGridViewCell();

            value.FUnitIcon                                 = GetObject<FUnitIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0270DA1D2890 0x30 FUnitIcon                   ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.SettingsObject                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1D28B0 0x38 SettingsObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
