using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Headers                                  00018660C390 ModelClassType Metadata Metadata Metadata Pointer
    // 018 Deadline                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 WriteOptions                             000186560BB0 ModelClassType WriteOptions WriteOptions WriteOptions Pointer
    // 038 PropagationToken                         000186616DB0 ModelClassType ContextPropagationToken ContextPropagationToken ContextPropagationToken Pointer
    // 040 Credentials                              000186525EC0 ModelClassType CallCredentials CallCredentials CallCredentials Pointer
    // 048 Flags                                    000186527C90 ModelEnumType CallFlags CallFlags CallFlags Int32
    public partial class CallOptions : DataModel
    {
        public Metadata?                                Headers                                 { get; set; }
        public DateTime                                 Deadline                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public WriteOptions?                            WriteOptions                            { get; set; }
        public ContextPropagationToken?                 PropagationToken                        { get; set; }
        public CallCredentials?                         Credentials                             { get; set; }
        public CallFlags                                Flags                                   { get; set; }

        public static CallOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallOptions() { Pointer= p0 };

            value.Headers                                   = GetObject<Metadata>(new IntPtr(p + 0x010), ReversePrism.DataModels.Metadata.FromPointer); // 0245A4B9D640 0x10 Headers                     ( 00018660C390 ModelClassType Metadata Metadata Metadata Pointer )
            value.Deadline                                  = GetDateTime(new IntPtr(p + 0x018)); // 0245A4B9D660 0x18 Deadline                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0245A4B9D680 0x28 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.WriteOptions                              = GetObject<WriteOptions>(new IntPtr(p + 0x030), ReversePrism.DataModels.WriteOptions.FromPointer); // 0245A4B9D6A0 0x30 WriteOptions                ( 000186560BB0 ModelClassType WriteOptions WriteOptions WriteOptions Pointer )
            value.PropagationToken                          = GetObject<ContextPropagationToken>(new IntPtr(p + 0x038), ReversePrism.DataModels.ContextPropagationToken.FromPointer); // 0245A4B9D6C0 0x38 PropagationToken            ( 000186616DB0 ModelClassType ContextPropagationToken ContextPropagationToken ContextPropagationToken Pointer )
            value.Credentials                               = GetObject<CallCredentials>(new IntPtr(p + 0x040), ReversePrism.DataModels.CallCredentials.FromPointer); // 0245A4B9D6E0 0x40 Credentials                 ( 000186525EC0 ModelClassType CallCredentials CallCredentials CallCredentials Pointer )
            value.Flags                                     = (CallFlags)GetInt32(new IntPtr(p + 0x048)); // 0245A4B9D700 0x48 Flags                       ( 000186527C90 ModelEnumType CallFlags CallFlags CallFlags Int32 )

            return value;
        }
    }
}
