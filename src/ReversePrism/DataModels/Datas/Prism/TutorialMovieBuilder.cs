using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType TutorialMovieView TutorialMovieView TutorialMovieView Pointer
    public partial class TutorialMovieBuilder : DataModel
    {
        public TutorialMovieView?                       View                                    { get; set; }

        public static TutorialMovieBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialMovieBuilder() { Pointer= p0 };

            value.View                                      = GetObject<TutorialMovieView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialMovieView.FromPointer); // 0x20 View                        ( ModelClassType TutorialMovieView TutorialMovieView TutorialMovieView Pointer )

            return value;
        }
    }
}
