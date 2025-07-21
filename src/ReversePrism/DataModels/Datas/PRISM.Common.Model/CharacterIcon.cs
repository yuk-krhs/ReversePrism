using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 FavoriteMarkIdRP                         ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 Type                                     ModelEnumType CharacterType CharacterType CharacterType Int32
    // 024 CharaId                                  ModelPrimitiveType int int int Int32
    // 028 BaseIdolId                               ModelPrimitiveType int int int Int32
    // 030 CreateDate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 Enable                                   ModelPrimitiveType bool bool bool Bool
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

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 OnSelected                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.FavoriteMarkIdRP                          = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x18 FavoriteMarkIdRP            ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.Type                                      = (CharacterType)GetInt32(new IntPtr(p + 0x020)); // 0x20 Type                        ( ModelEnumType CharacterType CharacterType CharacterType Int32 )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.BaseIdolId                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 BaseIdolId                  ( ModelPrimitiveType int int int Int32 )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x030)); // 0x30 CreateDate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Enable                                    = GetBool(new IntPtr(p + 0x038)); // 0x38 Enable                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
