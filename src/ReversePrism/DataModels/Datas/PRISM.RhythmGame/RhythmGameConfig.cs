using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 NoteDesignCount                          ModelPrimitiveType int int int Int32
    // 01C NoteEffectDesignCount                    ModelPrimitiveType int int int Int32
    // 020 TapSECount                               ModelPrimitiveType int int int Int32
    // 024 FlickSECount                             ModelPrimitiveType int int int Int32
    public partial class RhythmGameConfig : DataModel
    {
        public int                                      NoteDesignCount                         { get; set; }
        public int                                      NoteEffectDesignCount                   { get; set; }
        public int                                      TapSECount                              { get; set; }
        public int                                      FlickSECount                            { get; set; }

        public static RhythmGameConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameConfig() { Pointer= p0 };

            value.NoteDesignCount                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 NoteDesignCount             ( ModelPrimitiveType int int int Int32 )
            value.NoteEffectDesignCount                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NoteEffectDesignCount       ( ModelPrimitiveType int int int Int32 )
            value.TapSECount                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 TapSECount                  ( ModelPrimitiveType int int int Int32 )
            value.FlickSECount                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 FlickSECount                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
