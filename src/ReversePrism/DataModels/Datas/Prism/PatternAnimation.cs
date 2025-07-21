using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RowCount                                 ModelPrimitiveType int int int Int32
    // 024 ColCount                                 ModelPrimitiveType int int int Int32
    // 028 SpaceTime                                ModelPrimitiveType float float float Single
    // 030 MaterialPropertyBlock                    ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 038 MyRenderer                               ModelClassType Renderer Renderer Renderer Pointer
    // 040 Timer                                    ModelPrimitiveType float float float Single
    // 044 Id                                       ModelPrimitiveType int int int Int32
    public partial class PatternAnimation : DataModel
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
            var value   = new PatternAnimation() { Pointer= p0 };

            value.RowCount                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 RowCount                    ( ModelPrimitiveType int int int Int32 )
            value.ColCount                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 ColCount                    ( ModelPrimitiveType int int int Int32 )
            value.SpaceTime                                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 SpaceTime                   ( ModelPrimitiveType float float float Single )
            value.MaterialPropertyBlock                     = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x030), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0x30 MaterialPropertyBlock       ( ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.MyRenderer                                = GetObject<Renderer>(new IntPtr(p + 0x038), ReversePrism.DataModels.Renderer.FromPointer); // 0x38 MyRenderer                  ( ModelClassType Renderer Renderer Renderer Pointer )
            value.Timer                                     = GetSingle(new IntPtr(p + 0x040)); // 0x40 Timer                       ( ModelPrimitiveType float float float Single )
            value.Id                                        = GetInt32(new IntPtr(p + 0x044)); // 0x44 Id                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
