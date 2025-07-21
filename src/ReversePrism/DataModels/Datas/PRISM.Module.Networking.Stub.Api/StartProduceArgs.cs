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
    // 018 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 000 DifficultyFieldNumber                    int IL2CPP_TYPE_I4
    // 01C Difficulty                               ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 000 UnitNumberIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 UnitNumberId                             ModelPrimitiveType int int int Int32
    // 000 FriendSupportCharacterIdFieldNumber      int IL2CPP_TYPE_I4
    // 028 FriendSupportCharacterId                 ModelPrimitiveType string string string String
    // 000 InheritanceFesUnitIdFieldNumber          int IL2CPP_TYPE_I4
    // 030 InheritanceFesUnitId                     ModelPrimitiveType string string string String
    // 000 IsAutoPlayFieldNumber                    int IL2CPP_TYPE_I4
    // 038 IsAutoPlay                               ModelPrimitiveType bool bool bool Bool
    // 000 AutoPlaySettingsFieldNumber              int IL2CPP_TYPE_I4
    // 040 AutoPlaySettings                         ModelClassType ProduceAutoPlaySettingsStatus ProduceAutoPlaySettingsStatus ProduceAutoPlaySettingsStatus Pointer
    // 000 ProduceBoostFieldNumber                  int IL2CPP_TYPE_I4
    // 048 ProduceBoost                             ModelPrimitiveType int int int Int32
    public partial class StartProduceArgs : DataModel
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
            var value   = new StartProduceArgs() { Pointer= p0 };

            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.Difficulty                                = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Difficulty                  ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.UnitNumberId                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 UnitNumberId                ( ModelPrimitiveType int int int Int32 )
            value.FriendSupportCharacterId                  = GetString(new IntPtr(p + 0x028)); // 0x28 FriendSupportCharacterId    ( ModelPrimitiveType string string string String )
            value.InheritanceFesUnitId                      = GetString(new IntPtr(p + 0x030)); // 0x30 InheritanceFesUnitId        ( ModelPrimitiveType string string string String )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x038)); // 0x38 IsAutoPlay                  ( ModelPrimitiveType bool bool bool Bool )
            value.AutoPlaySettings                          = GetObject<ProduceAutoPlaySettingsStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceAutoPlaySettingsStatus.FromPointer); // 0x40 AutoPlaySettings            ( ModelClassType ProduceAutoPlaySettingsStatus ProduceAutoPlaySettingsStatus ProduceAutoPlaySettingsStatus Pointer )
            value.ProduceBoost                              = GetInt32(new IntPtr(p + 0x048)); // 0x48 ProduceBoost                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
