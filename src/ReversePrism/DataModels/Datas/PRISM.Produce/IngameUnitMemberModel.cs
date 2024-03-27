using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PlayerModel                              0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 018 EffectManager                            000186557830 ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer
    // 020 CurrentStatus                            0001865E6A80 ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer
    // 028 UnitID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 02C IconID                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 030 MemberID                                 0001865F4940 ModelPrimitiveType int int int Int32
    // 038 BaseStatus                               0001865E6A80 ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer
    // 040 CutInVoiceCueSheetID                     0001865F4940 ModelPrimitiveType int int int Int32
    // 044 CutInVoiceCueID                          0001865F4940 ModelPrimitiveType int int int Int32
    public partial class IngameUnitMemberModel
    {
        public IngamePlayerModel?                       PlayerModel                             { get; set; }
        public ProduceInGameEffectManager?              EffectManager                           { get; set; }
        public IngamePlayerStatusModel?                 CurrentStatus                           { get; set; }
        public int                                      UnitID                                  { get; set; }
        public int                                      IconID                                  { get; set; }
        public int                                      MemberID                                { get; set; }
        public IngamePlayerStatusModel?                 BaseStatus                              { get; set; }
        public int                                      CutInVoiceCueSheetID                    { get; set; }
        public int                                      CutInVoiceCueID                         { get; set; }

        public static IngameUnitMemberModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameUnitMemberModel();

            value.PlayerModel                               = GetObject<IngamePlayerModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0270D5B69E90 0x10 PlayerModel                 ( 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.EffectManager                             = GetObject<ProduceInGameEffectManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceInGameEffectManager.FromPointer); // 0270D5B69EB0 0x18 EffectManager               ( 000186557830 ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer )
            value.CurrentStatus                             = GetObject<IngamePlayerStatusModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngamePlayerStatusModel.FromPointer); // 0270D5B69ED0 0x20 CurrentStatus               ( 0001865E6A80 ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D5B69EF0 0x28 UnitID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x02C)); // 0270D5B69F10 0x2C IconID                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.MemberID                                  = GetInt32(new IntPtr(p + 0x030)); // 0270D5B69F30 0x30 MemberID                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.BaseStatus                                = GetObject<IngamePlayerStatusModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngamePlayerStatusModel.FromPointer); // 0270D5B69F50 0x38 BaseStatus                  ( 0001865E6A80 ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer )
            value.CutInVoiceCueSheetID                      = GetInt32(new IntPtr(p + 0x040)); // 0270D5B69F70 0x40 CutInVoiceCueSheetID        ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.CutInVoiceCueID                           = GetInt32(new IntPtr(p + 0x044)); // 0270D5B69F90 0x44 CutInVoiceCueID             ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
