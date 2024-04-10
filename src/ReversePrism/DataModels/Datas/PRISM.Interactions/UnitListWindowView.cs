using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitListWindow                           000186595110 ModelClassType LiveUnitListWindow LiveUnitListWindow LiveUnitListWindow Pointer
    // 028 onCellClicked                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class UnitListWindowView : DataModel
    {
        public LiveUnitListWindow?                      UnitListWindow                          { get; set; }

        public static UnitListWindowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitListWindowView() { Pointer= p0 };

            value.UnitListWindow                            = GetObject<LiveUnitListWindow>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveUnitListWindow.FromPointer); // 02466A2E3A48 0x20 UnitListWindow              ( 000186595110 ModelClassType LiveUnitListWindow LiveUnitListWindow LiveUnitListWindow Pointer )

            return value;
        }
    }
}
