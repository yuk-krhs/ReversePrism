using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LastMousePos                             0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C CurrentMousePos                          0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class UIDragEffect : DataModel
    {
        public Vector3                                  LastMousePos                            { get; set; }
        public Vector3                                  CurrentMousePos                         { get; set; }

        public static UIDragEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIDragEffect() { Pointer= p0 };

            value.LastMousePos                              = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0246609DD2D0 0x20 LastMousePos                ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CurrentMousePos                           = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0246609DD2F0 0x2C CurrentMousePos             ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
