using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 Rank                                     ModelPrimitiveType int int int Int32
    // 018 CardName                                 ModelPrimitiveType string string string String
    // 020 Attribute                                ModelPrimitiveType int int int Int32
    // 024 IsCpuOnly                                ModelPrimitiveType bool bool bool Bool
    // 028 Price                                    ModelPrimitiveType int int int Int32
    // 02C Cost                                     ModelPrimitiveType int int int Int32
    // 030 ValueTypes                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 Values                                   ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 Explanation                              ModelPrimitiveType string string string String
    // 048 EffectIds                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 IllustId                                 ModelPrimitiveType int int int Int32
    // 058 BuffDebuffId                             ModelPrimitiveListType float[] float[] List<float> Pointer
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.CardName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 CardName                    ( ModelPrimitiveType string string string String )
            value.Attribute                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 Attribute                   ( ModelPrimitiveType int int int Int32 )
            value.IsCpuOnly                                 = GetBool(new IntPtr(p + 0x024)); // 0x24 IsCpuOnly                   ( ModelPrimitiveType bool bool bool Bool )
            value.Price                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Price                       ( ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Cost                        ( ModelPrimitiveType int int int Int32 )
            value.ValueTypes                                = GetInt32List(new IntPtr(p + 0x030)); // 0x30 ValueTypes                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Values                                    = GetSingleList(new IntPtr(p + 0x038)); // 0x38 Values                      ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Explanation                               = GetString(new IntPtr(p + 0x040)); // 0x40 Explanation                 ( ModelPrimitiveType string string string String )
            value.EffectIds                                 = GetInt32List(new IntPtr(p + 0x048)); // 0x48 EffectIds                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IllustId                                  = GetInt32(new IntPtr(p + 0x050)); // 0x50 IllustId                    ( ModelPrimitiveType int int int Int32 )
            value.BuffDebuffId                              = GetSingleList(new IntPtr(p + 0x058)); // 0x58 BuffDebuffId                ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
