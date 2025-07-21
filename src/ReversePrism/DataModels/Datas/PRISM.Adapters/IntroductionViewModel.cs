using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntroductionStatus                       ModelClassType IIntroductionStatus IIntroductionStatus IIntroductionStatus Pointer
    // 018 CharaId                                  ModelPrimitiveType int int int Int32
    // 020 NextViewType                             ModelClassType Type Type Type Pointer
    // 028 CharaMaster                              ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 030 ScenarioId                               ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 038 Reward                                   ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 040 UnitIdol                                 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 048 CueSheetName                             ModelPrimitiveType string string string String
    // 050 CueName                                  ModelPrimitiveType string string string String
    // 058 LetterImagePath                          ModelPrimitiveType string string string String
    public partial class IntroductionViewModel : DataModel
    {
        public IIntroductionStatus?                     IntroductionStatus                      { get; set; }
        public int                                      CharaId                                 { get; set; }
        public Type?                                    NextViewType                            { get; set; }
        public MstCharacterInfo?                        CharaMaster                             { get; set; }
        public ScenarioID?                              ScenarioId                              { get; set; }
        public IProductWithAmountStatus?                Reward                                  { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }
        public string                                   LetterImagePath                         { get; set; }

        public static IntroductionViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionViewModel() { Pointer= p0 };

            value.IntroductionStatus                        = GetObject<IIntroductionStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIntroductionStatus.FromPointer); // 0x10 IntroductionStatus          ( ModelClassType IIntroductionStatus IIntroductionStatus IIntroductionStatus Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.NextViewType                              = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 NextViewType                ( ModelClassType Type Type Type Pointer )
            value.CharaMaster                               = GetObject<MstCharacterInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0x28 CharaMaster                 ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScenarioID.FromPointer); // 0x30 ScenarioId                  ( ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.Reward                                    = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x38 Reward                      ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x40 UnitIdol                    ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x048)); // 0x48 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x050)); // 0x50 CueName                     ( ModelPrimitiveType string string string String )
            value.LetterImagePath                           = GetString(new IntPtr(p + 0x058)); // 0x58 LetterImagePath             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
