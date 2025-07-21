using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Headers                                  ModelClassType Metadata Metadata Metadata Pointer
    // 018 Deadline                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 WriteOptions                             ModelClassType WriteOptions WriteOptions WriteOptions Pointer
    // 038 PropagationToken                         ModelClassType ContextPropagationToken ContextPropagationToken ContextPropagationToken Pointer
    // 040 Credentials                              ModelClassType CallCredentials CallCredentials CallCredentials Pointer
    // 048 Flags                                    ModelEnumType CallFlags CallFlags CallFlags Int32
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

            value.Headers                                   = GetObject<Metadata>(new IntPtr(p + 0x010), ReversePrism.DataModels.Metadata.FromPointer); // 0x10 Headers                     ( ModelClassType Metadata Metadata Metadata Pointer )
            value.Deadline                                  = GetDateTime(new IntPtr(p + 0x018)); // 0x18 Deadline                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.WriteOptions                              = GetObject<WriteOptions>(new IntPtr(p + 0x030), ReversePrism.DataModels.WriteOptions.FromPointer); // 0x30 WriteOptions                ( ModelClassType WriteOptions WriteOptions WriteOptions Pointer )
            value.PropagationToken                          = GetObject<ContextPropagationToken>(new IntPtr(p + 0x038), ReversePrism.DataModels.ContextPropagationToken.FromPointer); // 0x38 PropagationToken            ( ModelClassType ContextPropagationToken ContextPropagationToken ContextPropagationToken Pointer )
            value.Credentials                               = GetObject<CallCredentials>(new IntPtr(p + 0x040), ReversePrism.DataModels.CallCredentials.FromPointer); // 0x40 Credentials                 ( ModelClassType CallCredentials CallCredentials CallCredentials Pointer )
            value.Flags                                     = (CallFlags)GetInt32(new IntPtr(p + 0x048)); // 0x48 Flags                       ( ModelEnumType CallFlags CallFlags CallFlags Int32 )

            return value;
        }
    }
}
