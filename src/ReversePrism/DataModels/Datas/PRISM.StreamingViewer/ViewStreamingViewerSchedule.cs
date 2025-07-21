using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 RoomNameField                            ModelClassType TMP_InputField TMP_InputField TMP_InputField Pointer
    // 058 RoomNameButton                           ModelClassType Button Button Button Pointer
    // 060 UrlField                                 ModelClassType TMP_InputField TMP_InputField TMP_InputField Pointer
    // 068 UrlButton                                ModelClassType Button Button Button Pointer
    // 070 ArchiveButton                            ModelClassType Button Button Button Pointer
    // 078 PModeToggle                              ModelClassType Toggle Toggle Toggle Pointer
    public partial class ViewStreamingViewerSchedule : DataModel
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
            var value   = new ViewStreamingViewerSchedule() { Pointer= p0 };

            value.RoomNameField                             = GetObject<TMP_InputField>(new IntPtr(p + 0x050), ReversePrism.DataModels.TMP_InputField.FromPointer); // 0x50 RoomNameField               ( ModelClassType TMP_InputField TMP_InputField TMP_InputField Pointer )
            value.RoomNameButton                            = GetObject<Button>(new IntPtr(p + 0x058), ReversePrism.DataModels.Button.FromPointer); // 0x58 RoomNameButton              ( ModelClassType Button Button Button Pointer )
            value.UrlField                                  = GetObject<TMP_InputField>(new IntPtr(p + 0x060), ReversePrism.DataModels.TMP_InputField.FromPointer); // 0x60 UrlField                    ( ModelClassType TMP_InputField TMP_InputField TMP_InputField Pointer )
            value.UrlButton                                 = GetObject<Button>(new IntPtr(p + 0x068), ReversePrism.DataModels.Button.FromPointer); // 0x68 UrlButton                   ( ModelClassType Button Button Button Pointer )
            value.ArchiveButton                             = GetObject<Button>(new IntPtr(p + 0x070), ReversePrism.DataModels.Button.FromPointer); // 0x70 ArchiveButton               ( ModelClassType Button Button Button Pointer )
            value.PModeToggle                               = GetObject<Toggle>(new IntPtr(p + 0x078), ReversePrism.DataModels.Toggle.FromPointer); // 0x78 PModeToggle                 ( ModelClassType Toggle Toggle Toggle Pointer )

            return value;
        }
    }
}
