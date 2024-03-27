using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OkButtonLayoutList                       List`1<ButtonInformation> IL2CPP_TYPE_GENERICINST
    // 008 CloseButtonLayoutList                    List`1<ButtonInformation> IL2CPP_TYPE_GENERICINST
    // 010 OkCancelButtonLayoutList                 000185CD0778 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer
    // 018 YesNoButtonLayoutList                    000185CD0778 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer
    public partial class ButtonSetInformation
    {
        public List<ButtonInformation>?                 OkCancelButtonLayoutList                { get; set; }
        public List<ButtonInformation>?                 YesNoButtonLayoutList                   { get; set; }

        public static ButtonSetInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonSetInformation();

            value.OkCancelButtonLayoutList                  = GetObjectList<ButtonInformation>(new IntPtr(p + 0x010), ReversePrism.DataModels.ButtonInformation.FromPointer); // 0270DAFF1580 0x10 OkCancelButtonLayoutList    ( 000185CD0778 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer )
            value.YesNoButtonLayoutList                     = GetObjectList<ButtonInformation>(new IntPtr(p + 0x018), ReversePrism.DataModels.ButtonInformation.FromPointer); // 0270DAFF15A0 0x18 YesNoButtonLayoutList       ( 000185CD0778 ModelClassListType List`1<ButtonInformation> List`1<ButtonInformation> List<ButtonInformation> Pointer )

            return value;
        }
    }
}
