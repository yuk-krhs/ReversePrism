using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GameObject                               0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 018 PostPlayback                             000186689970 ModelEnumType PostPlaybackState PostPlaybackState PostPlaybackState Int32
    // 01C M_InitialState                           0001866891B0 ModelEnumType InitialState InitialState InitialState Int32
    public partial class ActivationControlPlayable : DataModel
    {
        public GameObject?                              GameObject                              { get; set; }
        public PostPlaybackState                        PostPlayback                            { get; set; }
        public InitialState                             M_InitialState                          { get; set; }

        public static ActivationControlPlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActivationControlPlayable() { Pointer= p0 };

            value.GameObject                                = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 02466B2CF530 0x10 GameObject                  ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.PostPlayback                              = (PostPlaybackState)GetInt32(new IntPtr(p + 0x018)); // 02466B2CF550 0x18 PostPlayback                ( 000186689970 ModelEnumType PostPlaybackState PostPlaybackState PostPlaybackState Int32 )
            value.M_InitialState                            = (InitialState)GetInt32(new IntPtr(p + 0x01C)); // 02466B2CF570 0x1C M_InitialState              ( 0001866891B0 ModelEnumType InitialState InitialState InitialState Int32 )

            return value;
        }
    }
}
