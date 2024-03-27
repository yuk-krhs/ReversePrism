using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_GroupManagers                          Dictionary`2<IGroupBox, IGroupManager> IL2CPP_TYPE_GENERICINST
    // 008 s_GroupOptionManagerCache                Dictionary`2<IGroupBoxOption, IGroupManager> IL2CPP_TYPE_GENERICINST
    // 010 K_GenericGroupBoxType                    000186693E20 ModelClassType Type Type Type Pointer
    public partial class GroupBoxUtility
    {
        public Type?                                    K_GenericGroupBoxType                   { get; set; }

        public static GroupBoxUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupBoxUtility();

            value.K_GenericGroupBoxType                     = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270067DCC68 0x10 K_GenericGroupBoxType       ( 000186693E20 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
