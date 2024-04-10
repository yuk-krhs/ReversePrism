using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 hashCodeDelegate                         HashCodeOfStringDelegate IL2CPP_TYPE_CLASS
    // 010 HashCodeRandomizer                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SecureStringHasher : DataModel
    {
        public int                                      HashCodeRandomizer                      { get; set; }

        public static SecureStringHasher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecureStringHasher() { Pointer= p0 };

            value.HashCodeRandomizer                        = GetInt32(new IntPtr(p + 0x010)); // 02466739E870 0x10 HashCodeRandomizer          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
