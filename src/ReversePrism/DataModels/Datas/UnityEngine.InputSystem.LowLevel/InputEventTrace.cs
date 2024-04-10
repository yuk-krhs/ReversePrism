using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kDefaultBufferSize                       int IL2CPP_TYPE_I4
    // 010 M_ChangeCounter                          0001865F5290 ModelPrimitiveType int int int Int32
    // 014 M_Enabled                                0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 018 m_OnFilterEvent                          Func`3<InputEventPtr, InputDevice, bool> IL2CPP_TYPE_GENERICINST
    // 020 M_DeviceId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 m_EventListeners                         CallbackArray`1<Action`1<InputEventPtr>> IL2CPP_TYPE_GENERICINST
    // 078 M_EventBufferSize                        0001865F7700 ModelPrimitiveType long long long Int64
    // 080 M_MaxEventBufferSize                     0001865F7700 ModelPrimitiveType long long long Int64
    // 088 M_GrowIncrementSize                      0001865F7700 ModelPrimitiveType long long long Int64
    // 090 M_EventCount                             0001865F7700 ModelPrimitiveType long long long Int64
    // 098 M_EventSizeInBytes                       0001865F7700 ModelPrimitiveType long long long Int64
    // 0A0 M_EventBufferStorage                     00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 0A8 M_EventBufferHeadStorage                 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 0B0 M_EventBufferTailStorage                 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 0B8 M_HasWrapped                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B9 M_RecordFrameMarkers                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C0 M_DeviceInfos                            000185CBD978 ModelEnumListType DeviceInfo[] DeviceInfo[] List<DeviceInfo> Pointer
    // 000 kFileVersion                             int IL2CPP_TYPE_I4
    public partial class InputEventTrace : DataModel
    {
        public int                                      M_ChangeCounter                         { get; set; }
        public bool                                     M_Enabled                               { get; set; }
        public int                                      M_DeviceId                              { get; set; }
        public long                                     M_EventBufferSize                       { get; set; }
        public long                                     M_MaxEventBufferSize                    { get; set; }
        public long                                     M_GrowIncrementSize                     { get; set; }
        public long                                     M_EventCount                            { get; set; }
        public long                                     M_EventSizeInBytes                      { get; set; }
        public ulong                                    M_EventBufferStorage                    { get; set; }
        public ulong                                    M_EventBufferHeadStorage                { get; set; }
        public ulong                                    M_EventBufferTailStorage                { get; set; }
        public bool                                     M_HasWrapped                            { get; set; }
        public bool                                     M_RecordFrameMarkers                    { get; set; }
        public List<DeviceInfo>?                        M_DeviceInfos                           { get; set; }

        public static InputEventTrace? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputEventTrace() { Pointer= p0 };

            value.M_ChangeCounter                           = GetInt32(new IntPtr(p + 0x010)); // 024667874180 0x10 M_ChangeCounter             ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x014)); // 0246678741A0 0x14 M_Enabled                   ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.M_DeviceId                                = GetInt32(new IntPtr(p + 0x020)); // 0246678741E0 0x20 M_DeviceId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_EventBufferSize                         = GetInt64(new IntPtr(p + 0x078)); // 024667874220 0x78 M_EventBufferSize           ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_MaxEventBufferSize                      = GetInt64(new IntPtr(p + 0x080)); // 024667874240 0x80 M_MaxEventBufferSize        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_GrowIncrementSize                       = GetInt64(new IntPtr(p + 0x088)); // 024667874260 0x88 M_GrowIncrementSize         ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_EventCount                              = GetInt64(new IntPtr(p + 0x090)); // 024667874280 0x90 M_EventCount                ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_EventSizeInBytes                        = GetInt64(new IntPtr(p + 0x098)); // 0246678742A0 0x98 M_EventSizeInBytes          ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_EventBufferStorage                      = GetUInt64(new IntPtr(p + 0x0A0)); // 0246678742C0 0xA0 M_EventBufferStorage        ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_EventBufferHeadStorage                  = GetUInt64(new IntPtr(p + 0x0A8)); // 0246678742E0 0xA8 M_EventBufferHeadStorage    ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_EventBufferTailStorage                  = GetUInt64(new IntPtr(p + 0x0B0)); // 024667874300 0xB0 M_EventBufferTailStorage    ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_HasWrapped                              = GetBool(new IntPtr(p + 0x0B8)); // 024667874320 0xB8 M_HasWrapped                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RecordFrameMarkers                      = GetBool(new IntPtr(p + 0x0B9)); // 024667874340 0xB9 M_RecordFrameMarkers        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DeviceInfos                             = GetEnumList<DeviceInfo>(new IntPtr(p + 0x0C0)); // 024667874360 0xC0 M_DeviceInfos               ( 000185CBD978 ModelEnumListType DeviceInfo[] DeviceInfo[] List<DeviceInfo> Pointer )

            return value;
        }
    }
}
