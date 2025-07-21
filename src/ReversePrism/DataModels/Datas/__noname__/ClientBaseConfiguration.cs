using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UndecoratedCallInvoker                   ModelClassType CallInvoker CallInvoker CallInvoker Pointer
    // 018 Host                                     ModelPrimitiveType string string string String
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

            value.UndecoratedCallInvoker                    = GetObject<CallInvoker>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallInvoker.FromPointer); // 0x10 UndecoratedCallInvoker      ( ModelClassType CallInvoker CallInvoker CallInvoker Pointer )
            value.Host                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Host                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
