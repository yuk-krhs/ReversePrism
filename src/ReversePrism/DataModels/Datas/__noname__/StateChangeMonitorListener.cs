using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Control                                  0001865EB650 ModelClassType InputControl InputControl InputControl Pointer
    // 018 Monitor                                  000186583720 ModelClassType IInputStateChangeMonitor IInputStateChangeMonitor IInputStateChangeMonitor Pointer
    // 020 MonitorIndex                             0001865F7E40 ModelPrimitiveType long long long Int64
    // 028 GroupIndex                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class StateChangeMonitorListener
    {
        public InputControl?                            Control                                 { get; set; }
        public IInputStateChangeMonitor?                Monitor                                 { get; set; }
        public long                                     MonitorIndex                            { get; set; }
        public uint                                     GroupIndex                              { get; set; }

        public static StateChangeMonitorListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateChangeMonitorListener();

            value.Control                                   = GetObject<InputControl>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputControl.FromPointer); // 0270D771AF80 0x10 Control                     ( 0001865EB650 ModelClassType InputControl InputControl InputControl Pointer )
            value.Monitor                                   = GetObject<IInputStateChangeMonitor>(new IntPtr(p + 0x018), ReversePrism.DataModels.IInputStateChangeMonitor.FromPointer); // 0270D771AFA0 0x18 Monitor                     ( 000186583720 ModelClassType IInputStateChangeMonitor IInputStateChangeMonitor IInputStateChangeMonitor Pointer )
            value.MonitorIndex                              = GetInt64(new IntPtr(p + 0x020)); // 0270D771AFC0 0x20 MonitorIndex                ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.GroupIndex                                = GetUInt32(new IntPtr(p + 0x028)); // 0270D771AFE0 0x28 GroupIndex                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
