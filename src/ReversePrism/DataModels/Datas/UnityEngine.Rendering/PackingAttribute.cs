using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayNames                             000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 Range                                    000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 PackingScheme                            000186575FA0 ModelEnumType FieldPacking FieldPacking FieldPacking Int32
    // 024 OffsetInSource                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 SizeInBits                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C IsDirection                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 02D SRGBDisplay                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 02E CheckIsNormalized                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 Preprocessor                             0001866722E0 ModelPrimitiveType string string string String
    public partial class PackingAttribute
    {
        public List<string>?                            DisplayNames                            { get; set; }
        public List<float>?                             Range                                   { get; set; }
        public FieldPacking                             PackingScheme                           { get; set; }
        public int                                      OffsetInSource                          { get; set; }
        public int                                      SizeInBits                              { get; set; }
        public bool                                     IsDirection                             { get; set; }
        public bool                                     SRGBDisplay                             { get; set; }
        public bool                                     CheckIsNormalized                       { get; set; }
        public string                                   Preprocessor                            { get; set; }

        public static PackingAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PackingAttribute();

            value.DisplayNames                              = GetStringList(new IntPtr(p + 0x010)); // 0270D925C218 0x10 DisplayNames                ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Range                                     = GetSingleList(new IntPtr(p + 0x018)); // 0270D925C238 0x18 Range                       ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.PackingScheme                             = (FieldPacking)GetInt32(new IntPtr(p + 0x020)); // 0270D925C258 0x20 PackingScheme               ( 000186575FA0 ModelEnumType FieldPacking FieldPacking FieldPacking Int32 )
            value.OffsetInSource                            = GetInt32(new IntPtr(p + 0x024)); // 0270D925C278 0x24 OffsetInSource              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SizeInBits                                = GetInt32(new IntPtr(p + 0x028)); // 0270D925C298 0x28 SizeInBits                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsDirection                               = GetBool(new IntPtr(p + 0x02C)); // 0270D925C2B8 0x2C IsDirection                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SRGBDisplay                               = GetBool(new IntPtr(p + 0x02D)); // 0270D925C2D8 0x2D SRGBDisplay                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CheckIsNormalized                         = GetBool(new IntPtr(p + 0x02E)); // 0270D925C2F8 0x2E CheckIsNormalized           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Preprocessor                              = GetString(new IntPtr(p + 0x030)); // 0270D925C318 0x30 Preprocessor                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
