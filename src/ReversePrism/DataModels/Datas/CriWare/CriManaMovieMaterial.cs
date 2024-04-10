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
    public partial class CriManaMovieMaterial : DataModel
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
            var value   = new CriManaMovieMaterial() { Pointer= p0 };

            value.MoviePath                                 = GetString(new IntPtr(p + 0x088)); // 0245A43FC2C0 0x88 MoviePath                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Loop                                      = GetBool(new IntPtr(p + 0x090)); // 0245A43FC2E0 0x90 Loop                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AdditiveMode                              = GetBool(new IntPtr(p + 0x091)); // 0245A43FC300 0x91 AdditiveMode                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AdvancedAudio                             = GetBool(new IntPtr(p + 0x092)); // 0245A43FC320 0x92 AdvancedAudio               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ambisonics                                = GetBool(new IntPtr(p + 0x093)); // 0245A43FC340 0x93 Ambisonics                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ApplyTargetAlpha                          = GetBool(new IntPtr(p + 0x094)); // 0245A43FC360 0x94 ApplyTargetAlpha            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UiRenderMode                              = GetBool(new IntPtr(p + 0x095)); // 0245A43FC380 0x95 UiRenderMode                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AmbisonicSource                           = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0245A43FC3A0 0x98 AmbisonicSource             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
