using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CpuFrameTime                             ModelPrimitiveType double double double Double
    // 018 CpuMainThreadFrameTime                   ModelPrimitiveType double double double Double
    // 020 CpuMainThreadPresentWaitTime             ModelPrimitiveType double double double Double
    // 028 CpuRenderThreadFrameTime                 ModelPrimitiveType double double double Double
    // 030 GpuFrameTime                             ModelPrimitiveType double double double Double
    // 038 FrameStartTimestamp                      ModelPrimitiveType ulong ulong ulong UInt64
    // 040 FirstSubmitTimestamp                     ModelPrimitiveType ulong ulong ulong UInt64
    // 048 CpuTimePresentCalled                     ModelPrimitiveType ulong ulong ulong UInt64
    // 050 CpuTimeFrameComplete                     ModelPrimitiveType ulong ulong ulong UInt64
    // 058 HeightScale                              ModelPrimitiveType float float float Single
    // 05C WidthScale                               ModelPrimitiveType float float float Single
    // 060 SyncInterval                             ModelPrimitiveType uint uint uint UInt32
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

            value.CpuFrameTime                              = GetDouble(new IntPtr(p + 0x010)); // 0x10 CpuFrameTime                ( ModelPrimitiveType double double double Double )
            value.CpuMainThreadFrameTime                    = GetDouble(new IntPtr(p + 0x018)); // 0x18 CpuMainThreadFrameTime      ( ModelPrimitiveType double double double Double )
            value.CpuMainThreadPresentWaitTime              = GetDouble(new IntPtr(p + 0x020)); // 0x20 CpuMainThreadPresentWaitTime ( ModelPrimitiveType double double double Double )
            value.CpuRenderThreadFrameTime                  = GetDouble(new IntPtr(p + 0x028)); // 0x28 CpuRenderThreadFrameTime    ( ModelPrimitiveType double double double Double )
            value.GpuFrameTime                              = GetDouble(new IntPtr(p + 0x030)); // 0x30 GpuFrameTime                ( ModelPrimitiveType double double double Double )
            value.FrameStartTimestamp                       = GetUInt64(new IntPtr(p + 0x038)); // 0x38 FrameStartTimestamp         ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.FirstSubmitTimestamp                      = GetUInt64(new IntPtr(p + 0x040)); // 0x40 FirstSubmitTimestamp        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CpuTimePresentCalled                      = GetUInt64(new IntPtr(p + 0x048)); // 0x48 CpuTimePresentCalled        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CpuTimeFrameComplete                      = GetUInt64(new IntPtr(p + 0x050)); // 0x50 CpuTimeFrameComplete        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.HeightScale                               = GetSingle(new IntPtr(p + 0x058)); // 0x58 HeightScale                 ( ModelPrimitiveType float float float Single )
            value.WidthScale                                = GetSingle(new IntPtr(p + 0x05C)); // 0x5C WidthScale                  ( ModelPrimitiveType float float float Single )
            value.SyncInterval                              = GetUInt32(new IntPtr(p + 0x060)); // 0x60 SyncInterval                ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
