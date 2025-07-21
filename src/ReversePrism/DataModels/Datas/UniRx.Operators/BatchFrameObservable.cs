using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 source                                   IObservable`1<Unit> IL2CPP_TYPE_GENERICINST
    // 020 FrameCount                               ModelPrimitiveType int int int Int32
    // 024 FrameCountType                           ModelEnumType FrameCountType FrameCountType FrameCountType Int32
    public partial class BatchFrameObservable : DataModel
    {
        public int                                      FrameCount                              { get; set; }
        public FrameCountType                           FrameCountType                          { get; set; }

        public static BatchFrameObservable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchFrameObservable() { Pointer= p0 };

            value.FrameCount                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 FrameCount                  ( ModelPrimitiveType int int int Int32 )
            value.FrameCountType                            = (FrameCountType)GetInt32(new IntPtr(p + 0x024)); // 0x24 FrameCountType              ( ModelEnumType FrameCountType FrameCountType FrameCountType Int32 )

            return value;
        }
    }
}
