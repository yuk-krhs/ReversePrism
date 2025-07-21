using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_hebrewValues                           HebrewValue[] IL2CPP_TYPE_SZARRAY
    // 008 s_maxHebrewNumberCh                      char IL2CPP_TYPE_CHAR
    // 010 S_numberPasingState                      ModelEnumListType HS[] HS[] List<HS> Pointer
    public partial class HebrewNumber : DataModel
    {
        public List<HS>?                                S_numberPasingState                     { get; set; }

        public static HebrewNumber? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HebrewNumber() { Pointer= p0 };

            value.S_numberPasingState                       = GetEnumList<HS>(new IntPtr(p + 0x010)); // 0x10 S_numberPasingState         ( ModelEnumListType HS[] HS[] List<HS> Pointer )

            return value;
        }
    }
}
