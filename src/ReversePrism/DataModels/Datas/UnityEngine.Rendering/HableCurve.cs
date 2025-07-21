using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WhitePoint                               ModelPrimitiveType float float float Single
    // 014 InverseWhitePoint                        ModelPrimitiveType float float float Single
    // 018 X0                                       ModelPrimitiveType float float float Single
    // 01C X1                                       ModelPrimitiveType float float float Single
    // 020 Segments                                 ModelClassListType Segment[] Segment[] List<Segment> Pointer
    // 028 Uniforms                                 ModelClassType Uniforms Uniforms Uniforms Pointer
    public partial class HableCurve : DataModel
    {
        public float                                    WhitePoint                              { get; set; }
        public float                                    InverseWhitePoint                       { get; set; }
        public float                                    X0                                      { get; set; }
        public float                                    X1                                      { get; set; }
        public List<Segment>?                           Segments                                { get; set; }
        public Uniforms?                                Uniforms                                { get; set; }

        public static HableCurve? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HableCurve() { Pointer= p0 };

            value.WhitePoint                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 WhitePoint                  ( ModelPrimitiveType float float float Single )
            value.InverseWhitePoint                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 InverseWhitePoint           ( ModelPrimitiveType float float float Single )
            value.X0                                        = GetSingle(new IntPtr(p + 0x018)); // 0x18 X0                          ( ModelPrimitiveType float float float Single )
            value.X1                                        = GetSingle(new IntPtr(p + 0x01C)); // 0x1C X1                          ( ModelPrimitiveType float float float Single )
            value.Segments                                  = GetObjectList<Segment>(new IntPtr(p + 0x020), ReversePrism.DataModels.Segment.FromPointer); // 0x20 Segments                    ( ModelClassListType Segment[] Segment[] List<Segment> Pointer )
            value.Uniforms                                  = GetObject<Uniforms>(new IntPtr(p + 0x028), ReversePrism.DataModels.Uniforms.FromPointer); // 0x28 Uniforms                    ( ModelClassType Uniforms Uniforms Uniforms Pointer )

            return value;
        }
    }
}
