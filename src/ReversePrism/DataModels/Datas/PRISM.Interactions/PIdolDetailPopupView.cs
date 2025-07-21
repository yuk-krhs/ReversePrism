using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 IdolSkillTab                             ModelClassType GameObject GameObject GameObject Pointer
    // 030 EventTab                                 ModelClassType GameObject GameObject GameObject Pointer
    // 038 TxtLiveSkillTabSelected                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtLiveSkillTabNormal                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 StatusView                               ModelClassType PIdolDetailStatusView PIdolDetailStatusView PIdolDetailStatusView Pointer
    // 050 SkillView                                ModelClassType PIdolDetailIdolSkillView PIdolDetailIdolSkillView PIdolDetailIdolSkillView Pointer
    // 058 EventView                                ModelClassType PIdolDetailEventView PIdolDetailEventView PIdolDetailEventView Pointer
    // 060 LiveSkillView                            ModelClassType PIdolDetailPotentialLiveSkillView PIdolDetailPotentialLiveSkillView PIdolDetailPotentialLiveSkillView Pointer
    // 068 CostumeView                              ModelClassType PIdolDetailCostumeView PIdolDetailCostumeView PIdolDetailCostumeView Pointer
    // 070 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 Vm                                       ModelClassType PIdolDetailPopupViewModel PIdolDetailPopupViewModel PIdolDetailPopupViewModel Pointer
    // 080 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PIdolDetailPopupView : DataModel
    {
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public GameObject?                              IdolSkillTab                            { get; set; }
        public GameObject?                              EventTab                                { get; set; }
        public UITextMeshProUGUI?                       TxtLiveSkillTabSelected                 { get; set; }
        public UITextMeshProUGUI?                       TxtLiveSkillTabNormal                   { get; set; }
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

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.IdolSkillTab                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 IdolSkillTab                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EventTab                                  = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EventTab                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtLiveSkillTabSelected                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtLiveSkillTabSelected     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLiveSkillTabNormal                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtLiveSkillTabNormal       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StatusView                                = GetObject<PIdolDetailStatusView>(new IntPtr(p + 0x048), ReversePrism.DataModels.PIdolDetailStatusView.FromPointer); // 0x48 StatusView                  ( ModelClassType PIdolDetailStatusView PIdolDetailStatusView PIdolDetailStatusView Pointer )
            value.SkillView                                 = GetObject<PIdolDetailIdolSkillView>(new IntPtr(p + 0x050), ReversePrism.DataModels.PIdolDetailIdolSkillView.FromPointer); // 0x50 SkillView                   ( ModelClassType PIdolDetailIdolSkillView PIdolDetailIdolSkillView PIdolDetailIdolSkillView Pointer )
            value.EventView                                 = GetObject<PIdolDetailEventView>(new IntPtr(p + 0x058), ReversePrism.DataModels.PIdolDetailEventView.FromPointer); // 0x58 EventView                   ( ModelClassType PIdolDetailEventView PIdolDetailEventView PIdolDetailEventView Pointer )
            value.LiveSkillView                             = GetObject<PIdolDetailPotentialLiveSkillView>(new IntPtr(p + 0x060), ReversePrism.DataModels.PIdolDetailPotentialLiveSkillView.FromPointer); // 0x60 LiveSkillView               ( ModelClassType PIdolDetailPotentialLiveSkillView PIdolDetailPotentialLiveSkillView PIdolDetailPotentialLiveSkillView Pointer )
            value.CostumeView                               = GetObject<PIdolDetailCostumeView>(new IntPtr(p + 0x068), ReversePrism.DataModels.PIdolDetailCostumeView.FromPointer); // 0x68 CostumeView                 ( ModelClassType PIdolDetailCostumeView PIdolDetailCostumeView PIdolDetailCostumeView Pointer )
            value.Vm                                        = GetObject<PIdolDetailPopupViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.PIdolDetailPopupViewModel.FromPointer); // 0x78 Vm                          ( ModelClassType PIdolDetailPopupViewModel PIdolDetailPopupViewModel PIdolDetailPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x80 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
