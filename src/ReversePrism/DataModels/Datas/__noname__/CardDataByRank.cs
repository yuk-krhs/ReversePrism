using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Rank                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 CardName                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 Attribute                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 IsCpuOnly                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 Price                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C Cost                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 ValueTypes                               000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 Values                                   000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 Explanation                              0001866722E0 ModelPrimitiveType string string string String
    // 048 EffectIds                                000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 IllustId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 058 BuffDebuffId                             000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class CardDataByRank : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      Rank                                    { get; set; }
        public string                                   CardName                                { get; set; }
        public int                                      Attribute                               { get; set; }
        public bool                                     IsCpuOnly                               { get; set; }
        public int                                      Price                                   { get; set; }
        public int                                      Cost                                    { get; set; }
        public List<int>?                               ValueTypes                              { get; set; }
        public List<float>?                             Values                                  { get; set; }
        public string                                   Explanation                             { get; set; }
        public List<int>?                               EffectIds                               { get; set; }
        public int                                      IllustId                                { get; set; }
        public List<float>?                             BuffDebuffId                            { get; set; }

        public static CardDataByRank? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardDataByRank() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 024665143A38 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x014)); // 024665143A58 0x14 Rank                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CardName                                  = GetString(new IntPtr(p + 0x018)); // 024665143A78 0x18 CardName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Attribute                                 = GetInt32(new IntPtr(p + 0x020)); // 024665143A98 0x20 Attribute                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsCpuOnly                                 = GetBool(new IntPtr(p + 0x024)); // 024665143AB8 0x24 IsCpuOnly                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Price                                     = GetInt32(new IntPtr(p + 0x028)); // 024665143AD8 0x28 Price                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x02C)); // 024665143AF8 0x2C Cost                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ValueTypes                                = GetInt32List(new IntPtr(p + 0x030)); // 024665143B18 0x30 ValueTypes                  ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Values                                    = GetSingleList(new IntPtr(p + 0x038)); // 024665143B38 0x38 Values                      ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Explanation                               = GetString(new IntPtr(p + 0x040)); // 024665143B58 0x40 Explanation                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.EffectIds                                 = GetInt32List(new IntPtr(p + 0x048)); // 024665143B78 0x48 EffectIds                   ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IllustId                                  = GetInt32(new IntPtr(p + 0x050)); // 024665143B98 0x50 IllustId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BuffDebuffId                              = GetSingleList(new IntPtr(p + 0x058)); // 024665143BB8 0x58 BuffDebuffId                ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
