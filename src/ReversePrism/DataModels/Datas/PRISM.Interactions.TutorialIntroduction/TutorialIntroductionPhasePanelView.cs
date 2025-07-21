using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoviePlayers                             ModelClassListType MoviePlayer[] MoviePlayer[] List<MoviePlayer> Pointer
    // 028 IsPlay                                   ModelPrimitiveType bool bool bool Bool
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

            value.MoviePlayers                              = GetObjectList<MoviePlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0x20 MoviePlayers                ( ModelClassListType MoviePlayer[] MoviePlayer[] List<MoviePlayer> Pointer )
            value.IsPlay                                    = GetBool(new IntPtr(p + 0x028)); // 0x28 IsPlay                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
