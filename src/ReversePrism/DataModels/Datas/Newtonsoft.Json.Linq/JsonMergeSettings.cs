using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MergeArrayHandling                       0001865FECE0 ModelEnumType MergeArrayHandling MergeArrayHandling MergeArrayHandling Int32
    // 014 MergeNullValueHandling                   0001865FFB00 ModelEnumType MergeNullValueHandling MergeNullValueHandling MergeNullValueHandling Int32
    // 018 PropertyNameComparison                   0001865BBBC0 ModelEnumType StringComparison StringComparison StringComparison Int32
    public partial class JsonMergeSettings
    {
        public MergeArrayHandling                       MergeArrayHandling                      { get; set; }
        public MergeNullValueHandling                   MergeNullValueHandling                  { get; set; }
        public StringComparison                         PropertyNameComparison                  { get; set; }

        public static JsonMergeSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonMergeSettings();

            value.MergeArrayHandling                        = (MergeArrayHandling)GetInt32(new IntPtr(p + 0x010)); // 0270D87EDC98 0x10 MergeArrayHandling          ( 0001865FECE0 ModelEnumType MergeArrayHandling MergeArrayHandling MergeArrayHandling Int32 )
            value.MergeNullValueHandling                    = (MergeNullValueHandling)GetInt32(new IntPtr(p + 0x014)); // 0270D87EDCB8 0x14 MergeNullValueHandling      ( 0001865FFB00 ModelEnumType MergeNullValueHandling MergeNullValueHandling MergeNullValueHandling Int32 )
            value.PropertyNameComparison                    = (StringComparison)GetInt32(new IntPtr(p + 0x018)); // 0270D87EDCD8 0x18 PropertyNameComparison      ( 0001865BBBC0 ModelEnumType StringComparison StringComparison StringComparison Int32 )

            return value;
        }
    }
}
