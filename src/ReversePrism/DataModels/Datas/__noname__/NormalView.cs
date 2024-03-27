using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Length                                   000186666050 ModelPrimitiveType float float float Single
    // 024 Bias                                     0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 TangentOnly                              000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class NormalView
    {
        public float                                    Length                                  { get; set; }
        public Vector3                                  Bias                                    { get; set; }
        public bool                                     TangentOnly                             { get; set; }

        public static NormalView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NormalView();

            value.Length                                    = GetSingle(new IntPtr(p + 0x020)); // 0270D4B1A1B0 0x20 Length                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Bias                                      = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0270D4B1A1D0 0x24 Bias                        ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TangentOnly                               = GetBool(new IntPtr(p + 0x030)); // 0270D4B1A1F0 0x30 TangentOnly                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
