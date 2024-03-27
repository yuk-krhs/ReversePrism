using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgCostumeIcon                           000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 UiGrayOutController                      0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 030 GoLockImg                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 GoReleasedLabel                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 050 onClickPartTypeSubject                   Subject`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    // 058 onLongTapSubject                         Subject`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    // 060 CostumePartType                          00018662DEE0 ModelEnumType CostumePartType CostumePartType CostumePartType Int32
    // 064 MstId                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 PartType                                 00018662DEE0 ModelEnumType CostumePartType CostumePartType CostumePartType Int32
    // 06C Id                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CostumeIconView
    {
        public RawImage?                                ImgCostumeIcon                          { get; set; }
        public UIGrayOutController?                     UiGrayOutController                     { get; set; }
        public GameObject?                              GoLockImg                               { get; set; }
        public GameObject?                              GoReleasedLabel                         { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public CostumePartType                          CostumePartType                         { get; set; }
        public int                                      MstId                                   { get; set; }
        public CostumePartType                          PartType                                { get; set; }
        public int                                      Id                                      { get; set; }

        public static CostumeIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeIconView();

            value.ImgCostumeIcon                            = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270DA25FCB8 0x20 ImgCostumeIcon              ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.UiGrayOutController                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA25FCD8 0x28 UiGrayOutController         ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.GoLockImg                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA25FCF8 0x30 GoLockImg                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoReleasedLabel                           = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA25FD18 0x38 GoReleasedLabel             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA25FD38 0x40 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x048)); // 0270DA25FD58 0x48 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.CostumePartType                           = (CostumePartType)GetInt32(new IntPtr(p + 0x060)); // 0270DA25FDB8 0x60 CostumePartType             ( 00018662DEE0 ModelEnumType CostumePartType CostumePartType CostumePartType Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x064)); // 0270DA25FDD8 0x64 MstId                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PartType                                  = (CostumePartType)GetInt32(new IntPtr(p + 0x068)); // 0270DA25FDF8 0x68 PartType                    ( 00018662DEE0 ModelEnumType CostumePartType CostumePartType CostumePartType Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x06C)); // 0270DA25FE18 0x6C Id                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
