using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdName                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 AllinName                                0001866722E0 ModelPrimitiveType string string string String
    // 020 FaceName                                 0001866722E0 ModelPrimitiveType string string string String
    // 028 HairName                                 0001866722E0 ModelPrimitiveType string string string String
    // 030 HeadwearName                             0001866722E0 ModelPrimitiveType string string string String
    // 038 DressName                                0001866722E0 ModelPrimitiveType string string string String
    // 040 AccessoryName                            000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class AssembleInfo : DataModel
    {
        public string                                   IdName                                  { get; set; }
        public string                                   AllinName                               { get; set; }
        public string                                   FaceName                                { get; set; }
        public string                                   HairName                                { get; set; }
        public string                                   HeadwearName                            { get; set; }
        public string                                   DressName                               { get; set; }
        public List<string>?                            AccessoryName                           { get; set; }

        public static AssembleInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssembleInfo() { Pointer= p0 };

            value.IdName                                    = GetString(new IntPtr(p + 0x010)); // 0245A60C1770 0x10 IdName                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AllinName                                 = GetString(new IntPtr(p + 0x018)); // 0245A60C1790 0x18 AllinName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FaceName                                  = GetString(new IntPtr(p + 0x020)); // 0245A60C17B0 0x20 FaceName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HairName                                  = GetString(new IntPtr(p + 0x028)); // 0245A60C17D0 0x28 HairName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HeadwearName                              = GetString(new IntPtr(p + 0x030)); // 0245A60C17F0 0x30 HeadwearName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DressName                                 = GetString(new IntPtr(p + 0x038)); // 0245A60C1810 0x38 DressName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AccessoryName                             = GetStringList(new IntPtr(p + 0x040)); // 0245A60C1830 0x40 AccessoryName               ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
