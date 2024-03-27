using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 FUnitInfoView                            000186548D00 ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer
    // 030 IdolView                                 000186549760 ModelClassType FUnitDetailIdolView FUnitDetailIdolView FUnitDetailIdolView Pointer
    // 038 SupportView                              00018654BE00 ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer
    // 040 DeckView                                 000186547FB0 ModelClassType FUnitDetailDeckView FUnitDetailDeckView FUnitDetailDeckView Pointer
    // 048 ProduceInfoView                          00018654B3D0 ModelClassType FUnitDetailProduceInfoView FUnitDetailProduceInfoView FUnitDetailProduceInfoView Pointer
    // 050 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 DetectTouchDisposable                    0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 FrameParameter                           000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FUnitDetailPopupView
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public FUnitDetailFUnitInfoView?                FUnitInfoView                           { get; set; }
        public FUnitDetailIdolView?                     IdolView                                { get; set; }
        public FUnitDetailSupportView?                  SupportView                             { get; set; }
        public FUnitDetailDeckView?                     DeckView                                { get; set; }
        public FUnitDetailProduceInfoView?              ProduceInfoView                         { get; set; }
        public IDisposable?                             DetectTouchDisposable                   { get; set; }
        public PopupFrameParameter?                     FrameParameter                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FUnitDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailPopupView();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA2C86D8 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.FUnitInfoView                             = GetObject<FUnitDetailFUnitInfoView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitDetailFUnitInfoView.FromPointer); // 0270DA2C86F8 0x28 FUnitInfoView               ( 000186548D00 ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer )
            value.IdolView                                  = GetObject<FUnitDetailIdolView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitDetailIdolView.FromPointer); // 0270DA2C8718 0x30 IdolView                    ( 000186549760 ModelClassType FUnitDetailIdolView FUnitDetailIdolView FUnitDetailIdolView Pointer )
            value.SupportView                               = GetObject<FUnitDetailSupportView>(new IntPtr(p + 0x038), ReversePrism.DataModels.FUnitDetailSupportView.FromPointer); // 0270DA2C8738 0x38 SupportView                 ( 00018654BE00 ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer )
            value.DeckView                                  = GetObject<FUnitDetailDeckView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FUnitDetailDeckView.FromPointer); // 0270DA2C8758 0x40 DeckView                    ( 000186547FB0 ModelClassType FUnitDetailDeckView FUnitDetailDeckView FUnitDetailDeckView Pointer )
            value.ProduceInfoView                           = GetObject<FUnitDetailProduceInfoView>(new IntPtr(p + 0x048), ReversePrism.DataModels.FUnitDetailProduceInfoView.FromPointer); // 0270DA2C8778 0x48 ProduceInfoView             ( 00018654B3D0 ModelClassType FUnitDetailProduceInfoView FUnitDetailProduceInfoView FUnitDetailProduceInfoView Pointer )
            value.DetectTouchDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA2C87B8 0x58 DetectTouchDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.FrameParameter                            = GetObject<PopupFrameParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0270DA2C87D8 0x60 FrameParameter              ( 000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2C87F8 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
