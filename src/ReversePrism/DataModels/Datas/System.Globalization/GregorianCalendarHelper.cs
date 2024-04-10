using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DaysToMonth365                           int[] IL2CPP_TYPE_SZARRAY
    // 008 DaysToMonth366                           int[] IL2CPP_TYPE_SZARRAY
    // 010 M_maxYear                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 M_minYear                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 M_Cal                                    0001865A1130 ModelClassType Calendar Calendar Calendar Pointer
    // 020 M_EraInfo                                000185B7C100 ModelClassListType EraInfo[] EraInfo[] List<EraInfo> Pointer
    // 028 M_eras                                   000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 M_minDate                                0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class GregorianCalendarHelper : DataModel
    {
        public int                                      M_maxYear                               { get; set; }
        public int                                      M_minYear                               { get; set; }
        public Calendar?                                M_Cal                                   { get; set; }
        public List<EraInfo>?                           M_EraInfo                               { get; set; }
        public List<int>?                               M_eras                                  { get; set; }
        public DateTime                                 M_minDate                               { get; set; }

        public static GregorianCalendarHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GregorianCalendarHelper() { Pointer= p0 };

            value.M_maxYear                                 = GetInt32(new IntPtr(p + 0x010)); // 024662FD5DB0 0x10 M_maxYear                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_minYear                                 = GetInt32(new IntPtr(p + 0x014)); // 024662FD5DD0 0x14 M_minYear                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_Cal                                     = GetObject<Calendar>(new IntPtr(p + 0x018), ReversePrism.DataModels.Calendar.FromPointer); // 024662FD5DF0 0x18 M_Cal                       ( 0001865A1130 ModelClassType Calendar Calendar Calendar Pointer )
            value.M_EraInfo                                 = GetObjectList<EraInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.EraInfo.FromPointer); // 024662FD5E10 0x20 M_EraInfo                   ( 000185B7C100 ModelClassListType EraInfo[] EraInfo[] List<EraInfo> Pointer )
            value.M_eras                                    = GetInt32List(new IntPtr(p + 0x028)); // 024662FD5E30 0x28 M_eras                      ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_minDate                                 = GetDateTime(new IntPtr(p + 0x030)); // 024662FD5E50 0x30 M_minDate                   ( 0001865B9320 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
