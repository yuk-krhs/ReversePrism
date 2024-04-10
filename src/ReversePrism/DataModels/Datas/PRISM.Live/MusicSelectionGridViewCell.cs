using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 JacketIcon                               0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 SongName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class MusicSelectionGridViewCell : DataModel
    {
        public UIRawImage?                              JacketIcon                              { get; set; }
        public UITextMeshProUGUI?                       SongName                                { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static MusicSelectionGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicSelectionGridViewCell() { Pointer= p0 };

            value.JacketIcon                                = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0246651FD1F8 0x40 JacketIcon                  ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SongName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651FD218 0x48 SongName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x050)); // 0246651FD238 0x50 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
