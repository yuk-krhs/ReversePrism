using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdName                                   ModelPrimitiveType string string string String
    // 018 AllinName                                ModelPrimitiveType string string string String
    // 020 FaceName                                 ModelPrimitiveType string string string String
    // 028 HairName                                 ModelPrimitiveType string string string String
    // 030 HeadwearName                             ModelPrimitiveType string string string String
    // 038 DressName                                ModelPrimitiveType string string string String
    // 040 AccessoryName                            ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.IdName                                    = GetString(new IntPtr(p + 0x010)); // 0x10 IdName                      ( ModelPrimitiveType string string string String )
            value.AllinName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 AllinName                   ( ModelPrimitiveType string string string String )
            value.FaceName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 FaceName                    ( ModelPrimitiveType string string string String )
            value.HairName                                  = GetString(new IntPtr(p + 0x028)); // 0x28 HairName                    ( ModelPrimitiveType string string string String )
            value.HeadwearName                              = GetString(new IntPtr(p + 0x030)); // 0x30 HeadwearName                ( ModelPrimitiveType string string string String )
            value.DressName                                 = GetString(new IntPtr(p + 0x038)); // 0x38 DressName                   ( ModelPrimitiveType string string string String )
            value.AccessoryName                             = GetStringList(new IntPtr(p + 0x040)); // 0x40 AccessoryName               ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
