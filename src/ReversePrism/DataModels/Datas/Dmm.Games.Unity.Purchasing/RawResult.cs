using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StatusCode                               ModelPrimitiveType int int int Int32
    // 018 Body                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class RawResult : DataModel
    {
        public int                                      StatusCode                              { get; set; }
        public List<sbyte>?                             Body                                    { get; set; }

        public static RawResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RawResult() { Pointer= p0 };

            value.StatusCode                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 StatusCode                  ( ModelPrimitiveType int int int Int32 )
            value.Body                                      = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Body                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
