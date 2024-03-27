using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoviePlayerViewPrefab                    000186659B50 ModelClassType MoviePlayerView MoviePlayerView MoviePlayerView Pointer
    // 028 MoviePlayerModel                         000186659170 ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer
    // 030 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class CharacterGetEffectOverlayView
    {
        public MoviePlayerView?                         MoviePlayerViewPrefab                   { get; set; }
        public MoviePlayerModel?                        MoviePlayerModel                        { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static CharacterGetEffectOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterGetEffectOverlayView();

            value.MoviePlayerViewPrefab                     = GetObject<MoviePlayerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MoviePlayerView.FromPointer); // 0270DBA13080 0x20 MoviePlayerViewPrefab       ( 000186659B50 ModelClassType MoviePlayerView MoviePlayerView MoviePlayerView Pointer )
            value.MoviePlayerModel                          = GetObject<MoviePlayerModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.MoviePlayerModel.FromPointer); // 0270DBA130A0 0x28 MoviePlayerModel            ( 000186659170 ModelClassType MoviePlayerModel MoviePlayerModel MoviePlayerModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0270DBA130C0 0x30 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
