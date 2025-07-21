using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaMotionType                          ModelPrimitiveType int int int Int32
    // 014 MotionType                               ModelEnumType SofaMotionType SofaMotionType SofaMotionType Int32
    public partial class HomeMotionViewModel : DataModel
    {
        public int                                      CharaMotionType                         { get; set; }
        public SofaMotionType                           MotionType                              { get; set; }

        public static HomeMotionViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeMotionViewModel() { Pointer= p0 };

            value.CharaMotionType                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharaMotionType             ( ModelPrimitiveType int int int Int32 )
            value.MotionType                                = (SofaMotionType)GetInt32(new IntPtr(p + 0x014)); // 0x14 MotionType                  ( ModelEnumType SofaMotionType SofaMotionType SofaMotionType Int32 )

            return value;
        }
    }
}
