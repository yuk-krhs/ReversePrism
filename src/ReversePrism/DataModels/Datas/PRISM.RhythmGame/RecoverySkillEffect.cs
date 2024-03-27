using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RecoveryLife                             0001865F4260 ModelPrimitiveType int int int Int32
    public partial class RecoverySkillEffect
    {
        public int                                      RecoveryLife                            { get; set; }

        public static RecoverySkillEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecoverySkillEffect();

            value.RecoveryLife                              = GetInt32(new IntPtr(p + 0x020)); // 0270D4F8A828 0x20 RecoveryLife                ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
