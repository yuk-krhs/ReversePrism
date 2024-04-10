using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ScreenType                               0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MstProduceIdolId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 020 MstSupportCharacterId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 024 ReachedGrowthLimit                       0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 028 MstVoiceResourceId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 030 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 Voice                                    000186631200 ModelClassType MstVoiceResource MstVoiceResource MstVoiceResource Pointer
    public partial class MstOutgameVoiceMotion : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      ScreenType                              { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public bool                                     ReachedGrowthLimit                      { get; set; }
        public int                                      MstVoiceResourceId                      { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public MstVoiceResource?                        Voice                                   { get; set; }

        public static MstOutgameVoiceMotion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstOutgameVoiceMotion() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A464C700 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0245A464C720 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScreenType                                = GetInt32(new IntPtr(p + 0x018)); // 0245A464C740 0x18 ScreenType                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x01C)); // 0245A464C760 0x1C MstProduceIdolId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x020)); // 0245A464C780 0x20 MstSupportCharacterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReachedGrowthLimit                        = GetBool(new IntPtr(p + 0x024)); // 0245A464C7A0 0x24 ReachedGrowthLimit          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.MstVoiceResourceId                        = GetInt32(new IntPtr(p + 0x028)); // 0245A464C7C0 0x28 MstVoiceResourceId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x030)); // 0245A464C7E0 0x30 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Voice                                     = GetObject<MstVoiceResource>(new IntPtr(p + 0x038), ReversePrism.DataModels.MstVoiceResource.FromPointer); // 0245A464C800 0x38 Voice                       ( 000186631200 ModelClassType MstVoiceResource MstVoiceResource MstVoiceResource Pointer )

            return value;
        }
    }
}
