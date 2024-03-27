using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Handle                                 000186640190 ModelEnumType PlayableHandle PlayableHandle PlayableHandle Int32
    // 000 m_NullPlayable                           AnimationMotionXToDeltaPlayable IL2CPP_TYPE_VALUETYPE
    public partial class AnimationMotionXToDeltaPlayable
    {
        public PlayableHandle                           M_Handle                                { get; set; }

        public static AnimationMotionXToDeltaPlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationMotionXToDeltaPlayable();

            value.M_Handle                                  = (PlayableHandle)GetInt32(new IntPtr(p + 0x010)); // 02700223C308 0x10 M_Handle                    ( 000186640190 ModelEnumType PlayableHandle PlayableHandle PlayableHandle Int32 )

            return value;
        }
    }
}
