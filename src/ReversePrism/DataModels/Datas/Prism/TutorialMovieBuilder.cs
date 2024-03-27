using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001866BC130 ModelClassType TutorialMovieView TutorialMovieView TutorialMovieView Pointer
    public partial class TutorialMovieBuilder
    {
        public TutorialMovieView?                       View                                    { get; set; }

        public static TutorialMovieBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialMovieBuilder();

            value.View                                      = GetObject<TutorialMovieView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialMovieView.FromPointer); // 0270DB61F950 0x20 View                        ( 0001866BC130 ModelClassType TutorialMovieView TutorialMovieView TutorialMovieView Pointer )

            return value;
        }
    }
}
