using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 Button                                   000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 EmptyIcon                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 Unit                                     00018659C060 ModelClassType ILiveUnit ILiveUnit ILiveUnit Pointer
    // 040 Position                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 CostumeCategory                          0001866293F0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
    public partial class LiveUnitEditCostumeIcon : DataModel
    {
        public UIRawImage?                              Icon                                    { get; set; }
        public ButtonBase?                              Button                                  { get; set; }
        public Image?                                   EmptyIcon                               { get; set; }
        public ILiveUnit?                               Unit                                    { get; set; }
        public int                                      Position                                { get; set; }
        public CostumeCategory                          CostumeCategory                         { get; set; }

        public static LiveUnitEditCostumeIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCostumeIcon() { Pointer= p0 };

            value.Icon                                      = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466517E380 0x20 Icon                        ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466517E3A0 0x28 Button                      ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.EmptyIcon                                 = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 02466517E3C0 0x30 EmptyIcon                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Unit                                      = GetObject<ILiveUnit>(new IntPtr(p + 0x038), ReversePrism.DataModels.ILiveUnit.FromPointer); // 02466517E3E0 0x38 Unit                        ( 00018659C060 ModelClassType ILiveUnit ILiveUnit ILiveUnit Pointer )
            value.Position                                  = GetInt32(new IntPtr(p + 0x040)); // 02466517E400 0x40 Position                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CostumeCategory                           = (CostumeCategory)GetInt32(new IntPtr(p + 0x044)); // 02466517E420 0x44 CostumeCategory             ( 0001866293F0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )

            return value;
        }
    }
}
