using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 BtnPlay                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 PfIdolIconView                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 SCharaIconView                           0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 048 TxtTargetName1                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtTargetName2                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtMovieDescription                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 OnDetailDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class MovieGridCategoryCellView
    {
        public UIButton?                                BtnPlay                                 { get; set; }
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public UITextMeshProUGUI?                       TxtTargetName1                          { get; set; }
        public UITextMeshProUGUI?                       TxtTargetName2                          { get; set; }
        public UITextMeshProUGUI?                       TxtMovieDescription                     { get; set; }
        public IDisposable?                             OnDetailDisposable                      { get; set; }

        public static MovieGridCategoryCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovieGridCategoryCellView();

            value.BtnPlay                                   = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2FF440 0x30 BtnPlay                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DA2FF460 0x38 PfIdolIconView              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270DA2FF480 0x40 SCharaIconView              ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.TxtTargetName1                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FF4A0 0x48 TxtTargetName1              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTargetName2                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FF4C0 0x50 TxtTargetName2              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMovieDescription                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2FF4E0 0x58 TxtMovieDescription         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OnDetailDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA2FF500 0x60 OnDetailDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
