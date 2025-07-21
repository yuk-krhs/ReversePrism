using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PositionData                             ModelClassListType PositionData[] PositionData[] List<PositionData> Pointer
    public partial class PositionDatas : DataModel
    {
        public List<PositionData>?                      PositionData                            { get; set; }

        public static PositionDatas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PositionDatas() { Pointer= p0 };

            value.PositionData                              = GetObjectList<PositionData>(new IntPtr(p + 0x010), ReversePrism.DataModels.PositionData.FromPointer); // 0x10 PositionData                ( ModelClassListType PositionData[] PositionData[] List<PositionData> Pointer )

            return value;
        }
    }
}
