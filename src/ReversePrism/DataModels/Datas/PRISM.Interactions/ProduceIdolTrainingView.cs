using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 CgNormal                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 GoNormalText                             ModelClassType GameObject GameObject GameObject Pointer
    // 038 CgMaxLv                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 BtnPieceExchange                         ModelClassType UIButton UIButton UIButton Pointer
    // 048 GoAttention                              ModelClassType GameObject GameObject GameObject Pointer
    // 050 BtnTraining                              ModelClassType UIButton UIButton UIButton Pointer
    // 058 TrainingLvSelector                       ModelClassType TrainingLvSelector TrainingLvSelector TrainingLvSelector Pointer
    // 060 PieceIconView                            ModelClassType PieceIconView PieceIconView PieceIconView Pointer
    // 068 PieceGaugeView                           ModelClassType PieceGaugeView PieceGaugeView PieceGaugeView Pointer
    // 070 StatusBonusView                          ModelClassType StatusBonusView StatusBonusView StatusBonusView Pointer
    // 078 OtherBonusView                           ModelClassType OtherBonusView OtherBonusView OtherBonusView Pointer
    // 080 exeTraining                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 088 onPieceExchange                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 Vm                                       ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer
    public partial class ProduceIdolTrainingView : DataModel
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
            var value   = new ProduceIdolTrainingView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgNormal                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CgNormal                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoNormalText                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoNormalText                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CgMaxLv                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CgMaxLv                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.BtnPieceExchange                          = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnPieceExchange            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GoAttention                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GoAttention                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnTraining                               = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 BtnTraining                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TrainingLvSelector                        = GetObject<TrainingLvSelector>(new IntPtr(p + 0x058), ReversePrism.DataModels.TrainingLvSelector.FromPointer); // 0x58 TrainingLvSelector          ( ModelClassType TrainingLvSelector TrainingLvSelector TrainingLvSelector Pointer )
            value.PieceIconView                             = GetObject<PieceIconView>(new IntPtr(p + 0x060), ReversePrism.DataModels.PieceIconView.FromPointer); // 0x60 PieceIconView               ( ModelClassType PieceIconView PieceIconView PieceIconView Pointer )
            value.PieceGaugeView                            = GetObject<PieceGaugeView>(new IntPtr(p + 0x068), ReversePrism.DataModels.PieceGaugeView.FromPointer); // 0x68 PieceGaugeView              ( ModelClassType PieceGaugeView PieceGaugeView PieceGaugeView Pointer )
            value.StatusBonusView                           = GetObject<StatusBonusView>(new IntPtr(p + 0x070), ReversePrism.DataModels.StatusBonusView.FromPointer); // 0x70 StatusBonusView             ( ModelClassType StatusBonusView StatusBonusView StatusBonusView Pointer )
            value.OtherBonusView                            = GetObject<OtherBonusView>(new IntPtr(p + 0x078), ReversePrism.DataModels.OtherBonusView.FromPointer); // 0x78 OtherBonusView              ( ModelClassType OtherBonusView OtherBonusView OtherBonusView Pointer )
            value.Vm                                        = GetObject<ProduceIdolTrainingViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceIdolTrainingViewModel.FromPointer); // 0x90 Vm                          ( ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer )

            return value;
        }
    }
}
