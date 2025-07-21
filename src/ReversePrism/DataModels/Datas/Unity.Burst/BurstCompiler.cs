using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF _cmdBuilder                              CommandBuilder IL2CPP_TYPE_CLASS
    // 000 _IsEnabled                               bool IL2CPP_TYPE_BOOLEAN
    // 008 Options                                  BurstCompilerOptions IL2CPP_TYPE_CLASS
    // 010 OnCompileILPPMethod2                     ModelClassType Action Action Action Pointer
    // 018 DummyMethodInfo                          ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class BurstCompiler : DataModel
    {
        public Action?                                  OnCompileILPPMethod2                    { get; set; }
        public MethodInfo?                              DummyMethodInfo                         { get; set; }

        public static BurstCompiler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BurstCompiler() { Pointer= p0 };

            value.OnCompileILPPMethod2                      = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0x10 OnCompileILPPMethod2        ( ModelClassType Action Action Action Pointer )
            value.DummyMethodInfo                           = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x18 DummyMethodInfo             ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
