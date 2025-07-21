using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadyObservable                          ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 Logger                                   ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer
    // 020 ForceErrorException                      ModelClassType Exception Exception Exception Pointer
    // 028 Channel                                  ModelClassType Channel Channel Channel Pointer
    // 030 Config                                   ModelClassType IServerConfig IServerConfig IServerConfig Pointer
    // 038 Cryptographer                            ModelClassType ICryptographer ICryptographer ICryptographer Pointer
    // 040 IsDisposed                               ModelPrimitiveType bool bool bool Bool
    // 041 IsShutdown                               ModelPrimitiveType bool bool bool Bool
    // 048 Semaphore                                ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer
    // 050 communicationObserver                    IObserver`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class ChannelHandler : DataModel
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
            var value   = new ChannelHandler() { Pointer= p0 };

            value.ReadyObservable                           = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 ReadyObservable             ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.Logger                                    = GetObject<NetworkLoggerBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.NetworkLoggerBase.FromPointer); // 0x18 Logger                      ( ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer )
            value.ForceErrorException                       = GetObject<Exception>(new IntPtr(p + 0x020), ReversePrism.DataModels.Exception.FromPointer); // 0x20 ForceErrorException         ( ModelClassType Exception Exception Exception Pointer )
            value.Channel                                   = GetObject<Channel>(new IntPtr(p + 0x028), ReversePrism.DataModels.Channel.FromPointer); // 0x28 Channel                     ( ModelClassType Channel Channel Channel Pointer )
            value.Config                                    = GetObject<IServerConfig>(new IntPtr(p + 0x030), ReversePrism.DataModels.IServerConfig.FromPointer); // 0x30 Config                      ( ModelClassType IServerConfig IServerConfig IServerConfig Pointer )
            value.Cryptographer                             = GetObject<ICryptographer>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICryptographer.FromPointer); // 0x38 Cryptographer               ( ModelClassType ICryptographer ICryptographer ICryptographer Pointer )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x040)); // 0x40 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsShutdown                                = GetBool(new IntPtr(p + 0x041)); // 0x41 IsShutdown                  ( ModelPrimitiveType bool bool bool Bool )
            value.Semaphore                                 = GetObject<SemaphoreSlim>(new IntPtr(p + 0x048), ReversePrism.DataModels.SemaphoreSlim.FromPointer); // 0x48 Semaphore                   ( ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer )

            return value;
        }
    }
}
