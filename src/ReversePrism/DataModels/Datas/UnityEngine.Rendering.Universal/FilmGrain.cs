using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Type                                     ModelClassType FilmGrainLookupParameter FilmGrainLookupParameter FilmGrainLookupParameter Pointer
    // 040 Intensity                                ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 048 Response                                 ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 050 Texture                                  ModelClassType NoInterpTextureParameter NoInterpTextureParameter NoInterpTextureParameter Pointer
    public partial class FilmGrain : DataModel
    {
        public FilmGrainLookupParameter?                Type                                    { get; set; }
        public ClampedFloatParameter?                   Intensity                               { get; set; }
        public ClampedFloatParameter?                   Response                                { get; set; }
        public NoInterpTextureParameter?                Texture                                 { get; set; }

        public static FilmGrain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FilmGrain() { Pointer= p0 };

            value.Type                                      = GetObject<FilmGrainLookupParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FilmGrainLookupParameter.FromPointer); // 0x38 Type                        ( ModelClassType FilmGrainLookupParameter FilmGrainLookupParameter FilmGrainLookupParameter Pointer )
            value.Intensity                                 = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x40 Intensity                   ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Response                                  = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x48 Response                    ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Texture                                   = GetObject<NoInterpTextureParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.NoInterpTextureParameter.FromPointer); // 0x50 Texture                     ( ModelClassType NoInterpTextureParameter NoInterpTextureParameter NoInterpTextureParameter Pointer )

            return value;
        }
    }
}
