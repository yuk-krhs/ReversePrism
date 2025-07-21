using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handlers                                 ModelClassListType List`1<NativeDownloadHandler> List`1<NativeDownloadHandler> List<NativeDownloadHandler> Pointer
    // 018 ownerMap                                 Dictionary`2<int, NativeDownloadHandler> IL2CPP_TYPE_GENERICINST
    // 020 Context                                  ModelClassType NativeDownloadContext NativeDownloadContext NativeDownloadContext Pointer
    public partial class DownloadHandlerQueue : DataModel
    {
        public List<NativeDownloadHandler>?             Handlers                                { get; set; }
        public NativeDownloadContext?                   Context                                 { get; set; }

        public static DownloadHandlerQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DownloadHandlerQueue() { Pointer= p0 };

            value.Handlers                                  = GetObjectList<NativeDownloadHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.NativeDownloadHandler.FromPointer); // 0x10 Handlers                    ( ModelClassListType List`1<NativeDownloadHandler> List`1<NativeDownloadHandler> List<NativeDownloadHandler> Pointer )
            value.Context                                   = GetObject<NativeDownloadContext>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeDownloadContext.FromPointer); // 0x20 Context                     ( ModelClassType NativeDownloadContext NativeDownloadContext NativeDownloadContext Pointer )

            return value;
        }
    }
}
