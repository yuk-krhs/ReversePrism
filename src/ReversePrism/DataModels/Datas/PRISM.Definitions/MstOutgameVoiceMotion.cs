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
    public partial class MstOutgameVoiceMotion
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
            var value   = new MstOutgameVoiceMotion();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045BFE48 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0270045BFE68 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScreenType                                = GetInt32(new IntPtr(p + 0x018)); // 0270045BFE88 0x18 ScreenType                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x01C)); // 0270045BFEA8 0x1C MstProduceIdolId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x020)); // 0270045BFEC8 0x20 MstSupportCharacterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReachedGrowthLimit                        = GetBool(new IntPtr(p + 0x024)); // 0270045BFEE8 0x24 ReachedGrowthLimit          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.MstVoiceResourceId                        = GetInt32(new IntPtr(p + 0x028)); // 0270045BFF08 0x28 MstVoiceResourceId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x030)); // 0270045BFF28 0x30 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Voice                                     = GetObject<MstVoiceResource>(new IntPtr(p + 0x038), ReversePrism.DataModels.MstVoiceResource.FromPointer); // 0270045BFF48 0x38 Voice                       ( 000186631200 ModelClassType MstVoiceResource MstVoiceResource MstVoiceResource Pointer )

            return value;
        }
    }
}
