using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 UnitLogoImage                            ModelClassType UIImage UIImage UIImage Pointer
    // 048 Title                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ButtonDisposable                         ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
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

            value.UnitLogoImage                             = GetObject<UIImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIImage.FromPointer); // 0x40 UnitLogoImage               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 Title                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 ButtonDisposable            ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x058), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x58 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
