using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PostPlaybackState                      00018668A020 ModelEnumType PostPlaybackState PostPlaybackState PostPlaybackState Int32
    // 014 M_BoundGameObjectInitialStateIsActive    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_BoundGameObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ActivationMixerPlayable
    {
        public PostPlaybackState                        M_PostPlaybackState                     { get; set; }
        public bool                                     M_BoundGameObjectInitialStateIsActive   { get; set; }
        public GameObject?                              M_BoundGameObject                       { get; set; }

        public static ActivationMixerPlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActivationMixerPlayable();

            value.M_PostPlaybackState                       = (PostPlaybackState)GetInt32(new IntPtr(p + 0x010)); // 0270DB232978 0x10 M_PostPlaybackState         ( 00018668A020 ModelEnumType PostPlaybackState PostPlaybackState PostPlaybackState Int32 )
            value.M_BoundGameObjectInitialStateIsActive     = GetBool(new IntPtr(p + 0x014)); // 0270DB232998 0x14 M_BoundGameObjectInitialStateIsActive ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_BoundGameObject                         = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB2329B8 0x18 M_BoundGameObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
