using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onTabSelectedSubject                     Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 028 onSwapIconSubject                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ViewModel                                ModelClassType ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel Pointer
    // 038 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 040 FUnitInfoView                            ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer
    // 048 IdolView                                 ModelClassType ProduceResultFUnitDetailIdolView ProduceResultFUnitDetailIdolView ProduceResultFUnitDetailIdolView Pointer
    // 050 SupportView                              ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer
    // 058 DeckView                                 ModelClassType FUnitDetailDeckView FUnitDetailDeckView FUnitDetailDeckView Pointer
    // 060 ProduceInfoView                          ModelClassType FUnitDetailProduceInfoView FUnitDetailProduceInfoView FUnitDetailProduceInfoView Pointer
    // 068 AnimationPlayer                          ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 070 ModalDisplayTime                         ModelPrimitiveType float float float Single
    // 078 ProduceLogButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 080 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 088 TransferButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 090 TransferButtonGrayOutContoller           ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 098 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceResultFUnitDetailPopupView : DataModel
    {
        public ProduceResultFUnitDetailPopupViewModel?  ViewModel                               { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public FUnitDetailFUnitInfoView?                FUnitInfoView                           { get; set; }
        public ProduceResultFUnitDetailIdolView?        IdolView                                { get; set; }
        public FUnitDetailSupportView?                  SupportView                             { get; set; }
        public FUnitDetailDeckView?                     DeckView                                { get; set; }
        public FUnitDetailProduceInfoView?              ProduceInfoView                         { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public float                                    ModalDisplayTime                        { get; set; }
        public UIButton?                                ProduceLogButton                        { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public UIButton?                                TransferButton                          { get; set; }
        public UIGrayOutController?                     TransferButtonGrayOutContoller          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceResultFUnitDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultFUnitDetailPopupView() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ProduceResultFUnitDetailPopupViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceResultFUnitDetailPopupViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x38 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.FUnitInfoView                             = GetObject<FUnitDetailFUnitInfoView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FUnitDetailFUnitInfoView.FromPointer); // 0x40 FUnitInfoView               ( ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer )
            value.IdolView                                  = GetObject<ProduceResultFUnitDetailIdolView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceResultFUnitDetailIdolView.FromPointer); // 0x48 IdolView                    ( ModelClassType ProduceResultFUnitDetailIdolView ProduceResultFUnitDetailIdolView ProduceResultFUnitDetailIdolView Pointer )
            value.SupportView                               = GetObject<FUnitDetailSupportView>(new IntPtr(p + 0x050), ReversePrism.DataModels.FUnitDetailSupportView.FromPointer); // 0x50 SupportView                 ( ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer )
            value.DeckView                                  = GetObject<FUnitDetailDeckView>(new IntPtr(p + 0x058), ReversePrism.DataModels.FUnitDetailDeckView.FromPointer); // 0x58 DeckView                    ( ModelClassType FUnitDetailDeckView FUnitDetailDeckView FUnitDetailDeckView Pointer )
            value.ProduceInfoView                           = GetObject<FUnitDetailProduceInfoView>(new IntPtr(p + 0x060), ReversePrism.DataModels.FUnitDetailProduceInfoView.FromPointer); // 0x60 ProduceInfoView             ( ModelClassType FUnitDetailProduceInfoView FUnitDetailProduceInfoView FUnitDetailProduceInfoView Pointer )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0x68 AnimationPlayer             ( ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.ModalDisplayTime                          = GetSingle(new IntPtr(p + 0x070)); // 0x70 ModalDisplayTime            ( ModelPrimitiveType float float float Single )
            value.ProduceLogButton                          = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 ProduceLogButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TransferButton                            = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0x88 TransferButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TransferButtonGrayOutContoller            = GetObject<UIGrayOutController>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x90 TransferButtonGrayOutContoller ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x98 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
