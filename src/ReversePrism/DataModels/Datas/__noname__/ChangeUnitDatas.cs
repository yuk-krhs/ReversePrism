using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChangeUnitData                           ModelClassListType ChangeUnitData[] ChangeUnitData[] List<ChangeUnitData> Pointer
    public partial class ChangeUnitDatas : DataModel
    {
        public List<ChangeUnitData>?                    ChangeUnitData                          { get; set; }

        public static ChangeUnitDatas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChangeUnitDatas() { Pointer= p0 };

            value.ChangeUnitData                            = GetObjectList<ChangeUnitData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChangeUnitData.FromPointer); // 0x10 ChangeUnitData              ( ModelClassListType ChangeUnitData[] ChangeUnitData[] List<ChangeUnitData> Pointer )

            return value;
        }
    }
}
