using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RowCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 ColCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 SpaceTime                                0001866656B0 ModelPrimitiveType float float float Single
    // 030 MaterialPropertyBlock                    0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 038 MyRenderer                               00018665F150 ModelClassType Renderer Renderer Renderer Pointer
    // 040 Timer                                    0001866656B0 ModelPrimitiveType float float float Single
    // 044 Id                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PatternAnimation
    {
        public int                                      RowCount                                { get; set; }
        public int                                      ColCount                                { get; set; }
        public float                                    SpaceTime                               { get; set; }
        public MaterialPropertyBlock?                   MaterialPropertyBlock                   { get; set; }
        public Renderer?                                MyRenderer                              { get; set; }
        public float                                    Timer                                   { get; set; }
        public int                                      Id                                      { get; set; }

        public static PatternAnimation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PatternAnimation();

            value.RowCount                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D4DF82B8 0x20 RowCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ColCount                                  = GetInt32(new IntPtr(p + 0x024)); // 0270D4DF82D8 0x24 ColCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SpaceTime                                 = GetSingle(new IntPtr(p + 0x028)); // 0270D4DF82F8 0x28 SpaceTime                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaterialPropertyBlock                     = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x030), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0270D4DF8318 0x30 MaterialPropertyBlock       ( 0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.MyRenderer                                = GetObject<Renderer>(new IntPtr(p + 0x038), ReversePrism.DataModels.Renderer.FromPointer); // 0270D4DF8338 0x38 MyRenderer                  ( 00018665F150 ModelClassType Renderer Renderer Renderer Pointer )
            value.Timer                                     = GetSingle(new IntPtr(p + 0x040)); // 0270D4DF8358 0x40 Timer                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Id                                        = GetInt32(new IntPtr(p + 0x044)); // 0270D4DF8378 0x44 Id                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
