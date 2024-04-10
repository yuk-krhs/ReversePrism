using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 AuditionPresenter                        00018671BD40 ModelClassType AuditionPresenter AuditionPresenter AuditionPresenter Pointer
    // 088 AuditionPanel                            00018671B890 ModelClassType AuditionPanel AuditionPanel AuditionPanel Pointer
    // 090 LessonAuditionSource                     00018651C520 ModelClassType LessonAudition LessonAudition LessonAudition Pointer
    // 098 LessonAuditionScene                      000186660100 ModelEnumType Scene Scene Scene Int32
    // 0A0 AuditionViewParam                        00018671E980 ModelClassType AuditionViewParameter AuditionViewParameter AuditionViewParameter Pointer
    // 0A8 TutorialPresenter                        000186590720 ModelClassType ProduceTutorialPresenter ProduceTutorialPresenter ProduceTutorialPresenter Pointer
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

            value.AuditionPresenter                         = GetObject<AuditionPresenter>(new IntPtr(p + 0x080), ReversePrism.DataModels.AuditionPresenter.FromPointer); // 024665DE75F0 0x80 AuditionPresenter           ( 00018671BD40 ModelClassType AuditionPresenter AuditionPresenter AuditionPresenter Pointer )
            value.AuditionPanel                             = GetObject<AuditionPanel>(new IntPtr(p + 0x088), ReversePrism.DataModels.AuditionPanel.FromPointer); // 024665DE7610 0x88 AuditionPanel               ( 00018671B890 ModelClassType AuditionPanel AuditionPanel AuditionPanel Pointer )
            value.LessonAuditionSource                      = GetObject<LessonAudition>(new IntPtr(p + 0x090), ReversePrism.DataModels.LessonAudition.FromPointer); // 024665DE7630 0x90 LessonAuditionSource        ( 00018651C520 ModelClassType LessonAudition LessonAudition LessonAudition Pointer )
            value.LessonAuditionScene                       = (Scene)GetInt32(new IntPtr(p + 0x098)); // 024665DE7650 0x98 LessonAuditionScene         ( 000186660100 ModelEnumType Scene Scene Scene Int32 )
            value.AuditionViewParam                         = GetObject<AuditionViewParameter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AuditionViewParameter.FromPointer); // 024665DE7670 0xA0 AuditionViewParam           ( 00018671E980 ModelClassType AuditionViewParameter AuditionViewParameter AuditionViewParameter Pointer )
            value.TutorialPresenter                         = GetObject<ProduceTutorialPresenter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ProduceTutorialPresenter.FromPointer); // 024665DE7690 0xA8 TutorialPresenter           ( 000186590720 ModelClassType ProduceTutorialPresenter ProduceTutorialPresenter ProduceTutorialPresenter Pointer )

            return value;
        }
    }
}
