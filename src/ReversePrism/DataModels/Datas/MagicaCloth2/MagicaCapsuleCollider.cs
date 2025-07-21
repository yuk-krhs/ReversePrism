using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Direction                                ModelEnumType Direction Direction Direction Int32
    // 044 RadiusSeparation                         ModelPrimitiveType bool bool bool Bool
    // 045 AlignedOnCenter                          ModelPrimitiveType bool bool bool Bool
    public partial class MagicaCapsuleCollider : DataModel
    {
        public Direction                                Direction                               { get; set; }
        public bool                                     RadiusSeparation                        { get; set; }
        public bool                                     AlignedOnCenter                         { get; set; }

        public static MagicaCapsuleCollider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaCapsuleCollider() { Pointer= p0 };

            value.Direction                                 = (Direction)GetInt32(new IntPtr(p + 0x040)); // 0x40 Direction                   ( ModelEnumType Direction Direction Direction Int32 )
            value.RadiusSeparation                          = GetBool(new IntPtr(p + 0x044)); // 0x44 RadiusSeparation            ( ModelPrimitiveType bool bool bool Bool )
            value.AlignedOnCenter                           = GetBool(new IntPtr(p + 0x045)); // 0x45 AlignedOnCenter             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
