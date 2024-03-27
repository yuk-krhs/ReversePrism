using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Readable                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Length                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 040 Position                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 048 Byte_array_position                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AppGuardSecureStream
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
            var value   = new AppGuardSecureStream();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 0270D4BBD4E8 0x28 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Readable                                  = GetBool(new IntPtr(p + 0x030)); // 0270D4BBD508 0x30 Readable                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Length                                    = GetInt64(new IntPtr(p + 0x038)); // 0270D4BBD528 0x38 Length                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Position                                  = GetInt64(new IntPtr(p + 0x040)); // 0270D4BBD548 0x40 Position                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Byte_array_position                       = GetInt32(new IntPtr(p + 0x048)); // 0270D4BBD568 0x48 Byte_array_position         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
