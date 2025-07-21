using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 ChallengeTourInGamePresenter             ModelClassType ChallengeTourInGamePresenter ChallengeTourInGamePresenter ChallengeTourInGamePresenter Pointer
    // 080 ChallengeTourInGameView                  ModelClassType ChallengeTourInGameView ChallengeTourInGameView ChallengeTourInGameView Pointer
    // 088 LessonAuditionSource                     ModelClassType LessonAudition LessonAudition LessonAudition Pointer
    // 090 LessonAuditionScene                      ModelEnumType Scene Scene Scene Int32
    // 098 ViewParam                                ModelClassType ChallengeTourInGameViewParam ChallengeTourInGameViewParam ChallengeTourInGameViewParam Pointer
    public partial class ViewChallengeTourInGame : DataModel
    {
        public ChallengeTourInGamePresenter?            ChallengeTourInGamePresenter            { get; set; }
        public ChallengeTourInGameView?                 ChallengeTourInGameView                 { get; set; }
        public LessonAudition?                          LessonAuditionSource                    { get; set; }
        public Scene                                    LessonAuditionScene                     { get; set; }
        public ChallengeTourInGameViewParam?            ViewParam                               { get; set; }

        public static ViewChallengeTourInGame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewChallengeTourInGame() { Pointer= p0 };

            value.ChallengeTourInGamePresenter              = GetObject<ChallengeTourInGamePresenter>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChallengeTourInGamePresenter.FromPointer); // 0x78 ChallengeTourInGamePresenter ( ModelClassType ChallengeTourInGamePresenter ChallengeTourInGamePresenter ChallengeTourInGamePresenter Pointer )
            value.ChallengeTourInGameView                   = GetObject<ChallengeTourInGameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.ChallengeTourInGameView.FromPointer); // 0x80 ChallengeTourInGameView     ( ModelClassType ChallengeTourInGameView ChallengeTourInGameView ChallengeTourInGameView Pointer )
            value.LessonAuditionSource                      = GetObject<LessonAudition>(new IntPtr(p + 0x088), ReversePrism.DataModels.LessonAudition.FromPointer); // 0x88 LessonAuditionSource        ( ModelClassType LessonAudition LessonAudition LessonAudition Pointer )
            value.LessonAuditionScene                       = (Scene)GetInt32(new IntPtr(p + 0x090)); // 0x90 LessonAuditionScene         ( ModelEnumType Scene Scene Scene Int32 )
            value.ViewParam                                 = GetObject<ChallengeTourInGameViewParam>(new IntPtr(p + 0x098), ReversePrism.DataModels.ChallengeTourInGameViewParam.FromPointer); // 0x98 ViewParam                   ( ModelClassType ChallengeTourInGameViewParam ChallengeTourInGameViewParam ChallengeTourInGameViewParam Pointer )

            return value;
        }
    }
}
