using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssemblyString                           000186671BA0 ModelPrimitiveType string string string String
    // 018 Assembly                                 00018658AEE0 ModelClassType Assembly Assembly Assembly Pointer
    public partial class BinaryAssemblyInfo
    {
        public string                                   AssemblyString                          { get; set; }
        public Assembly?                                Assembly                                { get; set; }

        public static BinaryAssemblyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryAssemblyInfo();

            value.AssemblyString                            = GetString(new IntPtr(p + 0x010)); // 0270D6C30AC0 0x10 AssemblyString              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Assembly                                  = GetObject<Assembly>(new IntPtr(p + 0x018), ReversePrism.DataModels.Assembly.FromPointer); // 0270D6C30AE0 0x18 Assembly                    ( 00018658AEE0 ModelClassType Assembly Assembly Assembly Pointer )

            return value;
        }
    }
}
