using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportCharacterEditView                 ModelClassType SupportCharacterEditView SupportCharacterEditView SupportCharacterEditView Pointer
    // 028 onClosed                                 Subject`1<IReadOnlyList`1<ISupportCharacterStatus>> IL2CPP_TYPE_GENERICINST
    // 030 onClickSCharaIconSubject                 Subject`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 038 onLongPressSCharaIconSubject             Subject`1<ISupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 040 onClickRecommendEditSubject              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 SupportCharas                            ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 050 AllSCharaDatas                           ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 058 ViewModel                                ModelClassType SupportCharaUnitSetupPopupViewModel SupportCharaUnitSetupPopupViewModel SupportCharaUnitSetupPopupViewModel Pointer
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SupportCharaUnitSetupPopupView : DataModel
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
            var value   = new SupportCharaUnitSetupPopupView() { Pointer= p0 };

            value.SupportCharacterEditView                  = GetObject<SupportCharacterEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportCharacterEditView.FromPointer); // 0x20 SupportCharacterEditView    ( ModelClassType SupportCharacterEditView SupportCharacterEditView SupportCharacterEditView Pointer )
            value.SupportCharas                             = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x48 SupportCharas               ( ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.AllSCharaDatas                            = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x50 AllSCharaDatas              ( ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.ViewModel                                 = GetObject<SupportCharaUnitSetupPopupViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.SupportCharaUnitSetupPopupViewModel.FromPointer); // 0x58 ViewModel                   ( ModelClassType SupportCharaUnitSetupPopupViewModel SupportCharaUnitSetupPopupViewModel SupportCharaUnitSetupPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
