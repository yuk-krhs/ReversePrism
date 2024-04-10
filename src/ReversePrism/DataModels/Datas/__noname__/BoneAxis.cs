using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Forward                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Up                                       0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class BoneAxis : DataModel
    {
        public Vector3                                  Forward                                 { get; set; }
        public Vector3                                  Up                                      { get; set; }

        public static BoneAxis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoneAxis() { Pointer= p0 };

            value.Forward                                   = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 024664DF2730 0x10 Forward                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Up                                        = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 024664DF2750 0x1C Up                          ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
