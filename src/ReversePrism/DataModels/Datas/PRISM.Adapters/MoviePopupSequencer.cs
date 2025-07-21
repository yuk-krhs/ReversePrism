using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vm                                       ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer
    // 018 onPlay                                   Subject`1<MoviePlayerModel> IL2CPP_TYPE_GENERICINST
    public partial class MoviePopupSequencer : DataModel
    {
        public MoviePopupViewModel?                     Vm                                      { get; set; }

        public static MoviePopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoviePopupSequencer() { Pointer= p0 };

            value.Vm                                        = GetObject<MoviePopupViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.MoviePopupViewModel.FromPointer); // 0x10 Vm                          ( ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer )

            return value;
        }
    }
}
