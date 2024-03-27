using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 <FilterIDs>k__BackingField               IList`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeItemSortFilterModel
    {

        public static ExchangeItemSortFilterModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeItemSortFilterModel();


            return value;
        }
    }
}
