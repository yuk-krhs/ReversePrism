using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 VoiceType                                0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MstVoiceResourceId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstDressUpRoomVoice
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      VoiceType                               { get; set; }
        public int                                      MstVoiceResourceId                      { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }

        public static MstDressUpRoomVoice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstDressUpRoomVoice();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004612E38 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 027004612E58 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.VoiceType                                 = GetInt32(new IntPtr(p + 0x018)); // 027004612E78 0x18 VoiceType                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstVoiceResourceId                        = GetInt32(new IntPtr(p + 0x01C)); // 027004612E98 0x1C MstVoiceResourceId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x020)); // 027004612EB8 0x20 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
