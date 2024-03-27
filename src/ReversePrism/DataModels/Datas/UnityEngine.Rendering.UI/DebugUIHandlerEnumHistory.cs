using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 HistoryValues                            000185CAA658 ModelClassListType Text[] Text[] List<Text> Pointer
    // 000 k_XOffset                                float IL2CPP_TYPE_R4
    public partial class DebugUIHandlerEnumHistory
    {
        public List<Text>?                              HistoryValues                           { get; set; }

        public static DebugUIHandlerEnumHistory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerEnumHistory();

            value.HistoryValues                             = GetObjectList<Text>(new IntPtr(p + 0x088), ReversePrism.DataModels.Text.FromPointer); // 0270D93365F0 0x88 HistoryValues               ( 000185CAA658 ModelClassListType Text[] Text[] List<Text> Pointer )

            return value;
        }
    }
}
