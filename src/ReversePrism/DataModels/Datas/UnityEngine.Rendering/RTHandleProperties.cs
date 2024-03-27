using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PreviousViewportSize                     0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 018 PreviousRenderTargetSize                 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 020 CurrentViewportSize                      0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 028 CurrentRenderTargetSize                  0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 030 RtHandleScale                            0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class RTHandleProperties
    {
        public Vector2Int                               PreviousViewportSize                    { get; set; }
        public Vector2Int                               PreviousRenderTargetSize                { get; set; }
        public Vector2Int                               CurrentViewportSize                     { get; set; }
        public Vector2Int                               CurrentRenderTargetSize                 { get; set; }
        public Vector4                                  RtHandleScale                           { get; set; }

        public static RTHandleProperties? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RTHandleProperties();

            value.PreviousViewportSize                      = (Vector2Int)GetInt32(new IntPtr(p + 0x010)); // 0270D0AC6F08 0x10 PreviousViewportSize        ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.PreviousRenderTargetSize                  = (Vector2Int)GetInt32(new IntPtr(p + 0x018)); // 0270D0AC6F28 0x18 PreviousRenderTargetSize    ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.CurrentViewportSize                       = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 0270D0AC6F48 0x20 CurrentViewportSize         ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.CurrentRenderTargetSize                   = (Vector2Int)GetInt32(new IntPtr(p + 0x028)); // 0270D0AC6F68 0x28 CurrentRenderTargetSize     ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.RtHandleScale                             = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0270D0AC6F88 0x30 RtHandleScale               ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
