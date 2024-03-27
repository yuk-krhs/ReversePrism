using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxVolumeIndex                           int IL2CPP_TYPE_I4
    // 000 DefaultVolumeIndex                       int IL2CPP_TYPE_I4
    // 000 VolumeTable                              float[] IL2CPP_TYPE_SZARRAY
    // 010 IsMute                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 VolumeIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class EachSoundSettingsLocalSaveType
    {
        public bool                                     IsMute                                  { get; set; }
        public int                                      VolumeIndex                             { get; set; }

        public static EachSoundSettingsLocalSaveType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EachSoundSettingsLocalSaveType();

            value.IsMute                                    = GetBool(new IntPtr(p + 0x010)); // 027003A80E08 0x10 IsMute                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.VolumeIndex                               = GetInt32(new IntPtr(p + 0x014)); // 027003A80E28 0x14 VolumeIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
