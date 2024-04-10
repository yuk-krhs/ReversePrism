using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 onSoftwareReset                          Action IL2CPP_TYPE_CLASS
    // 008 SoftwareResetFunc                        Func`2<<object>, UniTask> IL2CPP_TYPE_GENERICINST
    // 010 IsResetting                              000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class ApplicationUtility : DataModel
    {
        public bool                                     IsResetting                             { get; set; }

        public static ApplicationUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ApplicationUtility() { Pointer= p0 };

            value.IsResetting                               = GetBool(new IntPtr(p + 0x010)); // 0245A3A3CE50 0x10 IsResetting                 ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
