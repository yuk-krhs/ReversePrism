using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 ProduceIdolTabView                       0001865511C0 ModelClassType ProduceIdolTabView ProduceIdolTabView ProduceIdolTabView Pointer
    // 030 SupportSkillTabView                      0001865F7BE0 ModelClassType SupportSkillTabView SupportSkillTabView SupportSkillTabView Pointer
    // 038 SupportEffectTabView                     0001865F1A10 ModelClassType SupportEffectTabView SupportEffectTabView SupportEffectTabView Pointer
    // 040 ProduceInfoTabView                       00018655B4A0 ModelClassType ProduceInfoTabView ProduceInfoTabView ProduceInfoTabView Pointer
    // 048 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 050 sCharaDetailPopupViewFactory             SerializableInterface`1<ISCharaDetailPopupViewFactory> IL2CPP_TYPE_GENERICINST
    // 058 onShowSelfSCharaDetailPopup              IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 060 onShowFriendSCharaDetailPopup            IObservable`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceEditInformationPopupView
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
            var value   = new ProduceEditInformationPopupView();

            value.ProduceIdolTabView                        = GetObject<ProduceIdolTabView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceIdolTabView.FromPointer); // 0270DA0F9E90 0x28 ProduceIdolTabView          ( 0001865511C0 ModelClassType ProduceIdolTabView ProduceIdolTabView ProduceIdolTabView Pointer )
            value.SupportSkillTabView                       = GetObject<SupportSkillTabView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportSkillTabView.FromPointer); // 0270DA0F9EB0 0x30 SupportSkillTabView         ( 0001865F7BE0 ModelClassType SupportSkillTabView SupportSkillTabView SupportSkillTabView Pointer )
            value.SupportEffectTabView                      = GetObject<SupportEffectTabView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportEffectTabView.FromPointer); // 0270DA0F9ED0 0x38 SupportEffectTabView        ( 0001865F1A10 ModelClassType SupportEffectTabView SupportEffectTabView SupportEffectTabView Pointer )
            value.ProduceInfoTabView                        = GetObject<ProduceInfoTabView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceInfoTabView.FromPointer); // 0270DA0F9EF0 0x40 ProduceInfoTabView          ( 00018655B4A0 ModelClassType ProduceInfoTabView ProduceInfoTabView ProduceInfoTabView Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA0F9F10 0x48 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA0F9F90 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
