using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186680440 ModelClassType ITutorialMovieView ITutorialMovieView ITutorialMovieView Pointer
    // 018 Context                                  0001866813B0 ModelClassType ITutorialSequenceContext ITutorialSequenceContext ITutorialSequenceContext Pointer
    public partial class TutorialMoviePresenter
    {
        public ITutorialMovieView?                      View                                    { get; set; }
        public ITutorialSequenceContext?                Context                                 { get; set; }

        public static TutorialMoviePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialMoviePresenter();

            value.View                                      = GetObject<ITutorialMovieView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialMovieView.FromPointer); // 0270D676DDF0 0x10 View                        ( 000186680440 ModelClassType ITutorialMovieView ITutorialMovieView ITutorialMovieView Pointer )
            value.Context                                   = GetObject<ITutorialSequenceContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.ITutorialSequenceContext.FromPointer); // 0270D676DE10 0x18 Context                     ( 0001866813B0 ModelClassType ITutorialSequenceContext ITutorialSequenceContext ITutorialSequenceContext Pointer )

            return value;
        }
    }
}
