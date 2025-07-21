using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ITutorialMovieView ITutorialMovieView ITutorialMovieView Pointer
    public partial class TutorialMoviePresenter : DataModel
    {
        public ITutorialMovieView?                      View                                    { get; set; }

        public static TutorialMoviePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialMoviePresenter() { Pointer= p0 };

            value.View                                      = GetObject<ITutorialMovieView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialMovieView.FromPointer); // 0x10 View                        ( ModelClassType ITutorialMovieView ITutorialMovieView ITutorialMovieView Pointer )

            return value;
        }
    }
}
