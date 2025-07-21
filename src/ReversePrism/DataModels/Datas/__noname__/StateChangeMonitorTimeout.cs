using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Control                                  ModelClassType InputControl InputControl InputControl Pointer
    // 018 Time                                     ModelPrimitiveType double double double Double
    // 020 Monitor                                  ModelClassType IInputStateChangeMonitor IInputStateChangeMonitor IInputStateChangeMonitor Pointer
    // 028 MonitorIndex                             ModelPrimitiveType long long long Int64
    // 030 TimerIndex                               ModelPrimitiveType int int int Int32
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

            value.Control                                   = GetObject<InputControl>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputControl.FromPointer); // 0x10 Control                     ( ModelClassType InputControl InputControl InputControl Pointer )
            value.Time                                      = GetDouble(new IntPtr(p + 0x018)); // 0x18 Time                        ( ModelPrimitiveType double double double Double )
            value.Monitor                                   = GetObject<IInputStateChangeMonitor>(new IntPtr(p + 0x020), ReversePrism.DataModels.IInputStateChangeMonitor.FromPointer); // 0x20 Monitor                     ( ModelClassType IInputStateChangeMonitor IInputStateChangeMonitor IInputStateChangeMonitor Pointer )
            value.MonitorIndex                              = GetInt64(new IntPtr(p + 0x028)); // 0x28 MonitorIndex                ( ModelPrimitiveType long long long Int64 )
            value.TimerIndex                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 TimerIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
