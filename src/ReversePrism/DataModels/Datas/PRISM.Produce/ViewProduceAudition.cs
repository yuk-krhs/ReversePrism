using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 AuditionPresenter                        ModelClassType AuditionPresenter AuditionPresenter AuditionPresenter Pointer
    // 080 AuditionPanel                            ModelClassType AuditionPanel AuditionPanel AuditionPanel Pointer
    // 088 LessonAuditionSource                     ModelClassType LessonAudition LessonAudition LessonAudition Pointer
    // 090 LessonAuditionScene                      ModelEnumType Scene Scene Scene Int32
    // 098 AuditionViewParam                        ModelClassType AuditionViewParameter AuditionViewParameter AuditionViewParameter Pointer
    // 0A0 TutorialPresenter                        ModelClassType ProduceTutorialPresenter ProduceTutorialPresenter ProduceTutorialPresenter Pointer
    public partial class ViewProduceAudition : DataModel
    {
        public AuditionPresenter?                       AuditionPresenter                       { get; set; }
        public AuditionPanel?                           AuditionPanel                           { get; set; }
        public LessonAudition?                          LessonAuditionSource                    { get; set; }
        public Scene                                    LessonAuditionScene                     { get; set; }
        public AuditionViewParameter?                   AuditionViewParam                       { get; set; }
        public ProduceTutorialPresenter?                TutorialPresenter                       { get; set; }

        public static ViewProduceAudition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProduceAudition() { Pointer= p0 };

            value.AuditionPresenter                         = GetObject<AuditionPresenter>(new IntPtr(p + 0x078), ReversePrism.DataModels.AuditionPresenter.FromPointer); // 0x78 AuditionPresenter           ( ModelClassType AuditionPresenter AuditionPresenter AuditionPresenter Pointer )
            value.AuditionPanel                             = GetObject<AuditionPanel>(new IntPtr(p + 0x080), ReversePrism.DataModels.AuditionPanel.FromPointer); // 0x80 AuditionPanel               ( ModelClassType AuditionPanel AuditionPanel AuditionPanel Pointer )
            value.LessonAuditionSource                      = GetObject<LessonAudition>(new IntPtr(p + 0x088), ReversePrism.DataModels.LessonAudition.FromPointer); // 0x88 LessonAuditionSource        ( ModelClassType LessonAudition LessonAudition LessonAudition Pointer )
            value.LessonAuditionScene                       = (Scene)GetInt32(new IntPtr(p + 0x090)); // 0x90 LessonAuditionScene         ( ModelEnumType Scene Scene Scene Int32 )
            value.AuditionViewParam                         = GetObject<AuditionViewParameter>(new IntPtr(p + 0x098), ReversePrism.DataModels.AuditionViewParameter.FromPointer); // 0x98 AuditionViewParam           ( ModelClassType AuditionViewParameter AuditionViewParameter AuditionViewParameter Pointer )
            value.TutorialPresenter                         = GetObject<ProduceTutorialPresenter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ProduceTutorialPresenter.FromPointer); // 0xA0 TutorialPresenter           ( ModelClassType ProduceTutorialPresenter ProduceTutorialPresenter ProduceTutorialPresenter Pointer )

            return value;
        }
    }
}
