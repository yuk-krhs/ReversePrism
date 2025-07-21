using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Instance>k__BackingField                IUnityServices IL2CPP_TYPE_CLASS
    // 008 <InstantiationCompletion>k__BackingField TaskCompletionSource`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 ExternalUserIdProperty                   ModelClassType ExternalUserIdProperty ExternalUserIdProperty ExternalUserIdProperty Pointer
    public partial class UnityServices : DataModel
    {
        public ExternalUserIdProperty?                  ExternalUserIdProperty                  { get; set; }

        public static UnityServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityServices() { Pointer= p0 };

            value.ExternalUserIdProperty                    = GetObject<ExternalUserIdProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExternalUserIdProperty.FromPointer); // 0x10 ExternalUserIdProperty      ( ModelClassType ExternalUserIdProperty ExternalUserIdProperty ExternalUserIdProperty Pointer )

            return value;
        }
    }
}
