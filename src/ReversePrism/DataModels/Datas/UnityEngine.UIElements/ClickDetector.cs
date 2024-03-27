using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ClickStatus                            000185D20B88 ModelClassListType List`1<ButtonClickStatus> List`1<ButtonClickStatus> List<ButtonClickStatus> Pointer
    // 000 <s_DoubleClickTime>k__BackingField       int IL2CPP_TYPE_I4
    public partial class ClickDetector
    {
        public List<ButtonClickStatus>?                 M_ClickStatus                           { get; set; }

        public static ClickDetector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClickDetector();

            value.M_ClickStatus                             = GetObjectList<ButtonClickStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ButtonClickStatus.FromPointer); // 0270066E4ED0 0x10 M_ClickStatus               ( 000185D20B88 ModelClassListType List`1<ButtonClickStatus> List`1<ButtonClickStatus> List<ButtonClickStatus> Pointer )

            return value;
        }
    }
}
