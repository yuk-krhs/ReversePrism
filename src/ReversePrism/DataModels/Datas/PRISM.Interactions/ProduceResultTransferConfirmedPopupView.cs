using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DeckButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 028 FUnitIconView                            ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 030 FIdolIconViews                           ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    // 038 SupportView                              ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer
    // 040 BookIcons                                ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 Amounts                                  ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 050 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceResultTransferConfirmedPopupView : DataModel
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
            var value   = new ProduceResultTransferConfirmedPopupView() { Pointer= p0 };

            value.DeckButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 DeckButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FUnitIconView                             = GetObject<FUnitIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x28 FUnitIconView               ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.FIdolIconViews                            = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x30 FIdolIconViews              ( ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )
            value.SupportView                               = GetObject<FUnitDetailSupportView>(new IntPtr(p + 0x038), ReversePrism.DataModels.FUnitDetailSupportView.FromPointer); // 0x38 SupportView                 ( ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer )
            value.BookIcons                                 = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 BookIcons                   ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Amounts                                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 Amounts                     ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
