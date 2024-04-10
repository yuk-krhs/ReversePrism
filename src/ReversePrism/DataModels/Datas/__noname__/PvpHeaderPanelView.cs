using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 EndDates                                 000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer
    // 040 Rankings                                 000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer
    // 048 EffectText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 EffectIcon                               0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 058 RankingRewardButtons                     000185D17588 ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer
    public partial class PvpHeaderPanelView : DataModel
    {
        public List<UITextMeshProUGUI>?                 EndDates                                { get; set; }
        public List<UITextMeshProUGUI>?                 Rankings                                { get; set; }
        public UITextMeshProUGUI?                       EffectText                              { get; set; }
        public UIImage?                                 EffectIcon                              { get; set; }
        public List<UIButton>?                          RankingRewardButtons                    { get; set; }

        public static PvpHeaderPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpHeaderPanelView() { Pointer= p0 };

            value.EndDates                                  = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A0F5BB8 0x38 EndDates                    ( 000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer )
            value.Rankings                                  = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A0F5BD8 0x40 Rankings                    ( 000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer )
            value.EffectText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A0F5BF8 0x48 EffectText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EffectIcon                                = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 02466A0F5C18 0x50 EffectIcon                  ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.RankingRewardButtons                      = GetObjectList<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466A0F5C38 0x58 RankingRewardButtons        ( 000185D17588 ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer )

            return value;
        }
    }
}
