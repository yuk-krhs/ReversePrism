using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalStatusText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PIdolIcons                               ModelClassListType ChallengeTourIdolIcon[] ChallengeTourIdolIcon[] List<ChallengeTourIdolIcon> Pointer
    // 030 DeckButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 038 DeckEditButton                           ModelClassType UIButton UIButton UIButton Pointer
    public partial class ChallengeTourStageUnitDeckPanelView : DataModel
    {
        public UITextMeshProUGUI?                       TotalStatusText                         { get; set; }
        public List<ChallengeTourIdolIcon>?             PIdolIcons                              { get; set; }
        public UIButton?                                DeckButton                              { get; set; }
        public UIButton?                                DeckEditButton                          { get; set; }

        public static ChallengeTourStageUnitDeckPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageUnitDeckPanelView() { Pointer= p0 };

            value.TotalStatusText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TotalStatusText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PIdolIcons                                = GetObjectList<ChallengeTourIdolIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourIdolIcon.FromPointer); // 0x28 PIdolIcons                  ( ModelClassListType ChallengeTourIdolIcon[] ChallengeTourIdolIcon[] List<ChallengeTourIdolIcon> Pointer )
            value.DeckButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 DeckButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DeckEditButton                            = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 DeckEditButton              ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
