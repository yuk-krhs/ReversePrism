using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsProduceIdol                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 MstId                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Phase3Step2Name                          000186671910 ModelPrimitiveType string string string String
    // 028 P7CueSheetName                           000186671910 ModelPrimitiveType string string string String
    // 030 P7CueName                                000186671910 ModelPrimitiveType string string string String
    // 038 P7VoiceResourceId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 P8CueSheetName                           000186671910 ModelPrimitiveType string string string String
    // 048 P8CueName                                000186671910 ModelPrimitiveType string string string String
    // 050 P8UsmName                                000186671910 ModelPrimitiveType string string string String
    // 058 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 ExtraList                                000185CF9FA8 ModelClassListType IReadOnlyList`1<IGashaExtraRewardProductStatus> IReadOnlyList`1<IGashaExtraRewardProductStatus> List<IGashaExtraRewardProductStatus> Pointer
    // 068 ConvertProduct                           0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    public partial class MoviePlayerModel : DataModel
    {
        public bool                                     IsProduceIdol                           { get; set; }
        public int                                      MstId                                   { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public string                                   Phase3Step2Name                         { get; set; }
        public string                                   P7CueSheetName                          { get; set; }
        public string                                   P7CueName                               { get; set; }
        public int                                      P7VoiceResourceId                       { get; set; }
        public string                                   P8CueSheetName                          { get; set; }
        public string                                   P8CueName                               { get; set; }
        public string                                   P8UsmName                               { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public List<IGashaExtraRewardProductStatus>?    ExtraList                               { get; set; }
        public IProductWithAmountStatus?                ConvertProduct                          { get; set; }

        public static MoviePlayerModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoviePlayerModel() { Pointer= p0 };

            value.IsProduceIdol                             = GetBool(new IntPtr(p + 0x010)); // 024665EDDB18 0x10 IsProduceIdol               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x014)); // 024665EDDB38 0x14 MstId                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x018)); // 024665EDDB58 0x18 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Phase3Step2Name                           = GetString(new IntPtr(p + 0x020)); // 024665EDDB78 0x20 Phase3Step2Name             ( 000186671910 ModelPrimitiveType string string string String )
            value.P7CueSheetName                            = GetString(new IntPtr(p + 0x028)); // 024665EDDB98 0x28 P7CueSheetName              ( 000186671910 ModelPrimitiveType string string string String )
            value.P7CueName                                 = GetString(new IntPtr(p + 0x030)); // 024665EDDBB8 0x30 P7CueName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.P7VoiceResourceId                         = GetInt32(new IntPtr(p + 0x038)); // 024665EDDBD8 0x38 P7VoiceResourceId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.P8CueSheetName                            = GetString(new IntPtr(p + 0x040)); // 024665EDDBF8 0x40 P8CueSheetName              ( 000186671910 ModelPrimitiveType string string string String )
            value.P8CueName                                 = GetString(new IntPtr(p + 0x048)); // 024665EDDC18 0x48 P8CueName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.P8UsmName                                 = GetString(new IntPtr(p + 0x050)); // 024665EDDC38 0x50 P8UsmName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x058)); // 024665EDDC58 0x58 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ExtraList                                 = GetObjectList<IGashaExtraRewardProductStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IGashaExtraRewardProductStatus.FromPointer); // 024665EDDC78 0x60 ExtraList                   ( 000185CF9FA8 ModelClassListType IReadOnlyList`1<IGashaExtraRewardProductStatus> IReadOnlyList`1<IGashaExtraRewardProductStatus> List<IGashaExtraRewardProductStatus> Pointer )
            value.ConvertProduct                            = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024665EDDC98 0x68 ConvertProduct              ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )

            return value;
        }
    }
}
