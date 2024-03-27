using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitIdolData                             000185CC52F8 ModelClassListType UnitIdolData[] UnitIdolData[] List<UnitIdolData> Pointer
    public partial class UnitIdolDatas
    {
        public List<UnitIdolData>?                      UnitIdolData                            { get; set; }

        public static UnitIdolDatas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitIdolDatas();

            value.UnitIdolData                              = GetObjectList<UnitIdolData>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnitIdolData.FromPointer); // 027005FCCCC0 0x10 UnitIdolData                ( 000185CC52F8 ModelClassListType UnitIdolData[] UnitIdolData[] List<UnitIdolData> Pointer )

            return value;
        }
    }
}
