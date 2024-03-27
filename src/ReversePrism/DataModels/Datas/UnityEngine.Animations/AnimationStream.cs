using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AnimatorBindingsVersion                000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 018 constant                                 <int> IL2CPP_TYPE_I
    // 020 input                                    <int> IL2CPP_TYPE_I
    // 028 output                                   <int> IL2CPP_TYPE_I
    // 030 workspace                                <int> IL2CPP_TYPE_I
    // 038 inputStreamAccessor                      <int> IL2CPP_TYPE_I
    // 040 animationHandleBinder                    <int> IL2CPP_TYPE_I
    public partial class AnimationStream
    {
        public uint                                     M_AnimatorBindingsVersion               { get; set; }

        public static AnimationStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationStream();

            value.M_AnimatorBindingsVersion                 = GetUInt32(new IntPtr(p + 0x010)); // 027002247678 0x10 M_AnimatorBindingsVersion   ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
