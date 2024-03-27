using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PackageType                              000186692F60 ModelClassType Type Type Type Pointer
    // 018 InitializationTimeInSeconds              0001865C2E50 ModelPrimitiveType double double double Double
    public partial class PackageInitializationInfo
    {
        public Type?                                    PackageType                             { get; set; }
        public double                                   InitializationTimeInSeconds             { get; set; }

        public static PackageInitializationInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PackageInitializationInfo();

            value.PackageType                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270066190B0 0x10 PackageType                 ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.InitializationTimeInSeconds               = GetDouble(new IntPtr(p + 0x018)); // 0270066190D0 0x18 InitializationTimeInSeconds ( 0001865C2E50 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
