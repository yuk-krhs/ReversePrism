using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstVoiceResourceId                       ModelPrimitiveType int int int Int32
    // 018 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class MstBirthdayVoice : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstVoiceResourceId                      { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }

        public static MstBirthdayVoice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstBirthdayVoice() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstVoiceResourceId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstVoiceResourceId          ( ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x018)); // 0x18 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
