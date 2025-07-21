using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ArmDrawInRange                           ModelPrimitiveType float float float Single
    // 014 BodyDrawInRange                          ModelPrimitiveType float float float Single
    public partial class AudienceControllerBehaviour : DataModel
    {
        public float                                    ArmDrawInRange                          { get; set; }
        public float                                    BodyDrawInRange                         { get; set; }

        public static AudienceControllerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudienceControllerBehaviour() { Pointer= p0 };

            value.ArmDrawInRange                            = GetSingle(new IntPtr(p + 0x010)); // 0x10 ArmDrawInRange              ( ModelPrimitiveType float float float Single )
            value.BodyDrawInRange                           = GetSingle(new IntPtr(p + 0x014)); // 0x14 BodyDrawInRange             ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
