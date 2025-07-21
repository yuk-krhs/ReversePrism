using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 batchSize                                int IL2CPP_TYPE_I4
    // 000 headerLength                             int IL2CPP_TYPE_I4
    // 010 bins                                     NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 020 minMaxZs                                 NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 030 ZBinScale                                ModelPrimitiveType float float float Single
    // 034 ZBinOffset                               ModelPrimitiveType float float float Single
    // 038 BinCount                                 ModelPrimitiveType int int int Int32
    // 03C WordsPerTile                             ModelPrimitiveType int int int Int32
    // 040 LightCount                               ModelPrimitiveType int int int Int32
    // 044 ReflectionProbeCount                     ModelPrimitiveType int int int Int32
    // 048 BatchCount                               ModelPrimitiveType int int int Int32
    // 04C ViewCount                                ModelPrimitiveType int int int Int32
    // 050 IsOrthographic                           ModelPrimitiveType bool bool bool Bool
    public partial class ZBinningJob : DataModel
    {
        public float                                    ZBinScale                               { get; set; }
        public float                                    ZBinOffset                              { get; set; }
        public int                                      BinCount                                { get; set; }
        public int                                      WordsPerTile                            { get; set; }
        public int                                      LightCount                              { get; set; }
        public int                                      ReflectionProbeCount                    { get; set; }
        public int                                      BatchCount                              { get; set; }
        public int                                      ViewCount                               { get; set; }
        public bool                                     IsOrthographic                          { get; set; }

        public static ZBinningJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ZBinningJob() { Pointer= p0 };

            value.ZBinScale                                 = GetSingle(new IntPtr(p + 0x030)); // 0x30 ZBinScale                   ( ModelPrimitiveType float float float Single )
            value.ZBinOffset                                = GetSingle(new IntPtr(p + 0x034)); // 0x34 ZBinOffset                  ( ModelPrimitiveType float float float Single )
            value.BinCount                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 BinCount                    ( ModelPrimitiveType int int int Int32 )
            value.WordsPerTile                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C WordsPerTile                ( ModelPrimitiveType int int int Int32 )
            value.LightCount                                = GetInt32(new IntPtr(p + 0x040)); // 0x40 LightCount                  ( ModelPrimitiveType int int int Int32 )
            value.ReflectionProbeCount                      = GetInt32(new IntPtr(p + 0x044)); // 0x44 ReflectionProbeCount        ( ModelPrimitiveType int int int Int32 )
            value.BatchCount                                = GetInt32(new IntPtr(p + 0x048)); // 0x48 BatchCount                  ( ModelPrimitiveType int int int Int32 )
            value.ViewCount                                 = GetInt32(new IntPtr(p + 0x04C)); // 0x4C ViewCount                   ( ModelPrimitiveType int int int Int32 )
            value.IsOrthographic                            = GetBool(new IntPtr(p + 0x050)); // 0x50 IsOrthographic              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
