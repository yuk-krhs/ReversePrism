using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 MoviePath                                ModelPrimitiveType string string string String
    // 090 Loop                                     ModelPrimitiveType bool bool bool Bool
    // 091 AdditiveMode                             ModelPrimitiveType bool bool bool Bool
    // 092 AdvancedAudio                            ModelPrimitiveType bool bool bool Bool
    // 093 Ambisonics                               ModelPrimitiveType bool bool bool Bool
    // 094 ApplyTargetAlpha                         ModelPrimitiveType bool bool bool Bool
    // 095 UiRenderMode                             ModelPrimitiveType bool bool bool Bool
    // 098 AmbisonicSource                          ModelClassType GameObject GameObject GameObject Pointer
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

            value.MoviePath                                 = GetString(new IntPtr(p + 0x088)); // 0x88 MoviePath                   ( ModelPrimitiveType string string string String )
            value.Loop                                      = GetBool(new IntPtr(p + 0x090)); // 0x90 Loop                        ( ModelPrimitiveType bool bool bool Bool )
            value.AdditiveMode                              = GetBool(new IntPtr(p + 0x091)); // 0x91 AdditiveMode                ( ModelPrimitiveType bool bool bool Bool )
            value.AdvancedAudio                             = GetBool(new IntPtr(p + 0x092)); // 0x92 AdvancedAudio               ( ModelPrimitiveType bool bool bool Bool )
            value.Ambisonics                                = GetBool(new IntPtr(p + 0x093)); // 0x93 Ambisonics                  ( ModelPrimitiveType bool bool bool Bool )
            value.ApplyTargetAlpha                          = GetBool(new IntPtr(p + 0x094)); // 0x94 ApplyTargetAlpha            ( ModelPrimitiveType bool bool bool Bool )
            value.UiRenderMode                              = GetBool(new IntPtr(p + 0x095)); // 0x95 UiRenderMode                ( ModelPrimitiveType bool bool bool Bool )
            value.AmbisonicSource                           = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 AmbisonicSource             ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
