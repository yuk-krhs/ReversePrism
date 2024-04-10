using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 StatusView                               0001866A5620 ModelClassType SCharaDetailStatusView SCharaDetailStatusView SCharaDetailStatusView Pointer
    // 030 SupportEffectView                        0001866A5B40 ModelClassType SCharaDetailSupportEffectView SCharaDetailSupportEffectView SCharaDetailSupportEffectView Pointer
    // 038 PotentialSupportSkillView                0001866A5160 ModelClassType SCharaDetailPotentialSupportSkillView SCharaDetailPotentialSupportSkillView SCharaDetailPotentialSupportSkillView Pointer
    // 040 SupportEventView                         0001866A6020 ModelClassType SCharaDetailSupportEventView SCharaDetailSupportEventView SCharaDetailSupportEventView Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onUpgrading                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Vm                                       0001866A49D0 ModelClassType SCharaDetailPopupViewModel SCharaDetailPopupViewModel SCharaDetailPopupViewModel Pointer
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466A3997F0 0x20 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.StatusView                                = GetObject<SCharaDetailStatusView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaDetailStatusView.FromPointer); // 02466A399810 0x28 StatusView                  ( 0001866A5620 ModelClassType SCharaDetailStatusView SCharaDetailStatusView SCharaDetailStatusView Pointer )
            value.SupportEffectView                         = GetObject<SCharaDetailSupportEffectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaDetailSupportEffectView.FromPointer); // 02466A399830 0x30 SupportEffectView           ( 0001866A5B40 ModelClassType SCharaDetailSupportEffectView SCharaDetailSupportEffectView SCharaDetailSupportEffectView Pointer )
            value.PotentialSupportSkillView                 = GetObject<SCharaDetailPotentialSupportSkillView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaDetailPotentialSupportSkillView.FromPointer); // 02466A399850 0x38 PotentialSupportSkillView   ( 0001866A5160 ModelClassType SCharaDetailPotentialSupportSkillView SCharaDetailPotentialSupportSkillView SCharaDetailPotentialSupportSkillView Pointer )
            value.SupportEventView                          = GetObject<SCharaDetailSupportEventView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaDetailSupportEventView.FromPointer); // 02466A399870 0x40 SupportEventView            ( 0001866A6020 ModelClassType SCharaDetailSupportEventView SCharaDetailSupportEventView SCharaDetailSupportEventView Pointer )
            value.Vm                                        = GetObject<SCharaDetailPopupViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.SCharaDetailPopupViewModel.FromPointer); // 02466A3998D0 0x58 Vm                          ( 0001866A49D0 ModelClassType SCharaDetailPopupViewModel SCharaDetailPopupViewModel SCharaDetailPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A3998F0 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
