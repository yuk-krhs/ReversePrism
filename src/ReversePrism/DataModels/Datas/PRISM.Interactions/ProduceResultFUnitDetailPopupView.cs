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
    // 030 ViewModel                                000186574670 ModelClassType ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel Pointer
    // 038 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 040 FUnitInfoView                            000186548D00 ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer
    // 048 IdolView                                 000186572FB0 ModelClassType ProduceResultFUnitDetailIdolView ProduceResultFUnitDetailIdolView ProduceResultFUnitDetailIdolView Pointer
    // 050 SupportView                              00018654BE00 ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer
    // 058 DeckView                                 000186547FB0 ModelClassType FUnitDetailDeckView FUnitDetailDeckView FUnitDetailDeckView Pointer
    // 060 ProduceInfoView                          00018654B3D0 ModelClassType FUnitDetailProduceInfoView FUnitDetailProduceInfoView FUnitDetailProduceInfoView Pointer
    // 068 AnimationPlayer                          0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 070 LiceSkillDetailPopupViewFactory          00018657C770 ModelClassType LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory Pointer
    // 078 ProduceLogPopupViewFactory               00018655E460 ModelClassType ProduceLogPopupViewFactory ProduceLogPopupViewFactory ProduceLogPopupViewFactory Pointer
    // 080 ModalDisplayTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 088 ProduceLogButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 098 TransferButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0A0 TransferButtonGrayOutContoller           0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 0A8 TransferFactory                          0001865772F0 ModelClassType ProduceResultTransferConfirmedPopupViewFactory ProduceResultTransferConfirmedPopupViewFactory ProduceResultTransferConfirmedPopupViewFactory Pointer
    // 0B0 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceResultFUnitDetailPopupView
    {
        public ProduceResultFUnitDetailPopupViewModel?  ViewModel                               { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public FUnitDetailFUnitInfoView?                FUnitInfoView                           { get; set; }
        public ProduceResultFUnitDetailIdolView?        IdolView                                { get; set; }
        public FUnitDetailSupportView?                  SupportView                             { get; set; }
        public FUnitDetailDeckView?                     DeckView                                { get; set; }
        public FUnitDetailProduceInfoView?              ProduceInfoView                         { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public LiveSkillDetailPopupViewFactory?         LiceSkillDetailPopupViewFactory         { get; set; }
        public ProduceLogPopupViewFactory?              ProduceLogPopupViewFactory              { get; set; }
        public float                                    ModalDisplayTime                        { get; set; }
        public UIButton?                                ProduceLogButton                        { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public UIButton?                                TransferButton                          { get; set; }
        public UIGrayOutController?                     TransferButtonGrayOutContoller          { get; set; }
        public ProduceResultTransferConfirmedPopupViewFactory? TransferFactory                         { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceResultFUnitDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultFUnitDetailPopupView();

            value.ViewModel                                 = GetObject<ProduceResultFUnitDetailPopupViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceResultFUnitDetailPopupViewModel.FromPointer); // 0270DA2E9C30 0x30 ViewModel                   ( 000186574670 ModelClassType ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel ProduceResultFUnitDetailPopupViewModel Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA2E9C50 0x38 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.FUnitInfoView                             = GetObject<FUnitDetailFUnitInfoView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FUnitDetailFUnitInfoView.FromPointer); // 0270DA2E9C70 0x40 FUnitInfoView               ( 000186548D00 ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer )
            value.IdolView                                  = GetObject<ProduceResultFUnitDetailIdolView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceResultFUnitDetailIdolView.FromPointer); // 0270DA2E9C90 0x48 IdolView                    ( 000186572FB0 ModelClassType ProduceResultFUnitDetailIdolView ProduceResultFUnitDetailIdolView ProduceResultFUnitDetailIdolView Pointer )
            value.SupportView                               = GetObject<FUnitDetailSupportView>(new IntPtr(p + 0x050), ReversePrism.DataModels.FUnitDetailSupportView.FromPointer); // 0270DA2E9CB0 0x50 SupportView                 ( 00018654BE00 ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer )
            value.DeckView                                  = GetObject<FUnitDetailDeckView>(new IntPtr(p + 0x058), ReversePrism.DataModels.FUnitDetailDeckView.FromPointer); // 0270DA2E9CD0 0x58 DeckView                    ( 000186547FB0 ModelClassType FUnitDetailDeckView FUnitDetailDeckView FUnitDetailDeckView Pointer )
            value.ProduceInfoView                           = GetObject<FUnitDetailProduceInfoView>(new IntPtr(p + 0x060), ReversePrism.DataModels.FUnitDetailProduceInfoView.FromPointer); // 0270DA2E9CF0 0x60 ProduceInfoView             ( 00018654B3D0 ModelClassType FUnitDetailProduceInfoView FUnitDetailProduceInfoView FUnitDetailProduceInfoView Pointer )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0270DA2E9D10 0x68 AnimationPlayer             ( 0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.LiceSkillDetailPopupViewFactory           = GetObject<LiveSkillDetailPopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveSkillDetailPopupViewFactory.FromPointer); // 0270DA2E9D30 0x70 LiceSkillDetailPopupViewFactory ( 00018657C770 ModelClassType LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory Pointer )
            value.ProduceLogPopupViewFactory                = GetObject<ProduceLogPopupViewFactory>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceLogPopupViewFactory.FromPointer); // 0270DA2E9D50 0x78 ProduceLogPopupViewFactory  ( 00018655E460 ModelClassType ProduceLogPopupViewFactory ProduceLogPopupViewFactory ProduceLogPopupViewFactory Pointer )
            value.ModalDisplayTime                          = GetSingle(new IntPtr(p + 0x080)); // 0270DA2E9D70 0x80 ModalDisplayTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ProduceLogButton                          = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2E9D90 0x88 ProduceLogButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2E9DB0 0x90 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TransferButton                            = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2E9DD0 0x98 TransferButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TransferButtonGrayOutContoller            = GetObject<UIGrayOutController>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA2E9DF0 0xA0 TransferButtonGrayOutContoller ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.TransferFactory                           = GetObject<ProduceResultTransferConfirmedPopupViewFactory>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ProduceResultTransferConfirmedPopupViewFactory.FromPointer); // 0270DA2E9E10 0xA8 TransferFactory             ( 0001865772F0 ModelClassType ProduceResultTransferConfirmedPopupViewFactory ProduceResultTransferConfirmedPopupViewFactory ProduceResultTransferConfirmedPopupViewFactory Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2E9E30 0xB0 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
