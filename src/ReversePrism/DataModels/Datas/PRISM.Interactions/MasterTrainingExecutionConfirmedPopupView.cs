using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeDiamonds                           0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 028 AfterDiamonds                            0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 030 LimitLvView                              00018652DAD0 ModelClassType LimitLvView LimitLvView LimitLvView Pointer
    // 038 PieceIconView                            0001867433E0 ModelClassType PieceIconView PieceIconView PieceIconView Pointer
    // 040 TxtPieceCount                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ImgFillColor                             0001866CCDB0 ModelClassType Image Image Image Pointer
    // 050 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class MasterTrainingExecutionConfirmedPopupView : DataModel
    {
        public DiamondDisplay?                          BeforeDiamonds                          { get; set; }
        public DiamondDisplay?                          AfterDiamonds                           { get; set; }
        public LimitLvView?                             LimitLvView                             { get; set; }
        public PieceIconView?                           PieceIconView                           { get; set; }
        public UITextMeshProUGUI?                       TxtPieceCount                           { get; set; }
        public Image?                                   ImgFillColor                            { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static MasterTrainingExecutionConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MasterTrainingExecutionConfirmedPopupView() { Pointer= p0 };

            value.BeforeDiamonds                            = GetObject<DiamondDisplay>(new IntPtr(p + 0x020), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 02466A3527B8 0x20 BeforeDiamonds              ( 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.AfterDiamonds                             = GetObject<DiamondDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 02466A3527D8 0x28 AfterDiamonds               ( 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.LimitLvView                               = GetObject<LimitLvView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitLvView.FromPointer); // 02466A3527F8 0x30 LimitLvView                 ( 00018652DAD0 ModelClassType LimitLvView LimitLvView LimitLvView Pointer )
            value.PieceIconView                             = GetObject<PieceIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PieceIconView.FromPointer); // 02466A352818 0x38 PieceIconView               ( 0001867433E0 ModelClassType PieceIconView PieceIconView PieceIconView Pointer )
            value.TxtPieceCount                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A352838 0x40 TxtPieceCount               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgFillColor                              = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 02466A352858 0x48 ImgFillColor                ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A352898 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
