using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DeckButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 FUnitIconView                            00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 030 FIdolIconViews                           000185B99CC0 ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    // 038 SupportView                              00018654BE00 ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer
    // 040 BookIcons                                000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 Amounts                                  000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 050 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceResultTransferConfirmedPopupView
    {
        public UIButton?                                DeckButton                              { get; set; }
        public FUnitIconView?                           FUnitIconView                           { get; set; }
        public List<PFIdolIconView>?                    FIdolIconViews                          { get; set; }
        public FUnitDetailSupportView?                  SupportView                             { get; set; }
        public List<GameObject>?                        BookIcons                               { get; set; }
        public List<UITextMeshProUGUI>?                 Amounts                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceResultTransferConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultTransferConfirmedPopupView();

            value.DeckButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA342DF8 0x20 DeckButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FUnitIconView                             = GetObject<FUnitIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0270DA342E18 0x28 FUnitIconView               ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.FIdolIconViews                            = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DA342E38 0x30 FIdolIconViews              ( 000185B99CC0 ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )
            value.SupportView                               = GetObject<FUnitDetailSupportView>(new IntPtr(p + 0x038), ReversePrism.DataModels.FUnitDetailSupportView.FromPointer); // 0270DA342E58 0x38 SupportView                 ( 00018654BE00 ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer )
            value.BookIcons                                 = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA342E78 0x40 BookIcons                   ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Amounts                                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA342E98 0x48 Amounts                     ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA342ED8 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
