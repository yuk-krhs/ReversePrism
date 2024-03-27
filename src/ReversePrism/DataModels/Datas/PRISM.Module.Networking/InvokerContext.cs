using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Channel                                  00018658F970 ModelClassType Channel Channel Channel Pointer
    // 018 Authorization                            000186672F10 ModelPrimitiveType string string string String
    // 020 ResourceVersion                          000186672F10 ModelPrimitiveType string string string String
    // 028 Cryptographer                            000186747640 ModelClassType ICryptographer ICryptographer ICryptographer Pointer
    // 030 Trace                                    000186696650 ModelClassType TraceContext TraceContext TraceContext Pointer
    // 038 CancellationToken                        00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 040 TimeoutMs                                0001865F4260 ModelPrimitiveType int int int Int32
    // 048 <CallObserver>k__BackingField            IObserver`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 Logger                                   00018669C140 ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer
    public partial class InvokerContext
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
            var value   = new InvokerContext();

            value.Channel                                   = GetObject<Channel>(new IntPtr(p + 0x010), ReversePrism.DataModels.Channel.FromPointer); // 027004B30AE0 0x10 Channel                     ( 00018658F970 ModelClassType Channel Channel Channel Pointer )
            value.Authorization                             = GetString(new IntPtr(p + 0x018)); // 027004B30B00 0x18 Authorization               ( 000186672F10 ModelPrimitiveType string string string String )
            value.ResourceVersion                           = GetString(new IntPtr(p + 0x020)); // 027004B30B20 0x20 ResourceVersion             ( 000186672F10 ModelPrimitiveType string string string String )
            value.Cryptographer                             = GetObject<ICryptographer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICryptographer.FromPointer); // 027004B30B40 0x28 Cryptographer               ( 000186747640 ModelClassType ICryptographer ICryptographer ICryptographer Pointer )
            value.Trace                                     = GetObject<TraceContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.TraceContext.FromPointer); // 027004B30B60 0x30 Trace                       ( 000186696650 ModelClassType TraceContext TraceContext TraceContext Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x038)); // 027004B30B80 0x38 CancellationToken           ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.TimeoutMs                                 = GetInt32(new IntPtr(p + 0x040)); // 027004B30BA0 0x40 TimeoutMs                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Logger                                    = GetObject<NetworkLoggerBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.NetworkLoggerBase.FromPointer); // 027004B30BE0 0x50 Logger                      ( 00018669C140 ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer )

            return value;
        }
    }
}
