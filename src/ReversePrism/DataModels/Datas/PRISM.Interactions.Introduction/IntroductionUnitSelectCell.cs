using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 UnitLogoImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 048 Title                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ButtonDisposable                         0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class IntroductionUnitSelectCell : DataModel
    {
        public UIImage?                                 UnitLogoImage                           { get; set; }
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public IDisposable?                             ButtonDisposable                        { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static IntroductionUnitSelectCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitSelectCell() { Pointer= p0 };

            value.UnitLogoImage                             = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 02466BCDC680 0x40 UnitLogoImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BCDC6A0 0x48 Title                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 02466BCDC6C0 0x50 ButtonDisposable            ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x058), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466BCDC6E0 0x58 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
