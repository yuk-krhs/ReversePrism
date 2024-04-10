using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 FavoriteMarkIdRP                         000186714830 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 Type                                     0001865A7320 ModelEnumType CharacterType CharacterType CharacterType Int32
    // 024 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 BaseIdolId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 CreateDate                               0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CharacterIcon : DataModel
    {
        public BoolReactiveProperty?                    OnSelected                              { get; set; }
        public IntReactiveProperty?                     FavoriteMarkIdRP                        { get; set; }
        public CharacterType                            Type                                    { get; set; }
        public int                                      CharaId                                 { get; set; }
        public int                                      BaseIdolId                              { get; set; }
        public DateTime                                 CreateDate                              { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static CharacterIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterIcon() { Pointer= p0 };

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 024664CE6C10 0x10 OnSelected                  ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 024664CE6C30 0x18 FavoriteMarkIdRP            ( 000186714830 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.Type                                      = (CharacterType)GetInt32(new IntPtr(p + 0x020)); // 024664CE6C50 0x20 Type                        ( 0001865A7320 ModelEnumType CharacterType CharacterType CharacterType Int32 )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x024)); // 024664CE6C70 0x24 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseIdolId                                = GetInt32(new IntPtr(p + 0x028)); // 024664CE6C90 0x28 BaseIdolId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x030)); // 024664CE6CB0 0x30 CreateDate                  ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Enable                                    = GetBool(new IntPtr(p + 0x038)); // 024664CE6CD0 0x38 Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
