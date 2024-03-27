using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186671910 ModelPrimitiveType string string string String
    // 018 ProviderType                             000186692850 ModelClassType Type Type Type Pointer
    // 020 SubsystemTypeOverride                    000186692850 ModelClassType Type Type Type Pointer
    // 028 SubsystemImplementationType              000186692850 ModelClassType Type Type Type Pointer
    public partial class Cinfo
    {
        public string                                   Id                                      { get; set; }
        public Type?                                    ProviderType                            { get; set; }
        public Type?                                    SubsystemTypeOverride                   { get; set; }
        public Type?                                    SubsystemImplementationType             { get; set; }

        public static Cinfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Cinfo();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0270DB68B658 0x10 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.ProviderType                              = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270DB68B678 0x18 ProviderType                ( 000186692850 ModelClassType Type Type Type Pointer )
            value.SubsystemTypeOverride                     = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270DB68B698 0x20 SubsystemTypeOverride       ( 000186692850 ModelClassType Type Type Type Pointer )
            value.SubsystemImplementationType               = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0270DB68B6B8 0x28 SubsystemImplementationType ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
