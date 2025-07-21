using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PreviousViewportSize                     ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 018 PreviousRenderTargetSize                 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 020 CurrentViewportSize                      ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 028 CurrentRenderTargetSize                  ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 030 RtHandleScale                            ModelEnumType Vector4 Vector4 Vector4 Int32
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

            value.PreviousViewportSize                      = (Vector2Int)GetInt32(new IntPtr(p + 0x010)); // 0x10 PreviousViewportSize        ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.PreviousRenderTargetSize                  = (Vector2Int)GetInt32(new IntPtr(p + 0x018)); // 0x18 PreviousRenderTargetSize    ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.CurrentViewportSize                       = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentViewportSize         ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.CurrentRenderTargetSize                   = (Vector2Int)GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentRenderTargetSize     ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.RtHandleScale                             = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0x30 RtHandleScale               ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
