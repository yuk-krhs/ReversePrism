using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PassList                                 000185D2A1D8 ModelEnumListType List`1<PassDebugData> List`1<PassDebugData> List<PassDebugData> Pointer
    // 018 resourceLists                            List`1<ResourceDebugData>[] IL2CPP_TYPE_SZARRAY
    public partial class RenderGraphDebugData : DataModel
    {
        public List<PassDebugData>?                     PassList                                { get; set; }

        public static RenderGraphDebugData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphDebugData() { Pointer= p0 };

            value.PassList                                  = GetEnumList<PassDebugData>(new IntPtr(p + 0x010)); // 0246690BEC80 0x10 PassList                    ( 000185D2A1D8 ModelEnumListType List`1<PassDebugData> List`1<PassDebugData> List<PassDebugData> Pointer )

            return value;
        }
    }
}
