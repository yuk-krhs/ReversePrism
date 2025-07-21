using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 structSize                               int IL2CPP_TYPE_I4
    // 010 Type                                     ModelEnumType NativeInputEventType NativeInputEventType NativeInputEventType Int32
    // 014 SizeInBytes                              ModelPrimitiveType ushort ushort ushort UInt16
    // 016 DeviceId                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Time                                     ModelPrimitiveType double double double Double
    // 020 EventId                                  ModelPrimitiveType int int int Int32
    public partial class NativeInputEvent : DataModel
    {
        public NativeInputEventType                     Type                                    { get; set; }
        public ushort                                   SizeInBytes                             { get; set; }
        public ushort                                   DeviceId                                { get; set; }
        public double                                   Time                                    { get; set; }
        public int                                      EventId                                 { get; set; }

        public static NativeInputEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeInputEvent() { Pointer= p0 };

            value.Type                                      = (NativeInputEventType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType NativeInputEventType NativeInputEventType NativeInputEventType Int32 )
            value.SizeInBytes                               = GetUInt16(new IntPtr(p + 0x014)); // 0x14 SizeInBytes                 ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.DeviceId                                  = GetUInt16(new IntPtr(p + 0x016)); // 0x16 DeviceId                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Time                                      = GetDouble(new IntPtr(p + 0x018)); // 0x18 Time                        ( ModelPrimitiveType double double double Double )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 EventId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
