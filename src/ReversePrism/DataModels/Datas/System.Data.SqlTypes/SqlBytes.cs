using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RgbBuf                                   000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 LCurLen                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 020 Stream                                   000186670490 ModelClassType Stream Stream Stream Pointer
    // 028 State                                    000186555280 ModelEnumType SqlBytesCharsState SqlBytesCharsState SqlBytesCharsState Int32
    // 030 RgbWorkBuf                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class SqlBytes
    {
        public List<sbyte>?                             RgbBuf                                  { get; set; }
        public long                                     LCurLen                                 { get; set; }
        public Stream?                                  Stream                                  { get; set; }
        public SqlBytesCharsState                       State                                   { get; set; }
        public List<sbyte>?                             RgbWorkBuf                              { get; set; }

        public static SqlBytes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlBytes();

            value.RgbBuf                                    = GetSByteList(new IntPtr(p + 0x010)); // 0270D8982AE0 0x10 RgbBuf                      ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LCurLen                                   = GetInt64(new IntPtr(p + 0x018)); // 0270D8982B00 0x18 LCurLen                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x020), ReversePrism.DataModels.Stream.FromPointer); // 0270D8982B20 0x20 Stream                      ( 000186670490 ModelClassType Stream Stream Stream Pointer )
            value.State                                     = (SqlBytesCharsState)GetInt32(new IntPtr(p + 0x028)); // 0270D8982B40 0x28 State                       ( 000186555280 ModelEnumType SqlBytesCharsState SqlBytesCharsState SqlBytesCharsState Int32 )
            value.RgbWorkBuf                                = GetSByteList(new IntPtr(p + 0x030)); // 0270D8982B60 0x30 RgbWorkBuf                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
