using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BgButton                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 SkipAllowTime                            ModelPrimitiveType float float float Single
    // 070 BgButtonActiveTime                       ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class ViewCaution : DataModel
    {
        public ButtonBase?                              BgButton                                { get; set; }
        public float                                    SkipAllowTime                           { get; set; }
        public DateTime                                 BgButtonActiveTime                      { get; set; }

        public static ViewCaution? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewCaution() { Pointer= p0 };

            value.BgButton                                  = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x60 BgButton                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SkipAllowTime                             = GetSingle(new IntPtr(p + 0x068)); // 0x68 SkipAllowTime               ( ModelPrimitiveType float float float Single )
            value.BgButtonActiveTime                        = GetDateTime(new IntPtr(p + 0x070)); // 0x70 BgButtonActiveTime          ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
