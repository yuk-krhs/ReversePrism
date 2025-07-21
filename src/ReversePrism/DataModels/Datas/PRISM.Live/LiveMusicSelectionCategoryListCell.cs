using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 TabIcon                                  ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 SpaceLine                                ModelClassType GameObject GameObject GameObject Pointer
    // 050 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveMusicSelectionCategoryListCell : DataModel
    {
        public UIRawImage?                              TabIcon                                 { get; set; }
        public GameObject?                              SpaceLine                               { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LiveMusicSelectionCategoryListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionCategoryListCell() { Pointer= p0 };

            value.TabIcon                                   = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x40 TabIcon                     ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SpaceLine                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 SpaceLine                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x050)); // 0x50 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
