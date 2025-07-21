using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 014 HashSizeValue                            ModelPrimitiveType int int int Int32
    // 018 HashValue                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 State                                    ModelPrimitiveType int int int Int32
    public partial class HashAlgorithm : DataModel
    {
        public bool                                     Disposed                                { get; set; }
        public int                                      HashSizeValue                           { get; set; }
        public List<sbyte>?                             HashValue                               { get; set; }
        public int                                      State                                   { get; set; }

        public static HashAlgorithm? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HashAlgorithm() { Pointer= p0 };

            value.Disposed                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.HashSizeValue                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 HashSizeValue               ( ModelPrimitiveType int int int Int32 )
            value.HashValue                                 = GetSByteList(new IntPtr(p + 0x018)); // 0x18 HashValue                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.State                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 State                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
