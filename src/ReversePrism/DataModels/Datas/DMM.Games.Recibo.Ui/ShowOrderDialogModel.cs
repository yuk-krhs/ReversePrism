using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductTitle                             000186671910 ModelPrimitiveType string string string String
    // 018 ProductPoint                             0001865F7700 ModelPrimitiveType long long long Int64
    // 020 AvailablePoint                           0001865F7700 ModelPrimitiveType long long long Int64
    // 028 DeveloperPayload                         000186671910 ModelPrimitiveType string string string String
    // 030 IsAvailablePurchase                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 ProductIcon                              000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 040 OnClickPositiveButton                    000186711D50 ModelClassType UnityAction UnityAction UnityAction Pointer
    // 048 OnClickNegativeButton                    000186711D50 ModelClassType UnityAction UnityAction UnityAction Pointer
    // 050 SortingOrder                             0001865F4260 ModelPrimitiveType int int int Int32
    // 058 LogoImage                                00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    public partial class ShowOrderDialogModel
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
            var value   = new ShowOrderDialogModel();

            value.ProductTitle                              = GetString(new IntPtr(p + 0x010)); // 0270DB45F550 0x10 ProductTitle                ( 000186671910 ModelPrimitiveType string string string String )
            value.ProductPoint                              = GetInt64(new IntPtr(p + 0x018)); // 0270DB45F570 0x18 ProductPoint                ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.AvailablePoint                            = GetInt64(new IntPtr(p + 0x020)); // 0270DB45F590 0x20 AvailablePoint              ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DeveloperPayload                          = GetString(new IntPtr(p + 0x028)); // 0270DB45F5B0 0x28 DeveloperPayload            ( 000186671910 ModelPrimitiveType string string string String )
            value.IsAvailablePurchase                       = GetBool(new IntPtr(p + 0x030)); // 0270DB45F5D0 0x30 IsAvailablePurchase         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProductIcon                               = GetObject<Texture2D>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture2D.FromPointer); // 0270DB45F5F0 0x38 ProductIcon                 ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.OnClickPositiveButton                     = GetObject<UnityAction>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnityAction.FromPointer); // 0270DB45F610 0x40 OnClickPositiveButton       ( 000186711D50 ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.OnClickNegativeButton                     = GetObject<UnityAction>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnityAction.FromPointer); // 0270DB45F630 0x48 OnClickNegativeButton       ( 000186711D50 ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x050)); // 0270DB45F650 0x50 SortingOrder                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LogoImage                                 = GetObject<Sprite>(new IntPtr(p + 0x058), ReversePrism.DataModels.Sprite.FromPointer); // 0270DB45F670 0x58 LogoImage                   ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
