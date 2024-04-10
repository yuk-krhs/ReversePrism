using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 maxPointers                              int IL2CPP_TYPE_I4
    // 004 invalidPointerId                         int IL2CPP_TYPE_I4
    // 008 mousePointerId                           int IL2CPP_TYPE_I4
    // 00C touchPointerIdBase                       int IL2CPP_TYPE_I4
    // 010 TouchPointerCount                        0001865F50A0 ModelPrimitiveType int int int Int32
    // 014 PenPointerIdBase                         0001865F50A0 ModelPrimitiveType int int int Int32
    // 018 PenPointerCount                          0001865F50A0 ModelPrimitiveType int int int Int32
    // 020 HoveringPointers                         000185B7DDE0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class PointerId : DataModel
    {
        public int                                      TouchPointerCount                       { get; set; }
        public int                                      PenPointerIdBase                        { get; set; }
        public int                                      PenPointerCount                         { get; set; }
        public List<int>?                               HoveringPointers                        { get; set; }

        public static PointerId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerId() { Pointer= p0 };

            value.TouchPointerCount                         = GetInt32(new IntPtr(p + 0x010)); // 0245A676D808 0x10 TouchPointerCount           ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.PenPointerIdBase                          = GetInt32(new IntPtr(p + 0x014)); // 0245A676D828 0x14 PenPointerIdBase            ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.PenPointerCount                           = GetInt32(new IntPtr(p + 0x018)); // 0245A676D848 0x18 PenPointerCount             ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.HoveringPointers                          = GetInt32List(new IntPtr(p + 0x020)); // 0245A676D868 0x20 HoveringPointers            ( 000185B7DDE0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
