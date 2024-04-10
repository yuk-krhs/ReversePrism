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
    public partial class RTHandleProperties : DataModel
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
            var value   = new RTHandleProperties() { Pointer= p0 };

            value.PreviousViewportSize                      = (Vector2Int)GetInt32(new IntPtr(p + 0x010)); // 024660AB6768 0x10 PreviousViewportSize        ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.PreviousRenderTargetSize                  = (Vector2Int)GetInt32(new IntPtr(p + 0x018)); // 024660AB6788 0x18 PreviousRenderTargetSize    ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.CurrentViewportSize                       = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 024660AB67A8 0x20 CurrentViewportSize         ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.CurrentRenderTargetSize                   = (Vector2Int)GetInt32(new IntPtr(p + 0x028)); // 024660AB67C8 0x28 CurrentRenderTargetSize     ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.RtHandleScale                             = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 024660AB67E8 0x30 RtHandleScale               ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
