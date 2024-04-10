using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalStatusText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PIdolIcons                               000185B73F10 ModelClassListType ChallengeTourIdolIcon[] ChallengeTourIdolIcon[] List<ChallengeTourIdolIcon> Pointer
    // 030 DeckButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 DeckEditButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
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

            value.TotalStatusText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A219238 0x20 TotalStatusText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PIdolIcons                                = GetObjectList<ChallengeTourIdolIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourIdolIcon.FromPointer); // 02466A219258 0x28 PIdolIcons                  ( 000185B73F10 ModelClassListType ChallengeTourIdolIcon[] ChallengeTourIdolIcon[] List<ChallengeTourIdolIcon> Pointer )
            value.DeckButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 02466A219278 0x30 DeckButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DeckEditButton                            = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A219298 0x38 DeckEditButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
