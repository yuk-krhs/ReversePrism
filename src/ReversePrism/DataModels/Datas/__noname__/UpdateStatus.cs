using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kWindowSize                              int IL2CPP_TYPE_I4
    // 010 WindowStart                              ModelPrimitiveType int int int Int32
    // 014 NumWindowLateUpdateMoves                 ModelPrimitiveType int int int Int32
    // 018 NumWindowFixedUpdateMoves                ModelPrimitiveType int int int Int32
    // 01C NumWindows                               ModelPrimitiveType int int int Int32
    // 020 LastFrameUpdated                         ModelPrimitiveType int int int Int32
    // 024 LastPos                                  ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 064 PreferredUpdate                          ModelEnumType UpdateClock UpdateClock UpdateClock Int32
    public partial class UpdateStatus : DataModel
    {
        public int                                      WindowStart                             { get; set; }
        public int                                      NumWindowLateUpdateMoves                { get; set; }
        public int                                      NumWindowFixedUpdateMoves               { get; set; }
        public int                                      NumWindows                              { get; set; }
        public int                                      LastFrameUpdated                        { get; set; }
        public Matrix4x4                                LastPos                                 { get; set; }
        public UpdateClock                              PreferredUpdate                         { get; set; }

        public static UpdateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateStatus() { Pointer= p0 };

            value.WindowStart                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 WindowStart                 ( ModelPrimitiveType int int int Int32 )
            value.NumWindowLateUpdateMoves                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 NumWindowLateUpdateMoves    ( ModelPrimitiveType int int int Int32 )
            value.NumWindowFixedUpdateMoves                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 NumWindowFixedUpdateMoves   ( ModelPrimitiveType int int int Int32 )
            value.NumWindows                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NumWindows                  ( ModelPrimitiveType int int int Int32 )
            value.LastFrameUpdated                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 LastFrameUpdated            ( ModelPrimitiveType int int int Int32 )
            value.LastPos                                   = (Matrix4x4)GetInt32(new IntPtr(p + 0x024)); // 0x24 LastPos                     ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.PreferredUpdate                           = (UpdateClock)GetInt32(new IntPtr(p + 0x064)); // 0x64 PreferredUpdate             ( ModelEnumType UpdateClock UpdateClock UpdateClock Int32 )

            return value;
        }
    }
}
