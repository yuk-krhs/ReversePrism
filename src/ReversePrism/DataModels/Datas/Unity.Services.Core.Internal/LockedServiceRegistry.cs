using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ErrorMessage                           string IL2CPP_TYPE_STRING
    // 010 Registry                                 ModelClassType IServiceRegistry IServiceRegistry IServiceRegistry Pointer
    public partial class LockedServiceRegistry : DataModel
    {
        public IServiceRegistry?                        Registry                                { get; set; }

        public static LockedServiceRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LockedServiceRegistry() { Pointer= p0 };

            value.Registry                                  = GetObject<IServiceRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.IServiceRegistry.FromPointer); // 0x10 Registry                    ( ModelClassType IServiceRegistry IServiceRegistry IServiceRegistry Pointer )

            return value;
        }
    }
}
