using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Closure                                  ModelClassListType IStrongBox[] IStrongBox[] List<IStrongBox> Pointer
    // 018 Interpreter                              ModelClassType Interpreter Interpreter Interpreter Pointer
    // 000 _runCache                                CacheDict`2<Type, Func`2<LightLambda, Delegate>> IL2CPP_TYPE_GENERICINST
    // 020 DelegateCreator                          ModelClassType LightDelegateCreator LightDelegateCreator LightDelegateCreator Pointer
    public partial class LightLambda : DataModel
    {
        public List<IStrongBox>?                        Closure                                 { get; set; }
        public Interpreter?                             Interpreter                             { get; set; }
        public LightDelegateCreator?                    DelegateCreator                         { get; set; }

        public static LightLambda? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightLambda() { Pointer= p0 };

            value.Closure                                   = GetObjectList<IStrongBox>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStrongBox.FromPointer); // 0x10 Closure                     ( ModelClassListType IStrongBox[] IStrongBox[] List<IStrongBox> Pointer )
            value.Interpreter                               = GetObject<Interpreter>(new IntPtr(p + 0x018), ReversePrism.DataModels.Interpreter.FromPointer); // 0x18 Interpreter                 ( ModelClassType Interpreter Interpreter Interpreter Pointer )
            value.DelegateCreator                           = GetObject<LightDelegateCreator>(new IntPtr(p + 0x020), ReversePrism.DataModels.LightDelegateCreator.FromPointer); // 0x20 DelegateCreator             ( ModelClassType LightDelegateCreator LightDelegateCreator LightDelegateCreator Pointer )

            return value;
        }
    }
}
