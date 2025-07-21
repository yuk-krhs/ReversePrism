using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 000 MaxBinaryLength                          int IL2CPP_TYPE_I4
    // 004 MinBinaryLength                          int IL2CPP_TYPE_I4
    public partial class SecurityIdentifier : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }

        public static SecurityIdentifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecurityIdentifier() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
