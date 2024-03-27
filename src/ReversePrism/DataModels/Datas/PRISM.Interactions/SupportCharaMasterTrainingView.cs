using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoNormal                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 GoMax                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 BtnPieceExchange                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 TxtRequiredPieceAmount                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtPieceAmount                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ImgPieceFillColor                        0001866CCDB0 ModelClassType Image Image Image Pointer
    // 058 GoAlert                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 BtnExecute                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 DiamondLvSelector                        0001866D0710 ModelClassType DiamondLvSelector DiamondLvSelector DiamondLvSelector Pointer
    // 070 PieceIconView                            0001867433E0 ModelClassType PieceIconView PieceIconView PieceIconView Pointer
    // 078 LimitLvView                              00018652DAD0 ModelClassType LimitLvView LimitLvView LimitLvView Pointer
    // 080 Vm                                       0001865E10E0 ModelClassType SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel Pointer
    // 088 toExchange                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 exeMasterTraining                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharaMasterTrainingView
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
            var value   = new SupportCharaMasterTrainingView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA37A120 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoNormal                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA37A140 0x28 GoNormal                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMax                                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA37A160 0x30 GoMax                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnPieceExchange                          = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA37A180 0x38 BtnPieceExchange            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtRequiredPieceAmount                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA37A1A0 0x40 TxtRequiredPieceAmount      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPieceAmount                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA37A1C0 0x48 TxtPieceAmount              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgPieceFillColor                         = GetObject<Image>(new IntPtr(p + 0x050), ReversePrism.DataModels.Image.FromPointer); // 0270DA37A1E0 0x50 ImgPieceFillColor           ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.GoAlert                                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA37A200 0x58 GoAlert                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnExecute                                = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA37A220 0x60 BtnExecute                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DiamondLvSelector                         = GetObject<DiamondLvSelector>(new IntPtr(p + 0x068), ReversePrism.DataModels.DiamondLvSelector.FromPointer); // 0270DA37A240 0x68 DiamondLvSelector           ( 0001866D0710 ModelClassType DiamondLvSelector DiamondLvSelector DiamondLvSelector Pointer )
            value.PieceIconView                             = GetObject<PieceIconView>(new IntPtr(p + 0x070), ReversePrism.DataModels.PieceIconView.FromPointer); // 0270DA37A260 0x70 PieceIconView               ( 0001867433E0 ModelClassType PieceIconView PieceIconView PieceIconView Pointer )
            value.LimitLvView                               = GetObject<LimitLvView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LimitLvView.FromPointer); // 0270DA37A280 0x78 LimitLvView                 ( 00018652DAD0 ModelClassType LimitLvView LimitLvView LimitLvView Pointer )
            value.Vm                                        = GetObject<SupportCharaMasterTrainingViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.SupportCharaMasterTrainingViewModel.FromPointer); // 0270DA37A2A0 0x80 Vm                          ( 0001865E10E0 ModelClassType SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel Pointer )

            return value;
        }
    }
}
