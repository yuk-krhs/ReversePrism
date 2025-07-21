using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 FUnitInfoView                            ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer
    // 030 IdolView                                 ModelClassType FUnitDetailIdolView FUnitDetailIdolView FUnitDetailIdolView Pointer
    // 038 SupportView                              ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer
    // 040 DeckView                                 ModelClassType FUnitDetailDeckView FUnitDetailDeckView FUnitDetailDeckView Pointer
    // 048 ProduceInfoView                          ModelClassType FUnitDetailProduceInfoView FUnitDetailProduceInfoView FUnitDetailProduceInfoView Pointer
    // 050 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 DetectTouchDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 FrameParameter                           ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 068 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FUnitDetailPopupView : DataModel
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
            var value   = new FUnitDetailPopupView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.FUnitInfoView                             = GetObject<FUnitDetailFUnitInfoView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitDetailFUnitInfoView.FromPointer); // 0x28 FUnitInfoView               ( ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer )
            value.IdolView                                  = GetObject<FUnitDetailIdolView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitDetailIdolView.FromPointer); // 0x30 IdolView                    ( ModelClassType FUnitDetailIdolView FUnitDetailIdolView FUnitDetailIdolView Pointer )
            value.SupportView                               = GetObject<FUnitDetailSupportView>(new IntPtr(p + 0x038), ReversePrism.DataModels.FUnitDetailSupportView.FromPointer); // 0x38 SupportView                 ( ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer )
            value.DeckView                                  = GetObject<FUnitDetailDeckView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FUnitDetailDeckView.FromPointer); // 0x40 DeckView                    ( ModelClassType FUnitDetailDeckView FUnitDetailDeckView FUnitDetailDeckView Pointer )
            value.ProduceInfoView                           = GetObject<FUnitDetailProduceInfoView>(new IntPtr(p + 0x048), ReversePrism.DataModels.FUnitDetailProduceInfoView.FromPointer); // 0x48 ProduceInfoView             ( ModelClassType FUnitDetailProduceInfoView FUnitDetailProduceInfoView FUnitDetailProduceInfoView Pointer )
            value.DetectTouchDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 DetectTouchDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.FrameParameter                            = GetObject<PopupFrameParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x60 FrameParameter              ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x68 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
