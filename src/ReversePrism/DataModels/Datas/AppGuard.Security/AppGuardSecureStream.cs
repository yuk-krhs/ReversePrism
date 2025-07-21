using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Readable                                 ModelPrimitiveType bool bool bool Bool
    // 038 Length                                   ModelPrimitiveType long long long Int64
    // 040 Position                                 ModelPrimitiveType long long long Int64
    // 048 Byte_array_position                      ModelPrimitiveType int int int Int32
    public partial class AppGuardSecureStream : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public bool                                     Readable                                { get; set; }
        public long                                     Length                                  { get; set; }
        public long                                     Position                                { get; set; }
        public int                                      Byte_array_position                     { get; set; }

        public static AppGuardSecureStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppGuardSecureStream() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Readable                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 Readable                    ( ModelPrimitiveType bool bool bool Bool )
            value.Length                                    = GetInt64(new IntPtr(p + 0x038)); // 0x38 Length                      ( ModelPrimitiveType long long long Int64 )
            value.Position                                  = GetInt64(new IntPtr(p + 0x040)); // 0x40 Position                    ( ModelPrimitiveType long long long Int64 )
            value.Byte_array_position                       = GetInt32(new IntPtr(p + 0x048)); // 0x48 Byte_array_position         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
