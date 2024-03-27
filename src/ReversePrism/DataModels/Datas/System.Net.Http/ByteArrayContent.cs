using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Content                                  000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Offset                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 034 Count                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ByteArrayContent
    {
        public List<sbyte>?                             Content                                 { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }

        public static ByteArrayContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByteArrayContent();

            value.Content                                   = GetSByteList(new IntPtr(p + 0x028)); // 0270DB82C528 0x28 Content                     ( 000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x030)); // 0270DB82C548 0x30 Offset                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x034)); // 0270DB82C568 0x34 Count                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
