using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ChallengeTourInGamePresenter             000186571ED0 ModelClassType ChallengeTourInGamePresenter ChallengeTourInGamePresenter ChallengeTourInGamePresenter Pointer
    // 088 ChallengeTourInGameView                  000186574760 ModelClassType ChallengeTourInGameView ChallengeTourInGameView ChallengeTourInGameView Pointer
    // 090 LessonAuditionSource                     00018651C520 ModelClassType LessonAudition LessonAudition LessonAudition Pointer
    // 098 LessonAuditionScene                      000186660100 ModelEnumType Scene Scene Scene Int32
    // 0A0 ViewParam                                000186574CA0 ModelClassType ChallengeTourInGameViewParam ChallengeTourInGameViewParam ChallengeTourInGameViewParam Pointer
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

            value.ChallengeTourInGamePresenter              = GetObject<ChallengeTourInGamePresenter>(new IntPtr(p + 0x080), ReversePrism.DataModels.ChallengeTourInGamePresenter.FromPointer); // 024665B620B8 0x80 ChallengeTourInGamePresenter ( 000186571ED0 ModelClassType ChallengeTourInGamePresenter ChallengeTourInGamePresenter ChallengeTourInGamePresenter Pointer )
            value.ChallengeTourInGameView                   = GetObject<ChallengeTourInGameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.ChallengeTourInGameView.FromPointer); // 024665B620D8 0x88 ChallengeTourInGameView     ( 000186574760 ModelClassType ChallengeTourInGameView ChallengeTourInGameView ChallengeTourInGameView Pointer )
            value.LessonAuditionSource                      = GetObject<LessonAudition>(new IntPtr(p + 0x090), ReversePrism.DataModels.LessonAudition.FromPointer); // 024665B620F8 0x90 LessonAuditionSource        ( 00018651C520 ModelClassType LessonAudition LessonAudition LessonAudition Pointer )
            value.LessonAuditionScene                       = (Scene)GetInt32(new IntPtr(p + 0x098)); // 024665B62118 0x98 LessonAuditionScene         ( 000186660100 ModelEnumType Scene Scene Scene Int32 )
            value.ViewParam                                 = GetObject<ChallengeTourInGameViewParam>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ChallengeTourInGameViewParam.FromPointer); // 024665B62138 0xA0 ViewParam                   ( 000186574CA0 ModelClassType ChallengeTourInGameViewParam ChallengeTourInGameViewParam ChallengeTourInGameViewParam Pointer )

            return value;
        }
    }
}
