using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Running                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 ProviderBase                             0001865DC5F0 ModelClassType SubsystemProvider SubsystemProvider SubsystemProvider Pointer
    public partial class SubsystemWithProvider
    {
        public bool                                     Running                                 { get; set; }
        public SubsystemProvider?                       ProviderBase                            { get; set; }

        public static SubsystemWithProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubsystemWithProvider();

            value.Running                                   = GetBool(new IntPtr(p + 0x010)); // 0270001A2AB0 0x10 Running                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProviderBase                              = GetObject<SubsystemProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.SubsystemProvider.FromPointer); // 0270001A2AD0 0x18 ProviderBase                ( 0001865DC5F0 ModelClassType SubsystemProvider SubsystemProvider SubsystemProvider Pointer )

            return value;
        }
    }
}
