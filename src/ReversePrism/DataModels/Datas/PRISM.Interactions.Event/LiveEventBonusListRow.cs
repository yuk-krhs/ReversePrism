using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CellPrefab                               00018654CB40 ModelClassType LiveEventBonusListCell LiveEventBonusListCell LiveEventBonusListCell Pointer
    // 048 CellArea                                 0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class LiveEventBonusListRow : DataModel
    {
        public LiveEventBonusListCell?                  CellPrefab                              { get; set; }
        public Transform?                               CellArea                                { get; set; }

        public static LiveEventBonusListRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBonusListRow() { Pointer= p0 };

            value.CellPrefab                                = GetObject<LiveEventBonusListCell>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveEventBonusListCell.FromPointer); // 02466B9CC4C8 0x40 CellPrefab                  ( 00018654CB40 ModelClassType LiveEventBonusListCell LiveEventBonusListCell LiveEventBonusListCell Pointer )
            value.CellArea                                  = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 02466B9CC4E8 0x48 CellArea                    ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
