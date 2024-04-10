using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Control                                  0001865EB650 ModelClassType InputControl InputControl InputControl Pointer
    // 018 Time                                     0001865C2E50 ModelPrimitiveType double double double Double
    // 020 Monitor                                  000186583720 ModelClassType IInputStateChangeMonitor IInputStateChangeMonitor IInputStateChangeMonitor Pointer
    // 028 MonitorIndex                             0001865F7E40 ModelPrimitiveType long long long Int64
    // 030 TimerIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class StateChangeMonitorTimeout : DataModel
    {
        public InputControl?                            Control                                 { get; set; }
        public double                                   Time                                    { get; set; }
        public IInputStateChangeMonitor?                Monitor                                 { get; set; }
        public long                                     MonitorIndex                            { get; set; }
        public int                                      TimerIndex                              { get; set; }

        public static StateChangeMonitorTimeout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateChangeMonitorTimeout() { Pointer= p0 };

            value.Control                                   = GetObject<InputControl>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputControl.FromPointer); // 0245A334EA28 0x10 Control                     ( 0001865EB650 ModelClassType InputControl InputControl InputControl Pointer )
            value.Time                                      = GetDouble(new IntPtr(p + 0x018)); // 0245A334EA48 0x18 Time                        ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Monitor                                   = GetObject<IInputStateChangeMonitor>(new IntPtr(p + 0x020), ReversePrism.DataModels.IInputStateChangeMonitor.FromPointer); // 0245A334EA68 0x20 Monitor                     ( 000186583720 ModelClassType IInputStateChangeMonitor IInputStateChangeMonitor IInputStateChangeMonitor Pointer )
            value.MonitorIndex                              = GetInt64(new IntPtr(p + 0x028)); // 0245A334EA88 0x28 MonitorIndex                ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.TimerIndex                                = GetInt32(new IntPtr(p + 0x030)); // 0245A334EAA8 0x30 TimerIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
