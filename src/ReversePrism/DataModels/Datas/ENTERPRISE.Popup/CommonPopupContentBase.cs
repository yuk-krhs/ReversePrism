using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Param                                    0001865E80B0 ModelClassType CommonPopupParam CommonPopupParam CommonPopupParam Pointer
    public partial class CommonPopupContentBase : DataModel
    {
        public CommonPopupParam?                        Param                                   { get; set; }

        public static CommonPopupContentBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupContentBase() { Pointer= p0 };

            value.Param                                     = GetObject<CommonPopupParam>(new IntPtr(p + 0x058), ReversePrism.DataModels.CommonPopupParam.FromPointer); // 024660D77418 0x58 Param                       ( 0001865E80B0 ModelClassType CommonPopupParam CommonPopupParam CommonPopupParam Pointer )

            return value;
        }
    }
}
