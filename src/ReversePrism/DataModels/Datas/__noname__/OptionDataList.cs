using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Options                                ModelClassListType List`1<OptionData> List`1<OptionData> List<OptionData> Pointer
    public partial class OptionDataList : DataModel
    {
        public List<OptionData>?                        M_Options                               { get; set; }

        public static OptionDataList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionDataList() { Pointer= p0 };

            value.M_Options                                 = GetObjectList<OptionData>(new IntPtr(p + 0x010), ReversePrism.DataModels.OptionData.FromPointer); // 0x10 M_Options                   ( ModelClassListType List`1<OptionData> List`1<OptionData> List<OptionData> Pointer )

            return value;
        }
    }
}
