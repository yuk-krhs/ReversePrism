using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportCharacterEditView                 0001865E95D0 ModelClassType SupportCharacterEditView SupportCharacterEditView SupportCharacterEditView Pointer
    // 028 supportCharaDetailPopupViewFactory       PopupViewFactory`1<ISCharaDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 030 recommendSupportCharacterPopupFactory    PopupViewFactory`1<IRecommendSupportCharacterPopupView> IL2CPP_TYPE_GENERICINST
    // 038 supportCharaSelectPopupViewFactory       PopupViewFactory`1<IProduceSupportCharaSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 040 onClosed                                 Subject`1<IReadOnlyList`1<ISupportCharacterStatus>> IL2CPP_TYPE_GENERICINST
    // 048 onClickSCharaIconSubject                 Subject`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 050 onLongPressSCharaIconSubject             Subject`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 058 onClickRecommendEditSubject              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 SupportCharas                            000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 068 AllSCharaDatas                           000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 070 ViewModel                                0001865E6E20 ModelClassType SupportCharaUnitSetupPopupViewModel SupportCharaUnitSetupPopupViewModel SupportCharaUnitSetupPopupViewModel Pointer
    // 078 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SupportCharaUnitSetupPopupView
    {
        public SupportCharacterEditView?                SupportCharacterEditView                { get; set; }
        public List<ISupportCharacterStatus>?           SupportCharas                           { get; set; }
        public List<ISupportCharacterStatus>?           AllSCharaDatas                          { get; set; }
        public SupportCharaUnitSetupPopupViewModel?     ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SupportCharaUnitSetupPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUnitSetupPopupView();

            value.SupportCharacterEditView                  = GetObject<SupportCharacterEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportCharacterEditView.FromPointer); // 0270DA12DCA0 0x20 SupportCharacterEditView    ( 0001865E95D0 ModelClassType SupportCharacterEditView SupportCharacterEditView SupportCharacterEditView Pointer )
            value.SupportCharas                             = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270DA12DDA0 0x60 SupportCharas               ( 000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.AllSCharaDatas                            = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270DA12DDC0 0x68 AllSCharaDatas              ( 000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.ViewModel                                 = GetObject<SupportCharaUnitSetupPopupViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.SupportCharaUnitSetupPopupViewModel.FromPointer); // 0270DA12DDE0 0x70 ViewModel                   ( 0001865E6E20 ModelClassType SupportCharaUnitSetupPopupViewModel SupportCharaUnitSetupPopupViewModel SupportCharaUnitSetupPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA12DE00 0x78 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
