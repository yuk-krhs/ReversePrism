using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundObjects                        ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 FadeCanvasGroup                          ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 FadeCurve                                ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 038 FadeTimeDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProducePreparationEpisodeSelectUnitBackgroundView : DataModel
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
            var value   = new ProducePreparationEpisodeSelectUnitBackgroundView() { Pointer= p0 };

            value.BackgroundObjects                         = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 BackgroundObjects           ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.FadeCanvasGroup                           = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 FadeCanvasGroup             ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeCurve                                 = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x30 FadeCurve                   ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.FadeTimeDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0x38 FadeTimeDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
