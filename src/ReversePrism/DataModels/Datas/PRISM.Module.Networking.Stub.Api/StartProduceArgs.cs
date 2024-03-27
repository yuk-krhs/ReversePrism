using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartProduceArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEpisodeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 018 MstEpisodeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DifficultyFieldNumber                    int IL2CPP_TYPE_I4
    // 01C Difficulty                               00018653B4F0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 000 UnitNumberIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 UnitNumberId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FriendSupportCharacterIdFieldNumber      int IL2CPP_TYPE_I4
    // 028 FriendSupportCharacterId                 000186671910 ModelPrimitiveType string string string String
    // 000 InheritanceFesUnitIdFieldNumber          int IL2CPP_TYPE_I4
    // 030 InheritanceFesUnitId                     000186671910 ModelPrimitiveType string string string String
    // 000 IsAutoPlayFieldNumber                    int IL2CPP_TYPE_I4
    // 038 IsAutoPlay                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 AutoPlaySettingsFieldNumber              int IL2CPP_TYPE_I4
    // 040 AutoPlaySettings                         00018652E370 ModelClassType ProduceAutoPlaySettingsStatus ProduceAutoPlaySettingsStatus ProduceAutoPlaySettingsStatus Pointer
    // 000 ProduceBoostFieldNumber                  int IL2CPP_TYPE_I4
    // 048 ProduceBoost                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StartProduceArgs
    {
        public int                                      MstEpisodeId                            { get; set; }
        public ProduceDifficultyType                    Difficulty                              { get; set; }
        public int                                      UnitNumberId                            { get; set; }
        public string                                   FriendSupportCharacterId                { get; set; }
        public string                                   InheritanceFesUnitId                    { get; set; }
        public bool                                     IsAutoPlay                              { get; set; }
        public ProduceAutoPlaySettingsStatus?           AutoPlaySettings                        { get; set; }
        public int                                      ProduceBoost                            { get; set; }

        public static StartProduceArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartProduceArgs();

            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x018)); // 0270D25B2C98 0x18 MstEpisodeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Difficulty                                = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x01C)); // 0270D25B2CD8 0x1C Difficulty                  ( 00018653B4F0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.UnitNumberId                              = GetInt32(new IntPtr(p + 0x020)); // 0270D25B2D18 0x20 UnitNumberId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FriendSupportCharacterId                  = GetString(new IntPtr(p + 0x028)); // 0270D25B2D58 0x28 FriendSupportCharacterId    ( 000186671910 ModelPrimitiveType string string string String )
            value.InheritanceFesUnitId                      = GetString(new IntPtr(p + 0x030)); // 0270D25B2D98 0x30 InheritanceFesUnitId        ( 000186671910 ModelPrimitiveType string string string String )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x038)); // 0270D25B2DD8 0x38 IsAutoPlay                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoPlaySettings                          = GetObject<ProduceAutoPlaySettingsStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceAutoPlaySettingsStatus.FromPointer); // 0270D25B2E18 0x40 AutoPlaySettings            ( 00018652E370 ModelClassType ProduceAutoPlaySettingsStatus ProduceAutoPlaySettingsStatus ProduceAutoPlaySettingsStatus Pointer )
            value.ProduceBoost                              = GetInt32(new IntPtr(p + 0x048)); // 0270D25B2E58 0x48 ProduceBoost                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
