using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ParentCanvasGroup                        000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 HidePosition                             0001866656B0 ModelPrimitiveType float float float Single
    // 02C ShowPosition                             0001866656B0 ModelPrimitiveType float float float Single
    // 030 WindowRect                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 040 MoveDuration                             000186666CB0 ModelPrimitiveType float float float Single
    public partial class SlideWindowBase : DataModel
    {
        public CanvasGroup?                             ParentCanvasGroup                       { get; set; }
        public float                                    HidePosition                            { get; set; }
        public float                                    ShowPosition                            { get; set; }
        public RectTransform?                           WindowRect                              { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public float                                    MoveDuration                            { get; set; }

        public static SlideWindowBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SlideWindowBase() { Pointer= p0 };

            value.ParentCanvasGroup                         = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A2C5A958 0x20 ParentCanvasGroup           ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.HidePosition                              = GetSingle(new IntPtr(p + 0x028)); // 0245A2C5A978 0x28 HidePosition                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ShowPosition                              = GetSingle(new IntPtr(p + 0x02C)); // 0245A2C5A998 0x2C ShowPosition                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.WindowRect                                = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0245A2C5A9B8 0x30 WindowRect                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A2C5A9D8 0x38 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.MoveDuration                              = GetSingle(new IntPtr(p + 0x040)); // 0245A2C5A9F8 0x40 MoveDuration                ( 000186666CB0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
