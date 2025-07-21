using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Channel                                  ModelClassType Channel Channel Channel Pointer
    // 018 Authorization                            ModelPrimitiveType string string string String
    // 020 ResourceVersion                          ModelPrimitiveType string string string String
    // 028 Cryptographer                            ModelClassType ICryptographer ICryptographer ICryptographer Pointer
    // 030 Trace                                    ModelClassType TraceContext TraceContext TraceContext Pointer
    // 038 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 040 TimeoutMs                                ModelPrimitiveType int int int Int32
    // 048 <CallObserver>k__BackingField            IObserver`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 Logger                                   ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer
    public partial class InvokerContext : DataModel
    {
        public Channel?                                 Channel                                 { get; set; }
        public string                                   Authorization                           { get; set; }
        public string                                   ResourceVersion                         { get; set; }
        public ICryptographer?                          Cryptographer                           { get; set; }
        public TraceContext?                            Trace                                   { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public int                                      TimeoutMs                               { get; set; }
        public NetworkLoggerBase?                       Logger                                  { get; set; }

        public static InvokerContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvokerContext() { Pointer= p0 };

            value.Channel                                   = GetObject<Channel>(new IntPtr(p + 0x010), ReversePrism.DataModels.Channel.FromPointer); // 0x10 Channel                     ( ModelClassType Channel Channel Channel Pointer )
            value.Authorization                             = GetString(new IntPtr(p + 0x018)); // 0x18 Authorization               ( ModelPrimitiveType string string string String )
            value.ResourceVersion                           = GetString(new IntPtr(p + 0x020)); // 0x20 ResourceVersion             ( ModelPrimitiveType string string string String )
            value.Cryptographer                             = GetObject<ICryptographer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICryptographer.FromPointer); // 0x28 Cryptographer               ( ModelClassType ICryptographer ICryptographer ICryptographer Pointer )
            value.Trace                                     = GetObject<TraceContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.TraceContext.FromPointer); // 0x30 Trace                       ( ModelClassType TraceContext TraceContext TraceContext Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x038)); // 0x38 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.TimeoutMs                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 TimeoutMs                   ( ModelPrimitiveType int int int Int32 )
            value.Logger                                    = GetObject<NetworkLoggerBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.NetworkLoggerBase.FromPointer); // 0x50 Logger                      ( ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer )

            return value;
        }
    }
}
