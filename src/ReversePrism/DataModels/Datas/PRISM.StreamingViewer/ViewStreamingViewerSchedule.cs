using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 RoomNameField                            00018660DCA0 ModelClassType TMP_InputField TMP_InputField TMP_InputField Pointer
    // 060 RoomNameButton                           0001865140C0 ModelClassType Button Button Button Pointer
    // 068 UrlField                                 00018660DCA0 ModelClassType TMP_InputField TMP_InputField TMP_InputField Pointer
    // 070 UrlButton                                0001865140C0 ModelClassType Button Button Button Pointer
    // 078 ArchiveButton                            0001865140C0 ModelClassType Button Button Button Pointer
    // 080 PModeToggle                              000186682710 ModelClassType Toggle Toggle Toggle Pointer
    public partial class ViewStreamingViewerSchedule
    {
        public TMP_InputField?                          RoomNameField                           { get; set; }
        public Button?                                  RoomNameButton                          { get; set; }
        public TMP_InputField?                          UrlField                                { get; set; }
        public Button?                                  UrlButton                               { get; set; }
        public Button?                                  ArchiveButton                           { get; set; }
        public Toggle?                                  PModeToggle                             { get; set; }

        public static ViewStreamingViewerSchedule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewStreamingViewerSchedule();

            value.RoomNameField                             = GetObject<TMP_InputField>(new IntPtr(p + 0x058), ReversePrism.DataModels.TMP_InputField.FromPointer); // 0270D4F5F7C0 0x58 RoomNameField               ( 00018660DCA0 ModelClassType TMP_InputField TMP_InputField TMP_InputField Pointer )
            value.RoomNameButton                            = GetObject<Button>(new IntPtr(p + 0x060), ReversePrism.DataModels.Button.FromPointer); // 0270D4F5F7E0 0x60 RoomNameButton              ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.UrlField                                  = GetObject<TMP_InputField>(new IntPtr(p + 0x068), ReversePrism.DataModels.TMP_InputField.FromPointer); // 0270D4F5F800 0x68 UrlField                    ( 00018660DCA0 ModelClassType TMP_InputField TMP_InputField TMP_InputField Pointer )
            value.UrlButton                                 = GetObject<Button>(new IntPtr(p + 0x070), ReversePrism.DataModels.Button.FromPointer); // 0270D4F5F820 0x70 UrlButton                   ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.ArchiveButton                             = GetObject<Button>(new IntPtr(p + 0x078), ReversePrism.DataModels.Button.FromPointer); // 0270D4F5F840 0x78 ArchiveButton               ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.PModeToggle                               = GetObject<Toggle>(new IntPtr(p + 0x080), ReversePrism.DataModels.Toggle.FromPointer); // 0270D4F5F860 0x80 PModeToggle                 ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )

            return value;
        }
    }
}
