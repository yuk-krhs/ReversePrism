using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadyObservable                          000186769840 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 Logger                                   00018669C140 ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer
    // 020 ForceErrorException                      0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 028 Channel                                  00018658F200 ModelClassType Channel Channel Channel Pointer
    // 030 Config                                   000186637CE0 ModelClassType IServerConfig IServerConfig IServerConfig Pointer
    // 038 Cryptographer                            000186747370 ModelClassType ICryptographer ICryptographer ICryptographer Pointer
    // 040 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsShutdown                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 Semaphore                                0001867235F0 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer
    // 050 communicationObserver                    IObserver`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class ChannelHandler
    {
        public BoolReactiveProperty?                    ReadyObservable                         { get; set; }
        public NetworkLoggerBase?                       Logger                                  { get; set; }
        public Exception?                               ForceErrorException                     { get; set; }
        public Channel?                                 Channel                                 { get; set; }
        public IServerConfig?                           Config                                  { get; set; }
        public ICryptographer?                          Cryptographer                           { get; set; }
        public bool                                     IsDisposed                              { get; set; }
        public bool                                     IsShutdown                              { get; set; }
        public SemaphoreSlim?                           Semaphore                               { get; set; }

        public static ChannelHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelHandler();

            value.ReadyObservable                           = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270D0E88388 0x10 ReadyObservable             ( 000186769840 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.Logger                                    = GetObject<NetworkLoggerBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.NetworkLoggerBase.FromPointer); // 0270D0E883A8 0x18 Logger                      ( 00018669C140 ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer )
            value.ForceErrorException                       = GetObject<Exception>(new IntPtr(p + 0x020), ReversePrism.DataModels.Exception.FromPointer); // 0270D0E883C8 0x20 ForceErrorException         ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.Channel                                   = GetObject<Channel>(new IntPtr(p + 0x028), ReversePrism.DataModels.Channel.FromPointer); // 0270D0E883E8 0x28 Channel                     ( 00018658F200 ModelClassType Channel Channel Channel Pointer )
            value.Config                                    = GetObject<IServerConfig>(new IntPtr(p + 0x030), ReversePrism.DataModels.IServerConfig.FromPointer); // 0270D0E88408 0x30 Config                      ( 000186637CE0 ModelClassType IServerConfig IServerConfig IServerConfig Pointer )
            value.Cryptographer                             = GetObject<ICryptographer>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICryptographer.FromPointer); // 0270D0E88428 0x38 Cryptographer               ( 000186747370 ModelClassType ICryptographer ICryptographer ICryptographer Pointer )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x040)); // 0270D0E88448 0x40 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsShutdown                                = GetBool(new IntPtr(p + 0x041)); // 0270D0E88468 0x41 IsShutdown                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Semaphore                                 = GetObject<SemaphoreSlim>(new IntPtr(p + 0x048), ReversePrism.DataModels.SemaphoreSlim.FromPointer); // 0270D0E88488 0x48 Semaphore                   ( 0001867235F0 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer )

            return value;
        }
    }
}
