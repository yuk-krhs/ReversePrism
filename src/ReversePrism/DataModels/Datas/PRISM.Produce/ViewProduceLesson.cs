using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 LessonPresenter                          00018651E0E0 ModelClassType LessonPresenter LessonPresenter LessonPresenter Pointer
    // 088 LessonPanel                              00018651DBE0 ModelClassType LessonPanel LessonPanel LessonPanel Pointer
    // 090 TutorialPresenter                        000186590720 ModelClassType ProduceTutorialPresenter ProduceTutorialPresenter ProduceTutorialPresenter Pointer
    // 000 sceneLoader                              SceneLoaderAddressable IL2CPP_TYPE_CLASS
    // 098 SoundResources                           000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 0A0 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ViewProduceLesson : DataModel
    {
        public LessonPresenter?                         LessonPresenter                         { get; set; }
        public LessonPanel?                             LessonPanel                             { get; set; }
        public ProduceTutorialPresenter?                TutorialPresenter                       { get; set; }
        public MvCutSceneSoundResources?                SoundResources                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ViewProduceLesson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProduceLesson() { Pointer= p0 };

            value.LessonPresenter                           = GetObject<LessonPresenter>(new IntPtr(p + 0x080), ReversePrism.DataModels.LessonPresenter.FromPointer); // 024665DEBC18 0x80 LessonPresenter             ( 00018651E0E0 ModelClassType LessonPresenter LessonPresenter LessonPresenter Pointer )
            value.LessonPanel                               = GetObject<LessonPanel>(new IntPtr(p + 0x088), ReversePrism.DataModels.LessonPanel.FromPointer); // 024665DEBC38 0x88 LessonPanel                 ( 00018651DBE0 ModelClassType LessonPanel LessonPanel LessonPanel Pointer )
            value.TutorialPresenter                         = GetObject<ProduceTutorialPresenter>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceTutorialPresenter.FromPointer); // 024665DEBC58 0x90 TutorialPresenter           ( 000186590720 ModelClassType ProduceTutorialPresenter ProduceTutorialPresenter ProduceTutorialPresenter Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x098), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 024665DEBC98 0x98 SoundResources              ( 000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665DEBCB8 0xA0 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
