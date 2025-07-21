using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 018 ScreenType                               ModelPrimitiveType int int int Int32
    // 01C MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 020 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 024 ReachedGrowthLimit                       ModelPrimitiveType bool bool bool Bool
    // 028 MstVoiceResourceId                       ModelPrimitiveType int int int Int32
    // 030 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 Voice                                    ModelClassType MstVoiceResource MstVoiceResource MstVoiceResource Pointer
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.ScreenType                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScreenType                  ( ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.ReachedGrowthLimit                        = GetBool(new IntPtr(p + 0x024)); // 0x24 ReachedGrowthLimit          ( ModelPrimitiveType bool bool bool Bool )
            value.MstVoiceResourceId                        = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstVoiceResourceId          ( ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x030)); // 0x30 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Voice                                     = GetObject<MstVoiceResource>(new IntPtr(p + 0x038), ReversePrism.DataModels.MstVoiceResource.FromPointer); // 0x38 Voice                       ( ModelClassType MstVoiceResource MstVoiceResource MstVoiceResource Pointer )

            return value;
        }
    }
}
