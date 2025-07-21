using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Interface                                ModelPrimitiveType string string string String
    // 018 Interfaces                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 DeviceClass                              ModelPrimitiveType string string string String
    // 028 DeviceClasses                            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Manufacturer                             ModelPrimitiveType string string string String
    // 038 Manufacturers                            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 Product                                  ModelPrimitiveType string string string String
    // 048 Products                                 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 Version                                  ModelPrimitiveType string string string String
    // 058 Versions                                 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 060 Capabilities                             ModelEnumListType Capability[] Capability[] List<Capability> Pointer
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

            value.Interface                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Interface                   ( ModelPrimitiveType string string string String )
            value.Interfaces                                = GetStringList(new IntPtr(p + 0x018)); // 0x18 Interfaces                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DeviceClass                               = GetString(new IntPtr(p + 0x020)); // 0x20 DeviceClass                 ( ModelPrimitiveType string string string String )
            value.DeviceClasses                             = GetStringList(new IntPtr(p + 0x028)); // 0x28 DeviceClasses               ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Manufacturer                              = GetString(new IntPtr(p + 0x030)); // 0x30 Manufacturer                ( ModelPrimitiveType string string string String )
            value.Manufacturers                             = GetStringList(new IntPtr(p + 0x038)); // 0x38 Manufacturers               ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Product                                   = GetString(new IntPtr(p + 0x040)); // 0x40 Product                     ( ModelPrimitiveType string string string String )
            value.Products                                  = GetStringList(new IntPtr(p + 0x048)); // 0x48 Products                    ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Version                                   = GetString(new IntPtr(p + 0x050)); // 0x50 Version                     ( ModelPrimitiveType string string string String )
            value.Versions                                  = GetStringList(new IntPtr(p + 0x058)); // 0x58 Versions                    ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Capabilities                              = GetEnumList<Capability>(new IntPtr(p + 0x060)); // 0x60 Capabilities                ( ModelEnumListType Capability[] Capability[] List<Capability> Pointer )

            return value;
        }
    }
}
