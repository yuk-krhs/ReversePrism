using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 StatusView                               00018670B5A0 ModelClassType PIdolDetailStatusView PIdolDetailStatusView PIdolDetailStatusView Pointer
    // 030 SkillView                                000186708BB0 ModelClassType PIdolDetailIdolSkillView PIdolDetailIdolSkillView PIdolDetailIdolSkillView Pointer
    // 038 EventView                                0001867086D0 ModelClassType PIdolDetailEventView PIdolDetailEventView PIdolDetailEventView Pointer
    // 040 LiveSkillView                            00018670B100 ModelClassType PIdolDetailPotentialLiveSkillView PIdolDetailPotentialLiveSkillView PIdolDetailPotentialLiveSkillView Pointer
    // 048 CostumeView                              0001867081D0 ModelClassType PIdolDetailCostumeView PIdolDetailCostumeView PIdolDetailCostumeView Pointer
    // 050 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onUpgrading                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Vm                                       00018670A950 ModelClassType PIdolDetailPopupViewModel PIdolDetailPopupViewModel PIdolDetailPopupViewModel Pointer
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PIdolDetailPopupView : DataModel
    {
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public PIdolDetailStatusView?                   StatusView                              { get; set; }
        public PIdolDetailIdolSkillView?                SkillView                               { get; set; }
        public PIdolDetailEventView?                    EventView                               { get; set; }
        public PIdolDetailPotentialLiveSkillView?       LiveSkillView                           { get; set; }
        public PIdolDetailCostumeView?                  CostumeView                             { get; set; }
        public PIdolDetailPopupViewModel?               Vm                                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PIdolDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailPopupView() { Pointer= p0 };

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466A3599A0 0x20 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.StatusView                                = GetObject<PIdolDetailStatusView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PIdolDetailStatusView.FromPointer); // 02466A3599C0 0x28 StatusView                  ( 00018670B5A0 ModelClassType PIdolDetailStatusView PIdolDetailStatusView PIdolDetailStatusView Pointer )
            value.SkillView                                 = GetObject<PIdolDetailIdolSkillView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PIdolDetailIdolSkillView.FromPointer); // 02466A3599E0 0x30 SkillView                   ( 000186708BB0 ModelClassType PIdolDetailIdolSkillView PIdolDetailIdolSkillView PIdolDetailIdolSkillView Pointer )
            value.EventView                                 = GetObject<PIdolDetailEventView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PIdolDetailEventView.FromPointer); // 02466A359A00 0x38 EventView                   ( 0001867086D0 ModelClassType PIdolDetailEventView PIdolDetailEventView PIdolDetailEventView Pointer )
            value.LiveSkillView                             = GetObject<PIdolDetailPotentialLiveSkillView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolDetailPotentialLiveSkillView.FromPointer); // 02466A359A20 0x40 LiveSkillView               ( 00018670B100 ModelClassType PIdolDetailPotentialLiveSkillView PIdolDetailPotentialLiveSkillView PIdolDetailPotentialLiveSkillView Pointer )
            value.CostumeView                               = GetObject<PIdolDetailCostumeView>(new IntPtr(p + 0x048), ReversePrism.DataModels.PIdolDetailCostumeView.FromPointer); // 02466A359A40 0x48 CostumeView                 ( 0001867081D0 ModelClassType PIdolDetailCostumeView PIdolDetailCostumeView PIdolDetailCostumeView Pointer )
            value.Vm                                        = GetObject<PIdolDetailPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.PIdolDetailPopupViewModel.FromPointer); // 02466A359AA0 0x60 Vm                          ( 00018670A950 ModelClassType PIdolDetailPopupViewModel PIdolDetailPopupViewModel PIdolDetailPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A359AC0 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
