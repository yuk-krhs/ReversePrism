using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 LessonPresenter                          ModelClassType LessonPresenter LessonPresenter LessonPresenter Pointer
    // 080 LessonPanel                              ModelClassType LessonPanel LessonPanel LessonPanel Pointer
    // 088 TutorialPresenter                        ModelClassType ProduceTutorialPresenter ProduceTutorialPresenter ProduceTutorialPresenter Pointer
    // 000 sceneLoader                              SceneLoaderAddressable IL2CPP_TYPE_CLASS
    // 090 SoundResources                           ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 098 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.LessonPresenter                           = GetObject<LessonPresenter>(new IntPtr(p + 0x078), ReversePrism.DataModels.LessonPresenter.FromPointer); // 0x78 LessonPresenter             ( ModelClassType LessonPresenter LessonPresenter LessonPresenter Pointer )
            value.LessonPanel                               = GetObject<LessonPanel>(new IntPtr(p + 0x080), ReversePrism.DataModels.LessonPanel.FromPointer); // 0x80 LessonPanel                 ( ModelClassType LessonPanel LessonPanel LessonPanel Pointer )
            value.TutorialPresenter                         = GetObject<ProduceTutorialPresenter>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProduceTutorialPresenter.FromPointer); // 0x88 TutorialPresenter           ( ModelClassType ProduceTutorialPresenter ProduceTutorialPresenter ProduceTutorialPresenter Pointer )
            value.SoundResources                            = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x090), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0x90 SoundResources              ( ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x98 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
