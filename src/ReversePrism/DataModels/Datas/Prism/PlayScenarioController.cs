using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 VitalityGaugeDuration                    float IL2CPP_TYPE_R4
    // 010 VitalityGauge                            00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer
    // 018 SupportEffectDemonstrateUIContent        0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 020 StartProduceAdvReply                     0001866505E0 ModelClassType IStartProduceAdvReply IStartProduceAdvReply IStartProduceAdvReply Pointer
    // 028 AdvOptionReply                           000186631230 ModelClassType ISelectProduceAdvOptionReply ISelectProduceAdvOptionReply ISelectProduceAdvOptionReply Pointer
    // 030 CacheCueName                             000186671910 ModelPrimitiveType string string string String
    // 038 CacheLabel                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C CacheIsSubSeason                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03D IsGetAdvOptionResponse                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PlayScenarioController
    {
        public VitalityGauge?                           VitalityGauge                           { get; set; }
        public SupportEffectDemonstrateUIContent?       SupportEffectDemonstrateUIContent       { get; set; }
        public IStartProduceAdvReply?                   StartProduceAdvReply                    { get; set; }
        public ISelectProduceAdvOptionReply?            AdvOptionReply                          { get; set; }
        public string                                   CacheCueName                            { get; set; }
        public int                                      CacheLabel                              { get; set; }
        public bool                                     CacheIsSubSeason                        { get; set; }
        public bool                                     IsGetAdvOptionResponse                  { get; set; }

        public static PlayScenarioController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayScenarioController();

            value.VitalityGauge                             = GetObject<VitalityGauge>(new IntPtr(p + 0x010), ReversePrism.DataModels.VitalityGauge.FromPointer); // 0270D4CF5248 0x10 VitalityGauge               ( 00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x018), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0270D4CF5268 0x18 SupportEffectDemonstrateUIContent ( 0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.StartProduceAdvReply                      = GetObject<IStartProduceAdvReply>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStartProduceAdvReply.FromPointer); // 0270D4CF5288 0x20 StartProduceAdvReply        ( 0001866505E0 ModelClassType IStartProduceAdvReply IStartProduceAdvReply IStartProduceAdvReply Pointer )
            value.AdvOptionReply                            = GetObject<ISelectProduceAdvOptionReply>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISelectProduceAdvOptionReply.FromPointer); // 0270D4CF52A8 0x28 AdvOptionReply              ( 000186631230 ModelClassType ISelectProduceAdvOptionReply ISelectProduceAdvOptionReply ISelectProduceAdvOptionReply Pointer )
            value.CacheCueName                              = GetString(new IntPtr(p + 0x030)); // 0270D4CF52C8 0x30 CacheCueName                ( 000186671910 ModelPrimitiveType string string string String )
            value.CacheLabel                                = GetInt32(new IntPtr(p + 0x038)); // 0270D4CF52E8 0x38 CacheLabel                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CacheIsSubSeason                          = GetBool(new IntPtr(p + 0x03C)); // 0270D4CF5308 0x3C CacheIsSubSeason            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsGetAdvOptionResponse                    = GetBool(new IntPtr(p + 0x03D)); // 0270D4CF5328 0x3D IsGetAdvOptionResponse      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
