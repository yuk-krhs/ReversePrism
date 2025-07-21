using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 FUnitIcon                                ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 038 SettingsObject                           ModelClassType GameObject GameObject GameObject Pointer
    public partial class PvpUnitEditGridViewCell : DataModel
    {
        public FUnitIconView?                           FUnitIcon                               { get; set; }
        public GameObject?                              SettingsObject                          { get; set; }

        public static PvpUnitEditGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditGridViewCell() { Pointer= p0 };

            value.FUnitIcon                                 = GetObject<FUnitIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x30 FUnitIcon                   ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.SettingsObject                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 SettingsObject              ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
