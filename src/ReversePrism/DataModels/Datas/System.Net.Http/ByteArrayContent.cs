using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Content                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Offset                                   ModelPrimitiveType int int int Int32
    // 034 Count                                    ModelPrimitiveType int int int Int32
    public partial class ByteArrayContent : DataModel
    {
        public List<sbyte>?                             Content                                 { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }

        public static ByteArrayContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByteArrayContent() { Pointer= p0 };

            value.Content                                   = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Content                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x034)); // 0x34 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
