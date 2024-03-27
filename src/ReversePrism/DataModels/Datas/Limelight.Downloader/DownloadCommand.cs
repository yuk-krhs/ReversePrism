using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Slot                                     0001865B4BF0 ModelEnumType DownloadSlot DownloadSlot DownloadSlot Int32
    // 014 InsertControl                            0001865B44B0 ModelEnumType DownloadInsertControl DownloadInsertControl DownloadInsertControl Int32
    // 018 Provider                                 000186755E00 ModelClassType IDownloadJobProvider IDownloadJobProvider IDownloadJobProvider Pointer
    public partial class DownloadCommand
    {
        public DownloadSlot                             Slot                                    { get; set; }
        public DownloadInsertControl                    InsertControl                           { get; set; }
        public IDownloadJobProvider?                    Provider                                { get; set; }

        public static DownloadCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DownloadCommand();

            value.Slot                                      = (DownloadSlot)GetInt32(new IntPtr(p + 0x010)); // 027003E29F10 0x10 Slot                        ( 0001865B4BF0 ModelEnumType DownloadSlot DownloadSlot DownloadSlot Int32 )
            value.InsertControl                             = (DownloadInsertControl)GetInt32(new IntPtr(p + 0x014)); // 027003E29F30 0x14 InsertControl               ( 0001865B44B0 ModelEnumType DownloadInsertControl DownloadInsertControl DownloadInsertControl Int32 )
            value.Provider                                  = GetObject<IDownloadJobProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDownloadJobProvider.FromPointer); // 027003E29F50 0x18 Provider                    ( 000186755E00 ModelClassType IDownloadJobProvider IDownloadJobProvider IDownloadJobProvider Pointer )

            return value;
        }
    }
}
