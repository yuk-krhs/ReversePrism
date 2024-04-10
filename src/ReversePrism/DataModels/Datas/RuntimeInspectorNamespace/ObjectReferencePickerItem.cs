using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Background                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 040 TexturePreview                           000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 048 TexturePreviewLayoutElement              00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 050 ReferenceNameText                        000186631C00 ModelClassType Text Text Text Pointer
    // 058 <Reference>k__BackingField               <object> IL2CPP_TYPE_OBJECT
    // 060 M_skinVersion                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 M_skin                                   0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer
    // 070 M_isSelected                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ObjectReferencePickerItem : DataModel
    {
        public Image?                                   Background                              { get; set; }
        public RawImage?                                TexturePreview                          { get; set; }
        public LayoutElement?                           TexturePreviewLayoutElement             { get; set; }
        public Text?                                    ReferenceNameText                       { get; set; }
        public int                                      M_skinVersion                           { get; set; }
        public UISkin?                                  M_skin                                  { get; set; }
        public bool                                     M_isSelected                            { get; set; }

        public static ObjectReferencePickerItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectReferencePickerItem() { Pointer= p0 };

            value.Background                                = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 02466B269260 0x38 Background                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TexturePreview                            = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 02466B269280 0x40 TexturePreview              ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TexturePreviewLayoutElement               = GetObject<LayoutElement>(new IntPtr(p + 0x048), ReversePrism.DataModels.LayoutElement.FromPointer); // 02466B2692A0 0x48 TexturePreviewLayoutElement ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.ReferenceNameText                         = GetObject<Text>(new IntPtr(p + 0x050), ReversePrism.DataModels.Text.FromPointer); // 02466B2692C0 0x50 ReferenceNameText           ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x060)); // 02466B269300 0x60 M_skinVersion               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x068), ReversePrism.DataModels.UISkin.FromPointer); // 02466B269320 0x68 M_skin                      ( 0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer )
            value.M_isSelected                              = GetBool(new IntPtr(p + 0x070)); // 02466B269340 0x70 M_isSelected                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
