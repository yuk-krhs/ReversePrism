using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PlayerModel                              ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 018 EffectManager                            ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer
    // 020 CurrentStatus                            ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer
    // 028 UnitID                                   ModelPrimitiveType int int int Int32
    // 02C IconID                                   ModelPrimitiveType int int int Int32
    // 030 MemberID                                 ModelPrimitiveType int int int Int32
    // 038 BaseStatus                               ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer
    // 040 CutInVoiceCueSheetID                     ModelPrimitiveType int int int Int32
    // 044 CutInVoiceCueID                          ModelPrimitiveType int int int Int32
    public partial class IngameUnitMemberModel : DataModel
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
            var value   = new IngameUnitMemberModel() { Pointer= p0 };

            value.PlayerModel                               = GetObject<IngamePlayerModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x10 PlayerModel                 ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.EffectManager                             = GetObject<ProduceInGameEffectManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceInGameEffectManager.FromPointer); // 0x18 EffectManager               ( ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer )
            value.CurrentStatus                             = GetObject<IngamePlayerStatusModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngamePlayerStatusModel.FromPointer); // 0x20 CurrentStatus               ( ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.IconID                                    = GetInt32(new IntPtr(p + 0x02C)); // 0x2C IconID                      ( ModelPrimitiveType int int int Int32 )
            value.MemberID                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 MemberID                    ( ModelPrimitiveType int int int Int32 )
            value.BaseStatus                                = GetObject<IngamePlayerStatusModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngamePlayerStatusModel.FromPointer); // 0x38 BaseStatus                  ( ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer )
            value.CutInVoiceCueSheetID                      = GetInt32(new IntPtr(p + 0x040)); // 0x40 CutInVoiceCueSheetID        ( ModelPrimitiveType int int int Int32 )
            value.CutInVoiceCueID                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 CutInVoiceCueID             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
