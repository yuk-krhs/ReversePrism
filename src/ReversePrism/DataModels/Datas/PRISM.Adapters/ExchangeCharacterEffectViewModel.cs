using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MovieModel                               000186659170 ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer
    public partial class ExchangeCharacterEffectViewModel
    {
        public MoviePlayerModel?                        MovieModel                              { get; set; }

        public static ExchangeCharacterEffectViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeCharacterEffectViewModel();

            value.MovieModel                                = GetObject<MoviePlayerModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.MoviePlayerModel.FromPointer); // 0270D62B62D0 0x10 MovieModel                  ( 000186659170 ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer )

            return value;
        }
    }
}
