using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntroductionStatus                       000186587750 ModelClassType IIntroductionStatus IIntroductionStatus IIntroductionStatus Pointer
    // 018 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 NextViewType                             0001866936B0 ModelClassType Type Type Type Pointer
    // 028 CharaMaster                              00018661C140 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 030 ScenarioId                               0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer
    // 038 Reward                                   0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 040 UnitIdol                                 00018670C980 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 048 CueSheetName                             000186672F10 ModelPrimitiveType string string string String
    // 050 CueName                                  000186672F10 ModelPrimitiveType string string string String
    // 058 LetterImagePath                          000186672F10 ModelPrimitiveType string string string String
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

            value.IntroductionStatus                        = GetObject<IIntroductionStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIntroductionStatus.FromPointer); // 0245A4EFAAB0 0x10 IntroductionStatus          ( 000186587750 ModelClassType IIntroductionStatus IIntroductionStatus IIntroductionStatus Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A4EFAAD0 0x18 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NextViewType                              = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0245A4EFAAF0 0x20 NextViewType                ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.CharaMaster                               = GetObject<MstCharacterInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0245A4EFAB10 0x28 CharaMaster                 ( 00018661C140 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.ScenarioId                                = GetObject<ScenarioID>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScenarioID.FromPointer); // 0245A4EFAB30 0x30 ScenarioId                  ( 0001866C4FD0 ModelClassType ScenarioID ScenarioID ScenarioID Pointer )
            value.Reward                                    = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0245A4EFAB50 0x38 Reward                      ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0245A4EFAB70 0x40 UnitIdol                    ( 00018670C980 ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x048)); // 0245A4EFAB90 0x48 CueSheetName                ( 000186672F10 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x050)); // 0245A4EFABB0 0x50 CueName                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.LetterImagePath                           = GetString(new IntPtr(p + 0x058)); // 0245A4EFABD0 0x58 LetterImagePath             ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
