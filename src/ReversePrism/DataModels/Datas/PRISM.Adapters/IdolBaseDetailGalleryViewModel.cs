using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AlbumActive                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 011 CostumeActive                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 012 VoiceActive                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 013 MovieActive                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 014 EtceteraActive                           0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class IdolBaseDetailGalleryViewModel
    {
        public bool                                     AlbumActive                             { get; set; }
        public bool                                     CostumeActive                           { get; set; }
        public bool                                     VoiceActive                             { get; set; }
        public bool                                     MovieActive                             { get; set; }
        public bool                                     EtceteraActive                          { get; set; }

        public static IdolBaseDetailGalleryViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailGalleryViewModel();

            value.AlbumActive                               = GetBool(new IntPtr(p + 0x010)); // 0270D5E90278 0x10 AlbumActive                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CostumeActive                             = GetBool(new IntPtr(p + 0x011)); // 0270D5E90298 0x11 CostumeActive               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.VoiceActive                               = GetBool(new IntPtr(p + 0x012)); // 0270D5E902B8 0x12 VoiceActive                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.MovieActive                               = GetBool(new IntPtr(p + 0x013)); // 0270D5E902D8 0x13 MovieActive                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.EtceteraActive                            = GetBool(new IntPtr(p + 0x014)); // 0270D5E902F8 0x14 EtceteraActive              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
