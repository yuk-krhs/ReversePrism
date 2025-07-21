using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Configuration                            ModelClassType ClientBaseConfiguration ClientBaseConfiguration ClientBaseConfiguration Pointer
    // 018 CallInvoker                              ModelClassType CallInvoker CallInvoker CallInvoker Pointer
    public partial class ClientBase : DataModel
    {
        public ClientBaseConfiguration?                 Configuration                           { get; set; }
        public CallInvoker?                             CallInvoker                             { get; set; }

        public static ClientBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientBase() { Pointer= p0 };

            value.Configuration                             = GetObject<ClientBaseConfiguration>(new IntPtr(p + 0x010), ReversePrism.DataModels.ClientBaseConfiguration.FromPointer); // 0x10 Configuration               ( ModelClassType ClientBaseConfiguration ClientBaseConfiguration ClientBaseConfiguration Pointer )
            value.CallInvoker                               = GetObject<CallInvoker>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallInvoker.FromPointer); // 0x18 CallInvoker                 ( ModelClassType CallInvoker CallInvoker CallInvoker Pointer )

            return value;
        }
    }
}
