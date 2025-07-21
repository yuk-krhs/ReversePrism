using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  ModelPrimitiveType string string string String
    // 018 OnClickPositiveButton                    ModelClassType UnityAction UnityAction UnityAction Pointer
    // 020 OnClickNegativeButton                    ModelClassType UnityAction UnityAction UnityAction Pointer
    // 028 PositiveButtonText                       ModelPrimitiveType string string string String
    // 030 NegativeButtonText                       ModelPrimitiveType string string string String
    // 038 SortingOrder                             ModelPrimitiveType int int int Int32
    // 040 LogoImage                                ModelClassType Sprite Sprite Sprite Pointer
    public partial class ShowRetryDialogModel : DataModel
    {
        public string                                   Message                                 { get; set; }
        public UnityAction?                             OnClickPositiveButton                   { get; set; }
        public UnityAction?                             OnClickNegativeButton                   { get; set; }
        public string                                   PositiveButtonText                      { get; set; }
        public string                                   NegativeButtonText                      { get; set; }
        public int                                      SortingOrder                            { get; set; }
        public Sprite?                                  LogoImage                               { get; set; }

        public static ShowRetryDialogModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowRetryDialogModel() { Pointer= p0 };

            value.Message                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Message                     ( ModelPrimitiveType string string string String )
            value.OnClickPositiveButton                     = GetObject<UnityAction>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityAction.FromPointer); // 0x18 OnClickPositiveButton       ( ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.OnClickNegativeButton                     = GetObject<UnityAction>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnityAction.FromPointer); // 0x20 OnClickNegativeButton       ( ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.PositiveButtonText                        = GetString(new IntPtr(p + 0x028)); // 0x28 PositiveButtonText          ( ModelPrimitiveType string string string String )
            value.NegativeButtonText                        = GetString(new IntPtr(p + 0x030)); // 0x30 NegativeButtonText          ( ModelPrimitiveType string string string String )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 SortingOrder                ( ModelPrimitiveType int int int Int32 )
            value.LogoImage                                 = GetObject<Sprite>(new IntPtr(p + 0x040), ReversePrism.DataModels.Sprite.FromPointer); // 0x40 LogoImage                   ( ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
