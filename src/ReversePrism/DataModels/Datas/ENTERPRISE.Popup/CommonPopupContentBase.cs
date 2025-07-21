using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Param                                    ModelClassType CommonPopupParam CommonPopupParam CommonPopupParam Pointer
    public partial class CommonPopupContentBase : DataModel
    {
        public CommonPopupParam?                        Param                                   { get; set; }

        public static CommonPopupContentBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupContentBase() { Pointer= p0 };

            value.Param                                     = GetObject<CommonPopupParam>(new IntPtr(p + 0x058), ReversePrism.DataModels.CommonPopupParam.FromPointer); // 0x58 Param                       ( ModelClassType CommonPopupParam CommonPopupParam CommonPopupParam Pointer )

            return value;
        }
    }
}
