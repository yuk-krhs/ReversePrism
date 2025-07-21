using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 lowMemory                                LowMemoryCallback IL2CPP_TYPE_CLASS
    // 008 memoryUsageChanged                       MemoryUsageChangedCallback IL2CPP_TYPE_CLASS
    // 010 S_LogCallbackHandler                     ModelClassType LogCallback LogCallback LogCallback Pointer
    // 018 S_LogCallbackHandlerThreaded             ModelClassType LogCallback LogCallback LogCallback Pointer
    // 020 focusChanged                             Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 028 deepLinkActivated                        Action`1<string> IL2CPP_TYPE_GENERICINST
    // 030 wantsToQuit                              Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 Quitting                                 ModelClassType Action Action Action Pointer
    // 040 Unloading                                ModelClassType Action Action Action Pointer
    // 048 S_currentCancellationTokenSource         ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 050 S_RegisterLogCallbackDeprecated          ModelClassType LogCallback LogCallback LogCallback Pointer
    public partial class Application : DataModel
    {
        public LogCallback?                             S_LogCallbackHandler                    { get; set; }
        public LogCallback?                             S_LogCallbackHandlerThreaded            { get; set; }
        public Action?                                  Quitting                                { get; set; }
        public Action?                                  Unloading                               { get; set; }
        public CancellationTokenSource?                 S_currentCancellationTokenSource        { get; set; }
        public LogCallback?                             S_RegisterLogCallbackDeprecated         { get; set; }

        public static Application? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Application() { Pointer= p0 };

            value.S_LogCallbackHandler                      = GetObject<LogCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.LogCallback.FromPointer); // 0x10 S_LogCallbackHandler        ( ModelClassType LogCallback LogCallback LogCallback Pointer )
            value.S_LogCallbackHandlerThreaded              = GetObject<LogCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.LogCallback.FromPointer); // 0x18 S_LogCallbackHandlerThreaded ( ModelClassType LogCallback LogCallback LogCallback Pointer )
            value.Quitting                                  = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 0x38 Quitting                    ( ModelClassType Action Action Action Pointer )
            value.Unloading                                 = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 0x40 Unloading                   ( ModelClassType Action Action Action Pointer )
            value.S_currentCancellationTokenSource          = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x48 S_currentCancellationTokenSource ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.S_RegisterLogCallbackDeprecated           = GetObject<LogCallback>(new IntPtr(p + 0x050), ReversePrism.DataModels.LogCallback.FromPointer); // 0x50 S_RegisterLogCallbackDeprecated ( ModelClassType LogCallback LogCallback LogCallback Pointer )

            return value;
        }
    }
}
