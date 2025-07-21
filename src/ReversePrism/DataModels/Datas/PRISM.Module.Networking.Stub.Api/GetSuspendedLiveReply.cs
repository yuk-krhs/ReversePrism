using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSuspendedLiveReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsSuspendedFieldNumber                   int IL2CPP_TYPE_I4
    // 018 IsSuspended                              ModelPrimitiveType bool bool bool Bool
    // 000 CanResumeFieldNumber                     int IL2CPP_TYPE_I4
    // 019 CanResume                                ModelPrimitiveType bool bool bool Bool
    // 000 ResumeParamFieldNumber                   int IL2CPP_TYPE_I4
    // 020 ResumeParam                              ModelClassType LiveResumeParamStatus LiveResumeParamStatus LiveResumeParamStatus Pointer
    public partial class GetSuspendedLiveReply : DataModel
    {
        public bool                                     IsSuspended                             { get; set; }
        public bool                                     CanResume                               { get; set; }
        public LiveResumeParamStatus?                   ResumeParam                             { get; set; }

        public static GetSuspendedLiveReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSuspendedLiveReply() { Pointer= p0 };

            value.IsSuspended                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsSuspended                 ( ModelPrimitiveType bool bool bool Bool )
            value.CanResume                                 = GetBool(new IntPtr(p + 0x019)); // 0x19 CanResume                   ( ModelPrimitiveType bool bool bool Bool )
            value.ResumeParam                               = GetObject<LiveResumeParamStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveResumeParamStatus.FromPointer); // 0x20 ResumeParam                 ( ModelClassType LiveResumeParamStatus LiveResumeParamStatus LiveResumeParamStatus Pointer )

            return value;
        }
    }
}
