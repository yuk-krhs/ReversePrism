using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UndecoratedCallInvoker                   00018652ADF0 ModelClassType CallInvoker CallInvoker CallInvoker Pointer
    // 018 Host                                     000186672F10 ModelPrimitiveType string string string String
    public partial class ClientBaseConfiguration : DataModel
    {
        public CallInvoker?                             UndecoratedCallInvoker                  { get; set; }
        public string                                   Host                                    { get; set; }

        public static ClientBaseConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientBaseConfiguration() { Pointer= p0 };

            value.UndecoratedCallInvoker                    = GetObject<CallInvoker>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallInvoker.FromPointer); // 024664164E48 0x10 UndecoratedCallInvoker      ( 00018652ADF0 ModelClassType CallInvoker CallInvoker CallInvoker Pointer )
            value.Host                                      = GetString(new IntPtr(p + 0x018)); // 024664164E68 0x18 Host                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
