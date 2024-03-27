using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundObjects                        000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 FadeCanvasGroup                          000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 FadeCurve                                000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 038 FadeTimeDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProducePreparationEpisodeSelectUnitBackgroundView
    {
        public List<GameObject>?                        BackgroundObjects                       { get; set; }
        public CanvasGroup?                             FadeCanvasGroup                         { get; set; }
        public AnimationCurve?                          FadeCurve                               { get; set; }
        public IDisposable?                             FadeTimeDisposable                      { get; set; }

        public static ProducePreparationEpisodeSelectUnitBackgroundView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectUnitBackgroundView();

            value.BackgroundObjects                         = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D59F0B08 0x20 BackgroundObjects           ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.FadeCanvasGroup                           = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D59F0B28 0x28 FadeCanvasGroup             ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeCurve                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D59F0B48 0x30 FadeCurve                   ( 000186586CC0 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.FadeTimeDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D59F0B68 0x38 FadeTimeDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
