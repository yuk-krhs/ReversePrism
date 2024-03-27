using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 BufferSize                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 BufferIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 BufferFull                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TailStream
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      BufferSize                              { get; set; }
        public int                                      BufferIndex                             { get; set; }
        public bool                                     BufferFull                              { get; set; }

        public static TailStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TailStream();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 0270D6B6EBE8 0x28 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x030)); // 0270D6B6EC08 0x30 BufferSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BufferIndex                               = GetInt32(new IntPtr(p + 0x034)); // 0270D6B6EC28 0x34 BufferIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BufferFull                                = GetBool(new IntPtr(p + 0x038)); // 0270D6B6EC48 0x38 BufferFull                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
