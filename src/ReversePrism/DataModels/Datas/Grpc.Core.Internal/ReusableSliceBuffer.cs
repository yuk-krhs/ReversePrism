using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxCachedSegments                        int IL2CPP_TYPE_I4
    // 010 CachedSegments                           000185CC1908 ModelClassListType SliceSegment[] SliceSegment[] List<SliceSegment> Pointer
    // 018 PopulatedSegmentCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ReusableSliceBuffer
    {
        public List<SliceSegment>?                      CachedSegments                          { get; set; }
        public int                                      PopulatedSegmentCount                   { get; set; }

        public static ReusableSliceBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReusableSliceBuffer();

            value.CachedSegments                            = GetObjectList<SliceSegment>(new IntPtr(p + 0x010), ReversePrism.DataModels.SliceSegment.FromPointer); // 0270D304F4C0 0x10 CachedSegments              ( 000185CC1908 ModelClassListType SliceSegment[] SliceSegment[] List<SliceSegment> Pointer )
            value.PopulatedSegmentCount                     = GetInt32(new IntPtr(p + 0x018)); // 0270D304F4E0 0x18 PopulatedSegmentCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
