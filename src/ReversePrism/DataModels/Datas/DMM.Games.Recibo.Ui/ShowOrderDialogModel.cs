using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductTitle                             ModelPrimitiveType string string string String
    // 018 ProductPoint                             ModelPrimitiveType long long long Int64
    // 020 AvailablePoint                           ModelPrimitiveType long long long Int64
    // 028 DeveloperPayload                         ModelPrimitiveType string string string String
    // 030 IsAvailablePurchase                      ModelPrimitiveType bool bool bool Bool
    // 038 ProductIcon                              ModelClassType Texture2D Texture2D Texture2D Pointer
    // 040 OnClickPositiveButton                    ModelClassType UnityAction UnityAction UnityAction Pointer
    // 048 OnClickNegativeButton                    ModelClassType UnityAction UnityAction UnityAction Pointer
    // 050 SortingOrder                             ModelPrimitiveType int int int Int32
    // 058 LogoImage                                ModelClassType Sprite Sprite Sprite Pointer
    public partial class ShowOrderDialogModel : DataModel
    {
        public string                                   ProductTitle                            { get; set; }
        public long                                     ProductPoint                            { get; set; }
        public long                                     AvailablePoint                          { get; set; }
        public string                                   DeveloperPayload                        { get; set; }
        public bool                                     IsAvailablePurchase                     { get; set; }
        public Texture2D?                               ProductIcon                             { get; set; }
        public UnityAction?                             OnClickPositiveButton                   { get; set; }
        public UnityAction?                             OnClickNegativeButton                   { get; set; }
        public int                                      SortingOrder                            { get; set; }
        public Sprite?                                  LogoImage                               { get; set; }

        public static ShowOrderDialogModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowOrderDialogModel() { Pointer= p0 };

            value.ProductTitle                              = GetString(new IntPtr(p + 0x010)); // 0x10 ProductTitle                ( ModelPrimitiveType string string string String )
            value.ProductPoint                              = GetInt64(new IntPtr(p + 0x018)); // 0x18 ProductPoint                ( ModelPrimitiveType long long long Int64 )
            value.AvailablePoint                            = GetInt64(new IntPtr(p + 0x020)); // 0x20 AvailablePoint              ( ModelPrimitiveType long long long Int64 )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x028)); // 0x28 DeveloperPayload            ( ModelPrimitiveType string string string String )
            value.IsAvailablePurchase                       = GetBool(new IntPtr(p + 0x030)); // 0x30 IsAvailablePurchase         ( ModelPrimitiveType bool bool bool Bool )
            value.ProductIcon                               = GetObject<Texture2D>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture2D.FromPointer); // 0x38 ProductIcon                 ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.OnClickPositiveButton                     = GetObject<UnityAction>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnityAction.FromPointer); // 0x40 OnClickPositiveButton       ( ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.OnClickNegativeButton                     = GetObject<UnityAction>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnityAction.FromPointer); // 0x48 OnClickNegativeButton       ( ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x050)); // 0x50 SortingOrder                ( ModelPrimitiveType int int int Int32 )
            value.LogoImage                                 = GetObject<Sprite>(new IntPtr(p + 0x058), ReversePrism.DataModels.Sprite.FromPointer); // 0x58 LogoImage                   ( ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
