using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllinFileName                            ModelPrimitiveType string string string String
    // 018 FaceFileName                             ModelPrimitiveType string string string String
    // 020 HairFileName                             ModelPrimitiveType string string string String
    // 028 HeadwearFileName                         ModelPrimitiveType string string string String
    // 030 DressFileName                            ModelPrimitiveType string string string String
    // 038 AccessoryFileName                        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 FaceName                                 ModelPrimitiveType string string string String
    public partial class FileNameInfo : DataModel
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
            var value   = new FileNameInfo() { Pointer= p0 };

            value.AllinFileName                             = GetString(new IntPtr(p + 0x010)); // 0x10 AllinFileName               ( ModelPrimitiveType string string string String )
            value.FaceFileName                              = GetString(new IntPtr(p + 0x018)); // 0x18 FaceFileName                ( ModelPrimitiveType string string string String )
            value.HairFileName                              = GetString(new IntPtr(p + 0x020)); // 0x20 HairFileName                ( ModelPrimitiveType string string string String )
            value.HeadwearFileName                          = GetString(new IntPtr(p + 0x028)); // 0x28 HeadwearFileName            ( ModelPrimitiveType string string string String )
            value.DressFileName                             = GetString(new IntPtr(p + 0x030)); // 0x30 DressFileName               ( ModelPrimitiveType string string string String )
            value.AccessoryFileName                         = GetStringList(new IntPtr(p + 0x038)); // 0x38 AccessoryFileName           ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.FaceName                                  = GetString(new IntPtr(p + 0x040)); // 0x40 FaceName                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
