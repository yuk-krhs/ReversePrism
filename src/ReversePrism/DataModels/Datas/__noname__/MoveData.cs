using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Time                                     000186666050 ModelPrimitiveType float float float Single
    // 014 Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 018 SrcPos                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 SrcRot                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 DstPos                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C DstRot                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class MoveData : DataModel
    {
        public float                                    Time                                    { get; set; }
        public float                                    Duration                                { get; set; }
        public Vector3                                  SrcPos                                  { get; set; }
        public Vector3                                  SrcRot                                  { get; set; }
        public Vector3                                  DstPos                                  { get; set; }
        public Vector3                                  DstRot                                  { get; set; }

        public static MoveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoveData() { Pointer= p0 };

            value.Time                                      = GetSingle(new IntPtr(p + 0x010)); // 024665E609F0 0x10 Time                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x014)); // 024665E60A10 0x14 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.SrcPos                                    = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 024665E60A30 0x18 SrcPos                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.SrcRot                                    = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 024665E60A50 0x24 SrcRot                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.DstPos                                    = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 024665E60A70 0x30 DstPos                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.DstRot                                    = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 024665E60A90 0x3C DstRot                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
