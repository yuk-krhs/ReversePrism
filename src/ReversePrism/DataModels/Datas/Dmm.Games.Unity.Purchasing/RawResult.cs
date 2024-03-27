using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StatusCode                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Body                                     000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class RawResult
    {
        public int                                      StatusCode                              { get; set; }
        public List<sbyte>?                             Body                                    { get; set; }

        public static RawResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RawResult();

            value.StatusCode                                = GetInt32(new IntPtr(p + 0x010)); // 0270DB482CA0 0x10 StatusCode                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Body                                      = GetSByteList(new IntPtr(p + 0x018)); // 0270DB482CC0 0x18 Body                        ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
