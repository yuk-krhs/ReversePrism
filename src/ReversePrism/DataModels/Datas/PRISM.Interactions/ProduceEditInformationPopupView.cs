using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 ProduceIdolTabView                       ModelClassType ProduceIdolTabView ProduceIdolTabView ProduceIdolTabView Pointer
    // 030 SupportSkillTabView                      ModelClassType SupportSkillTabView SupportSkillTabView SupportSkillTabView Pointer
    // 038 SupportEffectTabView                     ModelClassType SupportEffectTabView SupportEffectTabView SupportEffectTabView Pointer
    // 040 ProduceInfoTabView                       ModelClassType ProduceInfoTabView ProduceInfoTabView ProduceInfoTabView Pointer
    // 048 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 050 onShowSelfSCharaDetailPopup              IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 058 onShowFriendSCharaDetailPopup            IObservable`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceEditInformationPopupView : DataModel
    {
        public ProduceIdolTabView?                      ProduceIdolTabView                      { get; set; }
        public SupportSkillTabView?                     SupportSkillTabView                     { get; set; }
        public SupportEffectTabView?                    SupportEffectTabView                    { get; set; }
        public ProduceInfoTabView?                      ProduceInfoTabView                      { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceEditInformationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceEditInformationPopupView() { Pointer= p0 };

            value.ProduceIdolTabView                        = GetObject<ProduceIdolTabView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceIdolTabView.FromPointer); // 0x28 ProduceIdolTabView          ( ModelClassType ProduceIdolTabView ProduceIdolTabView ProduceIdolTabView Pointer )
            value.SupportSkillTabView                       = GetObject<SupportSkillTabView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportSkillTabView.FromPointer); // 0x30 SupportSkillTabView         ( ModelClassType SupportSkillTabView SupportSkillTabView SupportSkillTabView Pointer )
            value.SupportEffectTabView                      = GetObject<SupportEffectTabView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportEffectTabView.FromPointer); // 0x38 SupportEffectTabView        ( ModelClassType SupportEffectTabView SupportEffectTabView SupportEffectTabView Pointer )
            value.ProduceInfoTabView                        = GetObject<ProduceInfoTabView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceInfoTabView.FromPointer); // 0x40 ProduceInfoTabView          ( ModelClassType ProduceInfoTabView ProduceInfoTabView ProduceInfoTabView Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x48 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
