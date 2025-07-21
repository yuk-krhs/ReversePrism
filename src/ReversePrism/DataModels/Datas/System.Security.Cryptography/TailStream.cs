using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 BufferSize                               ModelPrimitiveType int int int Int32
    // 034 BufferIndex                              ModelPrimitiveType int int int Int32
    // 038 BufferFull                               ModelPrimitiveType bool bool bool Bool
    public partial class TailStream : DataModel
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
            var value   = new TailStream() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 BufferSize                  ( ModelPrimitiveType int int int Int32 )
            value.BufferIndex                               = GetInt32(new IntPtr(p + 0x034)); // 0x34 BufferIndex                 ( ModelPrimitiveType int int int Int32 )
            value.BufferFull                                = GetBool(new IntPtr(p + 0x038)); // 0x38 BufferFull                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
