using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 014 SilhouettePosition                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 020 CyaPosi                                  ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C SilRnd                                   ModelPrimitiveType float float float Single
    // 030 Movpat                                   ModelPrimitiveType int int int Int32
    public partial class CyaSil : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public Vector3                                  SilhouettePosition                      { get; set; }
        public Vector3                                  CyaPosi                                 { get; set; }
        public float                                    SilRnd                                  { get; set; }
        public int                                      Movpat                                  { get; set; }

        public static CyaSil? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CyaSil() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.SilhouettePosition                        = (Vector3)GetInt32(new IntPtr(p + 0x014)); // 0x14 SilhouettePosition          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CyaPosi                                   = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 CyaPosi                     ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.SilRnd                                    = GetSingle(new IntPtr(p + 0x02C)); // 0x2C SilRnd                      ( ModelPrimitiveType float float float Single )
            value.Movpat                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 Movpat                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
