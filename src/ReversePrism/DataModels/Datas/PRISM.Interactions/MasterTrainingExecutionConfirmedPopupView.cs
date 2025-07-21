using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeDiamonds                           ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 028 AfterDiamonds                            ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 030 LimitLvView                              ModelClassType LimitLvView LimitLvView LimitLvView Pointer
    // 038 PieceIconView                            ModelClassType PieceIconView PieceIconView PieceIconView Pointer
    // 040 TxtPieceCount                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ImgFillColor                             ModelClassType Image Image Image Pointer
    // 050 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.BeforeDiamonds                            = GetObject<DiamondDisplay>(new IntPtr(p + 0x020), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 0x20 BeforeDiamonds              ( ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.AfterDiamonds                             = GetObject<DiamondDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 0x28 AfterDiamonds               ( ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.LimitLvView                               = GetObject<LimitLvView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitLvView.FromPointer); // 0x30 LimitLvView                 ( ModelClassType LimitLvView LimitLvView LimitLvView Pointer )
            value.PieceIconView                             = GetObject<PieceIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PieceIconView.FromPointer); // 0x38 PieceIconView               ( ModelClassType PieceIconView PieceIconView PieceIconView Pointer )
            value.TxtPieceCount                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtPieceCount               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgFillColor                              = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 ImgFillColor                ( ModelClassType Image Image Image Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
