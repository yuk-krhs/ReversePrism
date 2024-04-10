using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoviePlayers                             000185B944F0 ModelClassListType MoviePlayer[] MoviePlayer[] List<MoviePlayer> Pointer
    // 028 IsPlay                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TutorialIntroductionPhasePanelView : DataModel
    {
        public List<MoviePlayer>?                       MoviePlayers                            { get; set; }
        public bool                                     IsPlay                                  { get; set; }

        public static TutorialIntroductionPhasePanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialIntroductionPhasePanelView() { Pointer= p0 };

            value.MoviePlayers                              = GetObjectList<MoviePlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.MoviePlayer.FromPointer); // 02466BFB5620 0x20 MoviePlayers                ( 000185B944F0 ModelClassListType MoviePlayer[] MoviePlayer[] List<MoviePlayer> Pointer )
            value.IsPlay                                    = GetBool(new IntPtr(p + 0x028)); // 02466BFB5640 0x28 IsPlay                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
