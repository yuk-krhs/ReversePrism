using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 mClients                                 HashSet`1<Object> IL2CPP_TYPE_GENERICINST
    // 008 OnGUIHandlers                            OnGUIDelegate IL2CPP_TYPE_CLASS
    // 010 MAvailableStringBuilders                 ModelClassListType List`1<StringBuilder> List`1<StringBuilder> List<StringBuilder> Pointer
    public partial class CinemachineDebug : DataModel
    {
        public List<StringBuilder>?                     MAvailableStringBuilders                { get; set; }

        public static CinemachineDebug? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineDebug() { Pointer= p0 };

            value.MAvailableStringBuilders                  = GetObjectList<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x10 MAvailableStringBuilders    ( ModelClassListType List`1<StringBuilder> List`1<StringBuilder> List<StringBuilder> Pointer )

            return value;
        }
    }
}
