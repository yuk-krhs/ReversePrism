using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 NoteDesignCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C NoteEffectDesignCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 TapSECount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 FlickSECount                             0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.NoteDesignCount                           = GetInt32(new IntPtr(p + 0x018)); // 02466505C3C8 0x18 NoteDesignCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NoteEffectDesignCount                     = GetInt32(new IntPtr(p + 0x01C)); // 02466505C3E8 0x1C NoteEffectDesignCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TapSECount                                = GetInt32(new IntPtr(p + 0x020)); // 02466505C408 0x20 TapSECount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FlickSECount                              = GetInt32(new IntPtr(p + 0x024)); // 02466505C428 0x24 FlickSECount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
