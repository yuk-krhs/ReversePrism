using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 points                                   NativeArray`1<double2> IL2CPP_TYPE_GENERICINST
    // 020 edges                                    NativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 030 Xvasort                                  ModelEnumType <xvasort>e__FixedBuffer <xvasort>e__FixedBuffer <xvasort>e__FixedBuffer Int32
    // 050 Xvbsort                                  ModelEnumType <xvbsort>e__FixedBuffer <xvbsort>e__FixedBuffer <xvbsort>e__FixedBuffer Int32
    public partial class IntersectionCompare : DataModel
    {
        public <xvasort>e__FixedBuffer                  Xvasort                                 { get; set; }
        public <xvbsort>e__FixedBuffer                  Xvbsort                                 { get; set; }

        public static IntersectionCompare? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntersectionCompare() { Pointer= p0 };

            value.Xvasort                                   = (<xvasort>e__FixedBuffer)GetInt32(new IntPtr(p + 0x030)); // 0x30 Xvasort                     ( ModelEnumType <xvasort>e__FixedBuffer <xvasort>e__FixedBuffer <xvasort>e__FixedBuffer Int32 )
            value.Xvbsort                                   = (<xvbsort>e__FixedBuffer)GetInt32(new IntPtr(p + 0x050)); // 0x50 Xvbsort                     ( ModelEnumType <xvbsort>e__FixedBuffer <xvbsort>e__FixedBuffer <xvbsort>e__FixedBuffer Int32 )

            return value;
        }
    }
}
