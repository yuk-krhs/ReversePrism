using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 StatusView                               ModelClassType SCharaDetailStatusView SCharaDetailStatusView SCharaDetailStatusView Pointer
    // 030 SupportEffectView                        ModelClassType SCharaDetailSupportEffectView SCharaDetailSupportEffectView SCharaDetailSupportEffectView Pointer
    // 038 PotentialSupportSkillView                ModelClassType SCharaDetailPotentialSupportSkillView SCharaDetailPotentialSupportSkillView SCharaDetailPotentialSupportSkillView Pointer
    // 040 SupportEventView                         ModelClassType SCharaDetailSupportEventView SCharaDetailSupportEventView SCharaDetailSupportEventView Pointer
    // 048 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 Vm                                       ModelClassType SCharaDetailPopupViewModel SCharaDetailPopupViewModel SCharaDetailPopupViewModel Pointer
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SCharaDetailPopupView : DataModel
    {
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public SCharaDetailStatusView?                  StatusView                              { get; set; }
        public SCharaDetailSupportEffectView?           SupportEffectView                       { get; set; }
        public SCharaDetailPotentialSupportSkillView?   PotentialSupportSkillView               { get; set; }
        public SCharaDetailSupportEventView?            SupportEventView                        { get; set; }
        public SCharaDetailPopupViewModel?              Vm                                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SCharaDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaDetailPopupView() { Pointer= p0 };

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.StatusView                                = GetObject<SCharaDetailStatusView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaDetailStatusView.FromPointer); // 0x28 StatusView                  ( ModelClassType SCharaDetailStatusView SCharaDetailStatusView SCharaDetailStatusView Pointer )
            value.SupportEffectView                         = GetObject<SCharaDetailSupportEffectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaDetailSupportEffectView.FromPointer); // 0x30 SupportEffectView           ( ModelClassType SCharaDetailSupportEffectView SCharaDetailSupportEffectView SCharaDetailSupportEffectView Pointer )
            value.PotentialSupportSkillView                 = GetObject<SCharaDetailPotentialSupportSkillView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaDetailPotentialSupportSkillView.FromPointer); // 0x38 PotentialSupportSkillView   ( ModelClassType SCharaDetailPotentialSupportSkillView SCharaDetailPotentialSupportSkillView SCharaDetailPotentialSupportSkillView Pointer )
            value.SupportEventView                          = GetObject<SCharaDetailSupportEventView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaDetailSupportEventView.FromPointer); // 0x40 SupportEventView            ( ModelClassType SCharaDetailSupportEventView SCharaDetailSupportEventView SCharaDetailSupportEventView Pointer )
            value.Vm                                        = GetObject<SCharaDetailPopupViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.SCharaDetailPopupViewModel.FromPointer); // 0x50 Vm                          ( ModelClassType SCharaDetailPopupViewModel SCharaDetailPopupViewModel SCharaDetailPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
