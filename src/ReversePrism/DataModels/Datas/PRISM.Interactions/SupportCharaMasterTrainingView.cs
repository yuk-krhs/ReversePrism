using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoNormal                                 ModelClassType GameObject GameObject GameObject Pointer
    // 030 GoMax                                    ModelClassType GameObject GameObject GameObject Pointer
    // 038 BtnPieceExchange                         ModelClassType UIButton UIButton UIButton Pointer
    // 040 TxtRequiredPieceAmount                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtPieceAmount                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ImgPieceFillColor                        ModelClassType Image Image Image Pointer
    // 058 GoAlert                                  ModelClassType GameObject GameObject GameObject Pointer
    // 060 BtnExecute                               ModelClassType UIButton UIButton UIButton Pointer
    // 068 DiamondLvSelector                        ModelClassType DiamondLvSelector DiamondLvSelector DiamondLvSelector Pointer
    // 070 PieceIconView                            ModelClassType PieceIconView PieceIconView PieceIconView Pointer
    // 078 LimitLvView                              ModelClassType LimitLvView LimitLvView LimitLvView Pointer
    // 080 Vm                                       ModelClassType SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel Pointer
    // 088 toExchange                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 exeMasterTraining                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharaMasterTrainingView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public GameObject?                              GoNormal                                { get; set; }
        public GameObject?                              GoMax                                   { get; set; }
        public UIButton?                                BtnPieceExchange                        { get; set; }
        public UITextMeshProUGUI?                       TxtRequiredPieceAmount                  { get; set; }
        public UITextMeshProUGUI?                       TxtPieceAmount                          { get; set; }
        public Image?                                   ImgPieceFillColor                       { get; set; }
        public GameObject?                              GoAlert                                 { get; set; }
        public UIButton?                                BtnExecute                              { get; set; }
        public DiamondLvSelector?                       DiamondLvSelector                       { get; set; }
        public PieceIconView?                           PieceIconView                           { get; set; }
        public LimitLvView?                             LimitLvView                             { get; set; }
        public SupportCharaMasterTrainingViewModel?     Vm                                      { get; set; }

        public static SupportCharaMasterTrainingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaMasterTrainingView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoNormal                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoNormal                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMax                                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoMax                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnPieceExchange                          = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnPieceExchange            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtRequiredPieceAmount                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtRequiredPieceAmount      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPieceAmount                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtPieceAmount              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgPieceFillColor                         = GetObject<Image>(new IntPtr(p + 0x050), ReversePrism.DataModels.Image.FromPointer); // 0x50 ImgPieceFillColor           ( ModelClassType Image Image Image Pointer )
            value.GoAlert                                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GoAlert                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnExecute                                = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 BtnExecute                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DiamondLvSelector                         = GetObject<DiamondLvSelector>(new IntPtr(p + 0x068), ReversePrism.DataModels.DiamondLvSelector.FromPointer); // 0x68 DiamondLvSelector           ( ModelClassType DiamondLvSelector DiamondLvSelector DiamondLvSelector Pointer )
            value.PieceIconView                             = GetObject<PieceIconView>(new IntPtr(p + 0x070), ReversePrism.DataModels.PieceIconView.FromPointer); // 0x70 PieceIconView               ( ModelClassType PieceIconView PieceIconView PieceIconView Pointer )
            value.LimitLvView                               = GetObject<LimitLvView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LimitLvView.FromPointer); // 0x78 LimitLvView                 ( ModelClassType LimitLvView LimitLvView LimitLvView Pointer )
            value.Vm                                        = GetObject<SupportCharaMasterTrainingViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.SupportCharaMasterTrainingViewModel.FromPointer); // 0x80 Vm                          ( ModelClassType SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel Pointer )

            return value;
        }
    }
}
