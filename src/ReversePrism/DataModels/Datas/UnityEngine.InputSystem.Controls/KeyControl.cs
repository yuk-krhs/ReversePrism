using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 138 KeyCode                                  ModelEnumType Key Key Key Int32
    // 13C M_ScanCode                               ModelPrimitiveType int int int Int32
    public partial class KeyControl : DataModel
    {
        public Key                                      KeyCode                                 { get; set; }
        public int                                      M_ScanCode                              { get; set; }

        public static KeyControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyControl() { Pointer= p0 };

            value.KeyCode                                   = (Key)GetInt32(new IntPtr(p + 0x138)); // 0x138 KeyCode                     ( ModelEnumType Key Key Key Int32 )
            value.M_ScanCode                                = GetInt32(new IntPtr(p + 0x13C)); // 0x13C M_ScanCode                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
