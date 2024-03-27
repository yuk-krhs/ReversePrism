using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 CgNormal                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 GoNormalText                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 CgMaxLv                                  000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 BtnPieceExchange                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 GoAttention                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 BtnTraining                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 TrainingLvSelector                       00018669F860 ModelClassType TrainingLvSelector TrainingLvSelector TrainingLvSelector Pointer
    // 060 PieceIconView                            0001867433E0 ModelClassType PieceIconView PieceIconView PieceIconView Pointer
    // 068 PieceGaugeView                           000186742CD0 ModelClassType PieceGaugeView PieceGaugeView PieceGaugeView Pointer
    // 070 StatusBonusView                          000186586530 ModelClassType StatusBonusView StatusBonusView StatusBonusView Pointer
    // 078 OtherBonusView                           0001866EE810 ModelClassType OtherBonusView OtherBonusView OtherBonusView Pointer
    // 080 exeTraining                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 088 onPieceExchange                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 Vm                                       000186551E60 ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer
    public partial class ProduceIdolTrainingView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public CanvasGroup?                             CgNormal                                { get; set; }
        public GameObject?                              GoNormalText                            { get; set; }
        public CanvasGroup?                             CgMaxLv                                 { get; set; }
        public UIButton?                                BtnPieceExchange                        { get; set; }
        public GameObject?                              GoAttention                             { get; set; }
        public UIButton?                                BtnTraining                             { get; set; }
        public TrainingLvSelector?                      TrainingLvSelector                      { get; set; }
        public PieceIconView?                           PieceIconView                           { get; set; }
        public PieceGaugeView?                          PieceGaugeView                          { get; set; }
        public StatusBonusView?                         StatusBonusView                         { get; set; }
        public OtherBonusView?                          OtherBonusView                          { get; set; }
        public ProduceIdolTrainingViewModel?            Vm                                      { get; set; }

        public static ProduceIdolTrainingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolTrainingView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA34D100 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgNormal                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA34D120 0x28 CgNormal                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoNormalText                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA34D140 0x30 GoNormalText                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CgMaxLv                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA34D160 0x38 CgMaxLv                     ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnPieceExchange                          = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA34D180 0x40 BtnPieceExchange            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GoAttention                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA34D1A0 0x48 GoAttention                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnTraining                               = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA34D1C0 0x50 BtnTraining                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TrainingLvSelector                        = GetObject<TrainingLvSelector>(new IntPtr(p + 0x058), ReversePrism.DataModels.TrainingLvSelector.FromPointer); // 0270DA34D1E0 0x58 TrainingLvSelector          ( 00018669F860 ModelClassType TrainingLvSelector TrainingLvSelector TrainingLvSelector Pointer )
            value.PieceIconView                             = GetObject<PieceIconView>(new IntPtr(p + 0x060), ReversePrism.DataModels.PieceIconView.FromPointer); // 0270DA34D200 0x60 PieceIconView               ( 0001867433E0 ModelClassType PieceIconView PieceIconView PieceIconView Pointer )
            value.PieceGaugeView                            = GetObject<PieceGaugeView>(new IntPtr(p + 0x068), ReversePrism.DataModels.PieceGaugeView.FromPointer); // 0270DA34D220 0x68 PieceGaugeView              ( 000186742CD0 ModelClassType PieceGaugeView PieceGaugeView PieceGaugeView Pointer )
            value.StatusBonusView                           = GetObject<StatusBonusView>(new IntPtr(p + 0x070), ReversePrism.DataModels.StatusBonusView.FromPointer); // 0270DA34D240 0x70 StatusBonusView             ( 000186586530 ModelClassType StatusBonusView StatusBonusView StatusBonusView Pointer )
            value.OtherBonusView                            = GetObject<OtherBonusView>(new IntPtr(p + 0x078), ReversePrism.DataModels.OtherBonusView.FromPointer); // 0270DA34D260 0x78 OtherBonusView              ( 0001866EE810 ModelClassType OtherBonusView OtherBonusView OtherBonusView Pointer )
            value.Vm                                        = GetObject<ProduceIdolTrainingViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceIdolTrainingViewModel.FromPointer); // 0270DA34D2C0 0x90 Vm                          ( 000186551E60 ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer )

            return value;
        }
    }
}
