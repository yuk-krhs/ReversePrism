using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsNew                                    000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class AchievementInfo
    {
        public bool                                     IsNew                                   { get; set; }

        public static AchievementInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementInfo();

            value.IsNew                                     = GetBool(new IntPtr(p + 0x010)); // 0270DAE17B20 0x10 IsNew                       ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
