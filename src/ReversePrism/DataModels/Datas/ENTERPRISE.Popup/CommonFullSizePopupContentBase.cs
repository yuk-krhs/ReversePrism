using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Param                                    0001865E3C00 ModelClassType CommonFullSizePopupParam CommonFullSizePopupParam CommonFullSizePopupParam Pointer
    public partial class CommonFullSizePopupContentBase
    {
        public CommonFullSizePopupParam?                Param                                   { get; set; }

        public static CommonFullSizePopupContentBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonFullSizePopupContentBase();

            value.Param                                     = GetObject<CommonFullSizePopupParam>(new IntPtr(p + 0x058), ReversePrism.DataModels.CommonFullSizePopupParam.FromPointer); // 0270D4C81C18 0x58 Param                       ( 0001865E3C00 ModelClassType CommonFullSizePopupParam CommonFullSizePopupParam CommonFullSizePopupParam Pointer )

            return value;
        }
    }
}
