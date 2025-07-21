using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 emptySHA1                                sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 emptySHA256                              sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 EmptySHA384                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 EmptySHA512                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class PKCS1 : DataModel
    {
        public List<sbyte>?                             EmptySHA384                             { get; set; }
        public List<sbyte>?                             EmptySHA512                             { get; set; }

        public static PKCS1? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PKCS1() { Pointer= p0 };

            value.EmptySHA384                               = GetSByteList(new IntPtr(p + 0x010)); // 0x10 EmptySHA384                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.EmptySHA512                               = GetSByteList(new IntPtr(p + 0x018)); // 0x18 EmptySHA512                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
