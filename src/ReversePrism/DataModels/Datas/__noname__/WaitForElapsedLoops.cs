using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        0001866BF4B0 ModelClassType Tween Tween Tween Pointer
    // 018 ElapsedLoops                             0001865F4260 ModelPrimitiveType int int int Int32
    public partial class WaitForElapsedLoops
    {
        public Tween?                                   T                                       { get; set; }
        public int                                      ElapsedLoops                            { get; set; }

        public static WaitForElapsedLoops? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForElapsedLoops();

            value.T                                         = GetObject<Tween>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tween.FromPointer); // 0270DBD466B0 0x10 T                           ( 0001866BF4B0 ModelClassType Tween Tween Tween Pointer )
            value.ElapsedLoops                              = GetInt32(new IntPtr(p + 0x018)); // 0270DBD466D0 0x18 ElapsedLoops                ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
