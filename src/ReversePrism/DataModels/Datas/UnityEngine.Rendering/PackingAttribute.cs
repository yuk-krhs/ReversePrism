using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayNames                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 Range                                    ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 PackingScheme                            ModelEnumType FieldPacking FieldPacking FieldPacking Int32
    // 024 OffsetInSource                           ModelPrimitiveType int int int Int32
    // 028 SizeInBits                               ModelPrimitiveType int int int Int32
    // 02C IsDirection                              ModelPrimitiveType bool bool bool Bool
    // 02D SRGBDisplay                              ModelPrimitiveType bool bool bool Bool
    // 02E CheckIsNormalized                        ModelPrimitiveType bool bool bool Bool
    // 030 Preprocessor                             ModelPrimitiveType string string string String
    public partial class PackingAttribute : DataModel
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
            var value   = new PackingAttribute() { Pointer= p0 };

            value.DisplayNames                              = GetStringList(new IntPtr(p + 0x010)); // 0x10 DisplayNames                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Range                                     = GetSingleList(new IntPtr(p + 0x018)); // 0x18 Range                       ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.PackingScheme                             = (FieldPacking)GetInt32(new IntPtr(p + 0x020)); // 0x20 PackingScheme               ( ModelEnumType FieldPacking FieldPacking FieldPacking Int32 )
            value.OffsetInSource                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 OffsetInSource              ( ModelPrimitiveType int int int Int32 )
            value.SizeInBits                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 SizeInBits                  ( ModelPrimitiveType int int int Int32 )
            value.IsDirection                               = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsDirection                 ( ModelPrimitiveType bool bool bool Bool )
            value.SRGBDisplay                               = GetBool(new IntPtr(p + 0x02D)); // 0x2D SRGBDisplay                 ( ModelPrimitiveType bool bool bool Bool )
            value.CheckIsNormalized                         = GetBool(new IntPtr(p + 0x02E)); // 0x2E CheckIsNormalized           ( ModelPrimitiveType bool bool bool Bool )
            value.Preprocessor                              = GetString(new IntPtr(p + 0x030)); // 0x30 Preprocessor                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
