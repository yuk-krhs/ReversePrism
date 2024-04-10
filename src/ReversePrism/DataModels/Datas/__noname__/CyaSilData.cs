using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 Movpat                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Texpat                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C SilRnd                                   000186666050 ModelPrimitiveType float float float Single
    // 020 CyaPosi                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C SilPosi                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CyaSilData : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public int                                      Movpat                                  { get; set; }
        public int                                      Texpat                                  { get; set; }
        public float                                    SilRnd                                  { get; set; }
        public Vector3                                  CyaPosi                                 { get; set; }
        public Vector3                                  SilPosi                                 { get; set; }

        public static CyaSilData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CyaSilData() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0245A35B68D0 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Movpat                                    = GetInt32(new IntPtr(p + 0x014)); // 0245A35B68F0 0x14 Movpat                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Texpat                                    = GetInt32(new IntPtr(p + 0x018)); // 0245A35B6910 0x18 Texpat                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SilRnd                                    = GetSingle(new IntPtr(p + 0x01C)); // 0245A35B6930 0x1C SilRnd                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.CyaPosi                                   = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0245A35B6950 0x20 CyaPosi                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.SilPosi                                   = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0245A35B6970 0x2C SilPosi                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
