using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     0001866A2770 ModelEnumType UnsafeBitArray UnsafeBitArray UnsafeBitArray Int32
    public partial class UnsafeBitArrayDebugView : DataModel
    {
        public UnsafeBitArray                           Data                                    { get; set; }

        public static UnsafeBitArrayDebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeBitArrayDebugView() { Pointer= p0 };

            value.Data                                      = (UnsafeBitArray)GetInt32(new IntPtr(p + 0x010)); // 024669CED820 0x10 Data                        ( 0001866A2770 ModelEnumType UnsafeBitArray UnsafeBitArray UnsafeBitArray Int32 )

            return value;
        }
    }
}
