using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllinFileName                            0001866722E0 ModelPrimitiveType string string string String
    // 018 FaceFileName                             0001866722E0 ModelPrimitiveType string string string String
    // 020 HairFileName                             0001866722E0 ModelPrimitiveType string string string String
    // 028 HeadwearFileName                         0001866722E0 ModelPrimitiveType string string string String
    // 030 DressFileName                            0001866722E0 ModelPrimitiveType string string string String
    // 038 AccessoryFileName                        000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 FaceName                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class FileNameInfo
    {
        public string                                   AllinFileName                           { get; set; }
        public string                                   FaceFileName                            { get; set; }
        public string                                   HairFileName                            { get; set; }
        public string                                   HeadwearFileName                        { get; set; }
        public string                                   DressFileName                           { get; set; }
        public List<string>?                            AccessoryFileName                       { get; set; }
        public string                                   FaceName                                { get; set; }

        public static FileNameInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileNameInfo();

            value.AllinFileName                             = GetString(new IntPtr(p + 0x010)); // 0270060E8A88 0x10 AllinFileName               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FaceFileName                              = GetString(new IntPtr(p + 0x018)); // 0270060E8AA8 0x18 FaceFileName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HairFileName                              = GetString(new IntPtr(p + 0x020)); // 0270060E8AC8 0x20 HairFileName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HeadwearFileName                          = GetString(new IntPtr(p + 0x028)); // 0270060E8AE8 0x28 HeadwearFileName            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DressFileName                             = GetString(new IntPtr(p + 0x030)); // 0270060E8B08 0x30 DressFileName               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AccessoryFileName                         = GetStringList(new IntPtr(p + 0x038)); // 0270060E8B28 0x38 AccessoryFileName           ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.FaceName                                  = GetString(new IntPtr(p + 0x040)); // 0270060E8B48 0x40 FaceName                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
