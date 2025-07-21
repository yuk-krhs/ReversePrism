using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ParentCanvasGroup                        ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 HidePosition                             ModelPrimitiveType float float float Single
    // 02C ShowPosition                             ModelPrimitiveType float float float Single
    // 030 WindowRect                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 040 MoveDuration                             ModelPrimitiveType float float float Single
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

            value.ParentCanvasGroup                         = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 ParentCanvasGroup           ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.HidePosition                              = GetSingle(new IntPtr(p + 0x028)); // 0x28 HidePosition                ( ModelPrimitiveType float float float Single )
            value.ShowPosition                              = GetSingle(new IntPtr(p + 0x02C)); // 0x2C ShowPosition                ( ModelPrimitiveType float float float Single )
            value.WindowRect                                = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 WindowRect                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0x38 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.MoveDuration                              = GetSingle(new IntPtr(p + 0x040)); // 0x40 MoveDuration                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
