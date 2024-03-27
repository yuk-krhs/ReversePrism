using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 props                                    IntPtr IL2CPP_TYPE_PTR
    // 008 mappedChars                              IntPtr IL2CPP_TYPE_PTR
    // 010 charMapIndex                             IntPtr IL2CPP_TYPE_PTR
    // 018 helperIndex                              IntPtr IL2CPP_TYPE_PTR
    // 020 mapIdxToComposite                        IntPtr IL2CPP_TYPE_PTR
    // 028 combiningClass                           IntPtr IL2CPP_TYPE_PTR
    // 030 forLock                                  <object> IL2CPP_TYPE_OBJECT
    // 038 IsReady                                  000186597200 ModelPrimitiveType bool bool bool Bool
    public partial class Normalization
    {
        public bool                                     IsReady                                 { get; set; }

        public static Normalization? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Normalization();

            value.IsReady                                   = GetBool(new IntPtr(p + 0x038)); // 0270D6B674E8 0x38 IsReady                     ( 000186597200 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
