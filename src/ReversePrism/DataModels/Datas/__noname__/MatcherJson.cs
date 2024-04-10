using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Interface                                0001866722E0 ModelPrimitiveType string string string String
    // 018 Interfaces                               000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 DeviceClass                              0001866722E0 ModelPrimitiveType string string string String
    // 028 DeviceClasses                            000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Manufacturer                             0001866722E0 ModelPrimitiveType string string string String
    // 038 Manufacturers                            000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 Product                                  0001866722E0 ModelPrimitiveType string string string String
    // 048 Products                                 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 Version                                  0001866722E0 ModelPrimitiveType string string string String
    // 058 Versions                                 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 060 Capabilities                             000185CCA508 ModelEnumListType Capability[] Capability[] List<Capability> Pointer
    public partial class MatcherJson : DataModel
    {
        public string                                   Interface                               { get; set; }
        public List<string>?                            Interfaces                              { get; set; }
        public string                                   DeviceClass                             { get; set; }
        public List<string>?                            DeviceClasses                           { get; set; }
        public string                                   Manufacturer                            { get; set; }
        public List<string>?                            Manufacturers                           { get; set; }
        public string                                   Product                                 { get; set; }
        public List<string>?                            Products                                { get; set; }
        public string                                   Version                                 { get; set; }
        public List<string>?                            Versions                                { get; set; }
        public List<Capability>?                        Capabilities                            { get; set; }

        public static MatcherJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatcherJson() { Pointer= p0 };

            value.Interface                                 = GetString(new IntPtr(p + 0x010)); // 0245A33CA298 0x10 Interface                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Interfaces                                = GetStringList(new IntPtr(p + 0x018)); // 0245A33CA2B8 0x18 Interfaces                  ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DeviceClass                               = GetString(new IntPtr(p + 0x020)); // 0245A33CA2D8 0x20 DeviceClass                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DeviceClasses                             = GetStringList(new IntPtr(p + 0x028)); // 0245A33CA2F8 0x28 DeviceClasses               ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Manufacturer                              = GetString(new IntPtr(p + 0x030)); // 0245A33CA318 0x30 Manufacturer                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Manufacturers                             = GetStringList(new IntPtr(p + 0x038)); // 0245A33CA338 0x38 Manufacturers               ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Product                                   = GetString(new IntPtr(p + 0x040)); // 0245A33CA358 0x40 Product                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Products                                  = GetStringList(new IntPtr(p + 0x048)); // 0245A33CA378 0x48 Products                    ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Version                                   = GetString(new IntPtr(p + 0x050)); // 0245A33CA398 0x50 Version                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Versions                                  = GetStringList(new IntPtr(p + 0x058)); // 0245A33CA3B8 0x58 Versions                    ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Capabilities                              = GetEnumList<Capability>(new IntPtr(p + 0x060)); // 0245A33CA3D8 0x60 Capabilities                ( 000185CCA508 ModelEnumListType Capability[] Capability[] List<Capability> Pointer )

            return value;
        }
    }
}
