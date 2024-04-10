using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 HistoryToggles                           000185CAC0A8 ModelClassListType Toggle[] Toggle[] List<Toggle> Pointer
    // 000 k_XOffset                                float IL2CPP_TYPE_R4
    public partial class DebugUIHandlerToggleHistory : DataModel
    {
        public List<Toggle>?                            HistoryToggles                          { get; set; }

        public static DebugUIHandlerToggleHistory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerToggleHistory() { Pointer= p0 };

            value.HistoryToggles                            = GetObjectList<Toggle>(new IntPtr(p + 0x080), ReversePrism.DataModels.Toggle.FromPointer); // 02466939C438 0x80 HistoryToggles              ( 000185CAC0A8 ModelClassListType Toggle[] Toggle[] List<Toggle> Pointer )

            return value;
        }
    }
}
