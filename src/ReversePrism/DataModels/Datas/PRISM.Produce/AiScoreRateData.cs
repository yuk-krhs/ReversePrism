using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AiScoreRateSetList                       ModelClassListType List`1<AiScoreRateSet> List`1<AiScoreRateSet> List<AiScoreRateSet> Pointer
    public partial class AiScoreRateData : DataModel
    {
        public List<AiScoreRateSet>?                    AiScoreRateSetList                      { get; set; }

        public static AiScoreRateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiScoreRateData() { Pointer= p0 };

            value.AiScoreRateSetList                        = GetObjectList<AiScoreRateSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiScoreRateSet.FromPointer); // 0x10 AiScoreRateSetList          ( ModelClassListType List`1<AiScoreRateSet> List`1<AiScoreRateSet> List<AiScoreRateSet> Pointer )

            return value;
        }
    }
}
