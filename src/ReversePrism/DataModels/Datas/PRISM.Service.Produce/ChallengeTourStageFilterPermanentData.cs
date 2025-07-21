using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFilters                                ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class ChallengeTourStageFilterPermanentData : DataModel
    {
        public List<bool>?                              IsFilters                               { get; set; }

        public static ChallengeTourStageFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageFilterPermanentData() { Pointer= p0 };

            value.IsFilters                                 = GetBoolList(new IntPtr(p + 0x010)); // 0x10 IsFilters                   ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
