using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 F0                                       0001865BD570 ModelEnumType Long512 Long512 Long512 Int32
    // 1010 F1                                       0001865BD570 ModelEnumType Long512 Long512 Long512 Int32
    public partial class Long1024 : DataModel
    {
        public Long512                                  F0                                      { get; set; }
        public Long512                                  F1                                      { get; set; }

        public static Long1024? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Long1024() { Pointer= p0 };

            value.F0                                        = (Long512)GetInt32(new IntPtr(p + 0x010)); // 0246698D3D30 0x10 F0                          ( 0001865BD570 ModelEnumType Long512 Long512 Long512 Int32 )
            value.F1                                        = (Long512)GetInt32(new IntPtr(p + 0x1010)); // 0246698D3D50 0x1010 F1                          ( 0001865BD570 ModelEnumType Long512 Long512 Long512 Int32 )

            return value;
        }
    }
}
