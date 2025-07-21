using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_NativeBuffer                           ModelEnumType InputEventBuffer InputEventBuffer InputEventBuffer Int32
    // 030 m_CurrentNativeEventReadPtr              IntPtr IL2CPP_TYPE_PTR
    // 038 m_CurrentNativeEventWritePtr             IntPtr IL2CPP_TYPE_PTR
    // 040 M_RemainingNativeEventCount              ModelPrimitiveType int int int Int32
    // 044 M_MaxAppendedEvents                      ModelPrimitiveType int int int Int32
    // 048 M_AppendBuffer                           ModelEnumType InputEventBuffer InputEventBuffer InputEventBuffer Int32
    // 068 m_CurrentAppendEventReadPtr              IntPtr IL2CPP_TYPE_PTR
    // 070 m_CurrentAppendEventWritePtr             IntPtr IL2CPP_TYPE_PTR
    // 078 M_RemainingAppendEventCount              ModelPrimitiveType int int int Int32
    // 07C M_NumEventsRetainedInBuffer              ModelPrimitiveType int int int Int32
    // 080 M_IsOpen                                 ModelPrimitiveType bool bool bool Bool
    public partial class InputEventStream : DataModel
    {
        public InputEventBuffer                         M_NativeBuffer                          { get; set; }
        public int                                      M_RemainingNativeEventCount             { get; set; }
        public int                                      M_MaxAppendedEvents                     { get; set; }
        public InputEventBuffer                         M_AppendBuffer                          { get; set; }
        public int                                      M_RemainingAppendEventCount             { get; set; }
        public int                                      M_NumEventsRetainedInBuffer             { get; set; }
        public bool                                     M_IsOpen                                { get; set; }

        public static InputEventStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputEventStream() { Pointer= p0 };

            value.M_NativeBuffer                            = (InputEventBuffer)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_NativeBuffer              ( ModelEnumType InputEventBuffer InputEventBuffer InputEventBuffer Int32 )
            value.M_RemainingNativeEventCount               = GetInt32(new IntPtr(p + 0x040)); // 0x40 M_RemainingNativeEventCount ( ModelPrimitiveType int int int Int32 )
            value.M_MaxAppendedEvents                       = GetInt32(new IntPtr(p + 0x044)); // 0x44 M_MaxAppendedEvents         ( ModelPrimitiveType int int int Int32 )
            value.M_AppendBuffer                            = (InputEventBuffer)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_AppendBuffer              ( ModelEnumType InputEventBuffer InputEventBuffer InputEventBuffer Int32 )
            value.M_RemainingAppendEventCount               = GetInt32(new IntPtr(p + 0x078)); // 0x78 M_RemainingAppendEventCount ( ModelPrimitiveType int int int Int32 )
            value.M_NumEventsRetainedInBuffer               = GetInt32(new IntPtr(p + 0x07C)); // 0x7C M_NumEventsRetainedInBuffer ( ModelPrimitiveType int int int Int32 )
            value.M_IsOpen                                  = GetBool(new IntPtr(p + 0x080)); // 0x80 M_IsOpen                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
