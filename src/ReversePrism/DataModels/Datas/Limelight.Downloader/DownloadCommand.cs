using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Slot                                     ModelEnumType DownloadSlot DownloadSlot DownloadSlot Int32
    // 014 InsertControl                            ModelEnumType DownloadInsertControl DownloadInsertControl DownloadInsertControl Int32
    // 018 Provider                                 ModelClassType IDownloadJobProvider IDownloadJobProvider IDownloadJobProvider Pointer
    public partial class DownloadCommand : DataModel
    {
        public DownloadSlot                             Slot                                    { get; set; }
        public DownloadInsertControl                    InsertControl                           { get; set; }
        public IDownloadJobProvider?                    Provider                                { get; set; }

        public static DownloadCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DownloadCommand() { Pointer= p0 };

            value.Slot                                      = (DownloadSlot)GetInt32(new IntPtr(p + 0x010)); // 0x10 Slot                        ( ModelEnumType DownloadSlot DownloadSlot DownloadSlot Int32 )
            value.InsertControl                             = (DownloadInsertControl)GetInt32(new IntPtr(p + 0x014)); // 0x14 InsertControl               ( ModelEnumType DownloadInsertControl DownloadInsertControl DownloadInsertControl Int32 )
            value.Provider                                  = GetObject<IDownloadJobProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDownloadJobProvider.FromPointer); // 0x18 Provider                    ( ModelClassType IDownloadJobProvider IDownloadJobProvider IDownloadJobProvider Pointer )

            return value;
        }
    }
}
