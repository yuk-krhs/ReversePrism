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
    public partial class UnitListWindowView
    {
        public LiveUnitListWindow?                      UnitListWindow                          { get; set; }

        public static UnitListWindowView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitListWindowView();

            value.UnitListWindow                            = GetObject<LiveUnitListWindow>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveUnitListWindow.FromPointer); // 0270DA290478 0x20 UnitListWindow              ( 000186595110 ModelClassType LiveUnitListWindow LiveUnitListWindow LiveUnitListWindow Pointer )

            return value;
        }
    }
}
