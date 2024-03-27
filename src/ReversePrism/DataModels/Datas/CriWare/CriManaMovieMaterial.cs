using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 MoviePath                                000186671910 ModelPrimitiveType string string string String
    // 090 Loop                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 091 AdditiveMode                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 092 AdvancedAudio                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 093 Ambisonics                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 094 ApplyTargetAlpha                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 095 UiRenderMode                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 AmbisonicSource                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class CriManaMovieMaterial
    {
        public string                                   MoviePath                               { get; set; }
        public bool                                     Loop                                    { get; set; }
        public bool                                     AdditiveMode                            { get; set; }
        public bool                                     AdvancedAudio                           { get; set; }
        public bool                                     Ambisonics                              { get; set; }
        public bool                                     ApplyTargetAlpha                        { get; set; }
        public bool                                     UiRenderMode                            { get; set; }
        public GameObject?                              AmbisonicSource                         { get; set; }

        public static CriManaMovieMaterial? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaMovieMaterial();

            value.MoviePath                                 = GetString(new IntPtr(p + 0x088)); // 0270043718E0 0x88 MoviePath                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Loop                                      = GetBool(new IntPtr(p + 0x090)); // 027004371900 0x90 Loop                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AdditiveMode                              = GetBool(new IntPtr(p + 0x091)); // 027004371920 0x91 AdditiveMode                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AdvancedAudio                             = GetBool(new IntPtr(p + 0x092)); // 027004371940 0x92 AdvancedAudio               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ambisonics                                = GetBool(new IntPtr(p + 0x093)); // 027004371960 0x93 Ambisonics                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ApplyTargetAlpha                          = GetBool(new IntPtr(p + 0x094)); // 027004371980 0x94 ApplyTargetAlpha            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UiRenderMode                              = GetBool(new IntPtr(p + 0x095)); // 0270043719A0 0x95 UiRenderMode                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AmbisonicSource                           = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270043719C0 0x98 AmbisonicSource             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
