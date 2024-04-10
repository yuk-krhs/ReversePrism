using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AngleX                                   000186666050 ModelPrimitiveType float float float Single
    // 014 AngleY                                   000186666050 ModelPrimitiveType float float float Single
    // 018 Fov                                      000186666050 ModelPrimitiveType float float float Single
    public partial class CameraTargetParameter : DataModel
    {
        public float                                    AngleX                                  { get; set; }
        public float                                    AngleY                                  { get; set; }
        public float                                    Fov                                     { get; set; }

        public static CameraTargetParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraTargetParameter() { Pointer= p0 };

            value.AngleX                                    = GetSingle(new IntPtr(p + 0x010)); // 0246654A65E8 0x10 AngleX                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.AngleY                                    = GetSingle(new IntPtr(p + 0x014)); // 0246654A6608 0x14 AngleY                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Fov                                       = GetSingle(new IntPtr(p + 0x018)); // 0246654A6628 0x18 Fov                         ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
