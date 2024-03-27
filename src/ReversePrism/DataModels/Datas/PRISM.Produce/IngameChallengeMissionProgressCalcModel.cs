using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TallyModel                               0001866E90C0 ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer
    public partial class IngameChallengeMissionProgressCalcModel
    {
        public IngameTallyModel?                        TallyModel                              { get; set; }

        public static IngameChallengeMissionProgressCalcModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameChallengeMissionProgressCalcModel();

            value.TallyModel                                = GetObject<IngameTallyModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngameTallyModel.FromPointer); // 0270D5B4CBC8 0x10 TallyModel                  ( 0001866E90C0 ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer )

            return value;
        }
    }
}
