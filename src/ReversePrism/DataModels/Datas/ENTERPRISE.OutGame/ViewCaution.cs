using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 BgButton                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 SkipAllowTime                            0001866656B0 ModelPrimitiveType float float float Single
    // 078 BgButtonActiveTime                       0001865B9520 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class ViewCaution
    {
        public ButtonBase?                              BgButton                                { get; set; }
        public float                                    SkipAllowTime                           { get; set; }
        public DateTime                                 BgButtonActiveTime                      { get; set; }

        public static ViewCaution? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewCaution();

            value.BgButton                                  = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 027004287108 0x68 BgButton                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SkipAllowTime                             = GetSingle(new IntPtr(p + 0x070)); // 027004287128 0x70 SkipAllowTime               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.BgButtonActiveTime                        = GetDateTime(new IntPtr(p + 0x078)); // 027004287148 0x78 BgButtonActiveTime          ( 0001865B9520 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
