using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ErrorMessage                           string IL2CPP_TYPE_STRING
    // 010 Registry                                 0001867366C0 ModelClassType IComponentRegistry IComponentRegistry IComponentRegistry Pointer
    public partial class LockedComponentRegistry
    {
        public IComponentRegistry?                      Registry                                { get; set; }

        public static LockedComponentRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LockedComponentRegistry();

            value.Registry                                  = GetObject<IComponentRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.IComponentRegistry.FromPointer); // 027006990E30 0x10 Registry                    ( 0001867366C0 ModelClassType IComponentRegistry IComponentRegistry IComponentRegistry Pointer )

            return value;
        }
    }
}
