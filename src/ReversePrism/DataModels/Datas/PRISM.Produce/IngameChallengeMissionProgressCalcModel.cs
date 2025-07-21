using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TallyModel                               ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer
    public partial class IngameChallengeMissionProgressCalcModel : DataModel
    {
        public IngameTallyModel?                        TallyModel                              { get; set; }

        public static IngameChallengeMissionProgressCalcModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameChallengeMissionProgressCalcModel() { Pointer= p0 };

            value.TallyModel                                = GetObject<IngameTallyModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngameTallyModel.FromPointer); // 0x10 TallyModel                  ( ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer )

            return value;
        }
    }
}
