using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 dataContractDictionaries                 Dictionary`2<XmlQualifiedName, DataContract>[] IL2CPP_TYPE_SZARRAY
    // 018 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ScopedKnownTypes
    {
        public int                                      Count                                   { get; set; }

        public static ScopedKnownTypes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScopedKnownTypes();

            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 027004CF0FA0 0x18 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
