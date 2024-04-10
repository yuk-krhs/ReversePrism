using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 ChallengeTourInGameView                  000186574760 ModelClassType ChallengeTourInGameView ChallengeTourInGameView ChallengeTourInGameView Pointer
    // 078 ChallengeTourInGameModel                 000186571730 ModelClassType ChallengeTourInGameModel ChallengeTourInGameModel ChallengeTourInGameModel Pointer
    // 080 CacheLessonAuditionSource                00018651C520 ModelClassType LessonAudition LessonAudition LessonAudition Pointer
    public partial class ChallengeTourInGamePresenter : DataModel
    {
        public ChallengeTourInGameView?                 ChallengeTourInGameView                 { get; set; }
        public ChallengeTourInGameModel?                ChallengeTourInGameModel                { get; set; }
        public LessonAudition?                          CacheLessonAuditionSource               { get; set; }

        public static ChallengeTourInGamePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGamePresenter() { Pointer= p0 };

            value.ChallengeTourInGameView                   = GetObject<ChallengeTourInGameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.ChallengeTourInGameView.FromPointer); // 024665B48538 0x70 ChallengeTourInGameView     ( 000186574760 ModelClassType ChallengeTourInGameView ChallengeTourInGameView ChallengeTourInGameView Pointer )
            value.ChallengeTourInGameModel                  = GetObject<ChallengeTourInGameModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChallengeTourInGameModel.FromPointer); // 024665B48558 0x78 ChallengeTourInGameModel    ( 000186571730 ModelClassType ChallengeTourInGameModel ChallengeTourInGameModel ChallengeTourInGameModel Pointer )
            value.CacheLessonAuditionSource                 = GetObject<LessonAudition>(new IntPtr(p + 0x080), ReversePrism.DataModels.LessonAudition.FromPointer); // 024665B48578 0x80 CacheLessonAuditionSource   ( 00018651C520 ModelClassType LessonAudition LessonAudition LessonAudition Pointer )

            return value;
        }
    }
}
