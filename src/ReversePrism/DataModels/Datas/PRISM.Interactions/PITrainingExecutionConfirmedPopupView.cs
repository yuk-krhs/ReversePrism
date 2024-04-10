using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeStar                               00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer
    // 028 AfterStar                                00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer
    // 030 StatusBonusView                          000186586530 ModelClassType StatusBonusView StatusBonusView StatusBonusView Pointer
    // 038 OtherBonusView                           0001866EE810 ModelClassType OtherBonusView OtherBonusView OtherBonusView Pointer
    // 040 PieceIconView                            0001867433E0 ModelClassType PieceIconView PieceIconView PieceIconView Pointer
    // 048 TxtPieceCount                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ImgFillColor                             0001866CCDB0 ModelClassType Image Image Image Pointer
    // 058 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PITrainingExecutionConfirmedPopupView : DataModel
    {
        public StarDisplay?                             BeforeStar                              { get; set; }
        public StarDisplay?                             AfterStar                               { get; set; }
        public StatusBonusView?                         StatusBonusView                         { get; set; }
        public OtherBonusView?                          OtherBonusView                          { get; set; }
        public PieceIconView?                           PieceIconView                           { get; set; }
        public UITextMeshProUGUI?                       TxtPieceCount                           { get; set; }
        public Image?                                   ImgFillColor                            { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PITrainingExecutionConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PITrainingExecutionConfirmedPopupView() { Pointer= p0 };

            value.BeforeStar                                = GetObject<StarDisplay>(new IntPtr(p + 0x020), ReversePrism.DataModels.StarDisplay.FromPointer); // 02466A382B98 0x20 BeforeStar                  ( 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.AfterStar                                 = GetObject<StarDisplay>(new IntPtr(p + 0x028), ReversePrism.DataModels.StarDisplay.FromPointer); // 02466A382BB8 0x28 AfterStar                   ( 00018656D580 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.StatusBonusView                           = GetObject<StatusBonusView>(new IntPtr(p + 0x030), ReversePrism.DataModels.StatusBonusView.FromPointer); // 02466A382BD8 0x30 StatusBonusView             ( 000186586530 ModelClassType StatusBonusView StatusBonusView StatusBonusView Pointer )
            value.OtherBonusView                            = GetObject<OtherBonusView>(new IntPtr(p + 0x038), ReversePrism.DataModels.OtherBonusView.FromPointer); // 02466A382BF8 0x38 OtherBonusView              ( 0001866EE810 ModelClassType OtherBonusView OtherBonusView OtherBonusView Pointer )
            value.PieceIconView                             = GetObject<PieceIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PieceIconView.FromPointer); // 02466A382C18 0x40 PieceIconView               ( 0001867433E0 ModelClassType PieceIconView PieceIconView PieceIconView Pointer )
            value.TxtPieceCount                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A382C38 0x48 TxtPieceCount               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgFillColor                              = GetObject<Image>(new IntPtr(p + 0x050), ReversePrism.DataModels.Image.FromPointer); // 02466A382C58 0x50 ImgFillColor                ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A382C98 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
