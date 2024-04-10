using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CpuFrameTime                             0001865C2E50 ModelPrimitiveType double double double Double
    // 018 CpuMainThreadFrameTime                   0001865C2E50 ModelPrimitiveType double double double Double
    // 020 CpuMainThreadPresentWaitTime             0001865C2E50 ModelPrimitiveType double double double Double
    // 028 CpuRenderThreadFrameTime                 0001865C2E50 ModelPrimitiveType double double double Double
    // 030 GpuFrameTime                             0001865C2E50 ModelPrimitiveType double double double Double
    // 038 FrameStartTimestamp                      00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 040 FirstSubmitTimestamp                     00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 048 CpuTimePresentCalled                     00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 050 CpuTimeFrameComplete                     00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 058 HeightScale                              000186666050 ModelPrimitiveType float float float Single
    // 05C WidthScale                               000186666050 ModelPrimitiveType float float float Single
    // 060 SyncInterval                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class FrameTiming : DataModel
    {
        public double                                   CpuFrameTime                            { get; set; }
        public double                                   CpuMainThreadFrameTime                  { get; set; }
        public double                                   CpuMainThreadPresentWaitTime            { get; set; }
        public double                                   CpuRenderThreadFrameTime                { get; set; }
        public double                                   GpuFrameTime                            { get; set; }
        public ulong                                    FrameStartTimestamp                     { get; set; }
        public ulong                                    FirstSubmitTimestamp                    { get; set; }
        public ulong                                    CpuTimePresentCalled                    { get; set; }
        public ulong                                    CpuTimeFrameComplete                    { get; set; }
        public float                                    HeightScale                             { get; set; }
        public float                                    WidthScale                              { get; set; }
        public uint                                     SyncInterval                            { get; set; }

        public static FrameTiming? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameTiming() { Pointer= p0 };

            value.CpuFrameTime                              = GetDouble(new IntPtr(p + 0x010)); // 0245A686DD48 0x10 CpuFrameTime                ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.CpuMainThreadFrameTime                    = GetDouble(new IntPtr(p + 0x018)); // 0245A686DD68 0x18 CpuMainThreadFrameTime      ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.CpuMainThreadPresentWaitTime              = GetDouble(new IntPtr(p + 0x020)); // 0245A686DD88 0x20 CpuMainThreadPresentWaitTime ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.CpuRenderThreadFrameTime                  = GetDouble(new IntPtr(p + 0x028)); // 0245A686DDA8 0x28 CpuRenderThreadFrameTime    ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.GpuFrameTime                              = GetDouble(new IntPtr(p + 0x030)); // 0245A686DDC8 0x30 GpuFrameTime                ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.FrameStartTimestamp                       = GetUInt64(new IntPtr(p + 0x038)); // 0245A686DDE8 0x38 FrameStartTimestamp         ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.FirstSubmitTimestamp                      = GetUInt64(new IntPtr(p + 0x040)); // 0245A686DE08 0x40 FirstSubmitTimestamp        ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CpuTimePresentCalled                      = GetUInt64(new IntPtr(p + 0x048)); // 0245A686DE28 0x48 CpuTimePresentCalled        ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CpuTimeFrameComplete                      = GetUInt64(new IntPtr(p + 0x050)); // 0245A686DE48 0x50 CpuTimeFrameComplete        ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.HeightScale                               = GetSingle(new IntPtr(p + 0x058)); // 0245A686DE68 0x58 HeightScale                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.WidthScale                                = GetSingle(new IntPtr(p + 0x05C)); // 0245A686DE88 0x5C WidthScale                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.SyncInterval                              = GetUInt32(new IntPtr(p + 0x060)); // 0245A686DEA8 0x60 SyncInterval                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
