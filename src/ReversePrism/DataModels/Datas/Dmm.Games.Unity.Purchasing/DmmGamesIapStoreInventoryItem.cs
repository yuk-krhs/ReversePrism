using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Sku>k__BackingField                     Nullable`1<StockKeepingUnit> IL2CPP_TYPE_GENERICINST
    // 050 <ReceiptModel>k__BackingField            Nullable`1<ReceiptModel> IL2CPP_TYPE_GENERICINST
    public partial class DmmGamesIapStoreInventoryItem : DataModel
    {

        public static DmmGamesIapStoreInventoryItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesIapStoreInventoryItem() { Pointer= p0 };


            return value;
        }
    }
}
