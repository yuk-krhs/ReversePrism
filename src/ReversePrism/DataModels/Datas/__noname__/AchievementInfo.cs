using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNew                                    ModelPrimitiveType bool bool bool Bool
    public partial class AchievementInfo : DataModel
    {
        public bool                                     IsNew                                   { get; set; }

        public static AchievementInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementInfo() { Pointer= p0 };

            value.IsNew                                     = GetBool(new IntPtr(p + 0x010)); // 0x10 IsNew                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
