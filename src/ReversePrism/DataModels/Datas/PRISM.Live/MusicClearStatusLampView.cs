using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Lamps                                    ModelClassListType MusicClearStatusLamp[] MusicClearStatusLamp[] List<MusicClearStatusLamp> Pointer
    public partial class MusicClearStatusLampView : DataModel
    {
        public List<MusicClearStatusLamp>?              Lamps                                   { get; set; }

        public static MusicClearStatusLampView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicClearStatusLampView() { Pointer= p0 };

            value.Lamps                                     = GetObjectList<MusicClearStatusLamp>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicClearStatusLamp.FromPointer); // 0x20 Lamps                       ( ModelClassListType MusicClearStatusLamp[] MusicClearStatusLamp[] List<MusicClearStatusLamp> Pointer )

            return value;
        }
    }
}
