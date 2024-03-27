using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 AppId                                    0001866722E0 ModelPrimitiveType string string string String
    // 030 Size                                     0001866722E0 ModelPrimitiveType string string string String
    // 038 Pids                                     000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 AdjustVga                                0001866722E0 ModelPrimitiveType string string string String
    public partial class ThumbnailParameter
    {
        public string                                   AppId                                   { get; set; }
        public string                                   Size                                    { get; set; }
        public List<string>?                            Pids                                    { get; set; }
        public string                                   AdjustVga                               { get; set; }

        public static ThumbnailParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThumbnailParameter();

            value.AppId                                     = GetString(new IntPtr(p + 0x028)); // 0270DB498B30 0x28 AppId                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Size                                      = GetString(new IntPtr(p + 0x030)); // 0270DB498B50 0x30 Size                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Pids                                      = GetStringList(new IntPtr(p + 0x038)); // 0270DB498B70 0x38 Pids                        ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.AdjustVga                                 = GetString(new IntPtr(p + 0x040)); // 0270DB498B90 0x40 AdjustVga                   ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
