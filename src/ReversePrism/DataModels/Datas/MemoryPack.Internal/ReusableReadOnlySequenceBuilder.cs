using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 segmentPool                              Stack`1<Segment> IL2CPP_TYPE_GENERICINST
    // 018 List                                     ModelClassListType List`1<Segment> List`1<Segment> List<Segment> Pointer
    public partial class ReusableReadOnlySequenceBuilder : DataModel
    {
        public List<Segment>?                           List                                    { get; set; }

        public static ReusableReadOnlySequenceBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReusableReadOnlySequenceBuilder() { Pointer= p0 };

            value.List                                      = GetObjectList<Segment>(new IntPtr(p + 0x018), ReversePrism.DataModels.Segment.FromPointer); // 0x18 List                        ( ModelClassListType List`1<Segment> List`1<Segment> List<Segment> Pointer )

            return value;
        }
    }
}
