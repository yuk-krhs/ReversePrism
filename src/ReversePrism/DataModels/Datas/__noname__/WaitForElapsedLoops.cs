using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        ModelClassType Tween Tween Tween Pointer
    // 018 ElapsedLoops                             ModelPrimitiveType int int int Int32
    public partial class WaitForElapsedLoops : DataModel
    {
        public Tween?                                   T                                       { get; set; }
        public int                                      ElapsedLoops                            { get; set; }

        public static WaitForElapsedLoops? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForElapsedLoops() { Pointer= p0 };

            value.T                                         = GetObject<Tween>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tween.FromPointer); // 0x10 T                           ( ModelClassType Tween Tween Tween Pointer )
            value.ElapsedLoops                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 ElapsedLoops                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
