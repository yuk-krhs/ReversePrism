using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Skus                                     ModelEnumListType List`1<StockKeepingUnit> List`1<StockKeepingUnit> List<StockKeepingUnit> Pointer
    public partial class StockKeepingUnitListModel : DataModel
    {
        public List<StockKeepingUnit>?                  Skus                                    { get; set; }

        public static StockKeepingUnitListModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StockKeepingUnitListModel() { Pointer= p0 };

            value.Skus                                      = GetEnumList<StockKeepingUnit>(new IntPtr(p + 0x010)); // 0x10 Skus                        ( ModelEnumListType List`1<StockKeepingUnit> List`1<StockKeepingUnit> List<StockKeepingUnit> Pointer )

            return value;
        }
    }
}
