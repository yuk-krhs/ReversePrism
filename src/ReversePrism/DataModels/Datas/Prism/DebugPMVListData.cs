using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 PMVDataList                              000185D21668 ModelClassListType List`1<PMVData> List`1<PMVData> List<PMVData> Pointer
    public partial class DebugPMVListData
    {
        public List<PMVData>?                           PMVDataList                             { get; set; }

        public static DebugPMVListData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugPMVListData();

            value.PMVDataList                               = GetObjectList<PMVData>(new IntPtr(p + 0x018), ReversePrism.DataModels.PMVData.FromPointer); // 0270D4CE8AD8 0x18 PMVDataList                 ( 000185D21668 ModelClassListType List`1<PMVData> List`1<PMVData> List<PMVData> Pointer )

            return value;
        }
    }
}
