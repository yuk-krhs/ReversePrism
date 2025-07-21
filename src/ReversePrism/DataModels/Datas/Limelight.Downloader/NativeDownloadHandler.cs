using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxAutoRetryCount                        int IL2CPP_TYPE_I4
    // 010 TotalRequests                            ModelPrimitiveType int int int Int32
    // 018 Provider                                 ModelClassType IDownloadJobProvider IDownloadJobProvider IDownloadJobProvider Pointer
    // 020 itemMap                                  Dictionary`2<int, INativeDownloadJob> IL2CPP_TYPE_GENERICINST
    // 028 Aborted                                  ModelPrimitiveType bool bool bool Bool
    // 030 errorItems                               Queue`1<INativeDownloadJob> IL2CPP_TYPE_GENERICINST
    // 038 retryItems                               Queue`1<INativeDownloadJob> IL2CPP_TYPE_GENERICINST
    // 040 OnRequestPenaltyChange                   Action`2<INativeDownloadJob, bool> IL2CPP_TYPE_GENERICINST
    public partial class NativeDownloadHandler : DataModel
    {
        public int                                      TotalRequests                           { get; set; }
        public IDownloadJobProvider?                    Provider                                { get; set; }
        public bool                                     Aborted                                 { get; set; }

        public static NativeDownloadHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadHandler() { Pointer= p0 };

            value.TotalRequests                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 TotalRequests               ( ModelPrimitiveType int int int Int32 )
            value.Provider                                  = GetObject<IDownloadJobProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDownloadJobProvider.FromPointer); // 0x18 Provider                    ( ModelClassType IDownloadJobProvider IDownloadJobProvider IDownloadJobProvider Pointer )
            value.Aborted                                   = GetBool(new IntPtr(p + 0x028)); // 0x28 Aborted                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
