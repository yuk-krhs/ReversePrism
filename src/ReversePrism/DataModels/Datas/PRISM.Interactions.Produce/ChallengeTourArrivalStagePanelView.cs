using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ArrivalStageText                         ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 GetStarText                              ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    public partial class ChallengeTourArrivalStagePanelView : DataModel
    {
        public TextMeshProUGUI?                         ArrivalStageText                        { get; set; }
        public TextMeshProUGUI?                         GetStarText                             { get; set; }

        public static ChallengeTourArrivalStagePanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourArrivalStagePanelView() { Pointer= p0 };

            value.ArrivalStageText                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x20 ArrivalStageText            ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.GetStarText                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 GetStarText                 ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )

            return value;
        }
    }
}
