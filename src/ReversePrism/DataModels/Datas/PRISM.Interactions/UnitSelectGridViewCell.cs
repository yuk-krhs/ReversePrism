using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 FUnitIconView                            00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    public partial class UnitSelectGridViewCell
    {
        public FUnitIconView?                           FUnitIconView                           { get; set; }

        public static UnitSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitSelectGridViewCell();

            value.FUnitIconView                             = GetObject<FUnitIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0270DA399CD8 0x30 FUnitIconView               ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )

            return value;
        }
    }
}
