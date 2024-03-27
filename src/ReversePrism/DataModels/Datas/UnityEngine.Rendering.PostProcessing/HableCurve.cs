using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WhitePoint                               0001866656B0 ModelPrimitiveType float float float Single
    // 014 InverseWhitePoint                        0001866656B0 ModelPrimitiveType float float float Single
    // 018 X0                                       0001866656B0 ModelPrimitiveType float float float Single
    // 01C X1                                       0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_Segments                               000185CBB6E8 ModelClassListType Segment[] Segment[] List<Segment> Pointer
    // 028 Uniforms                                 00018652E4B0 ModelClassType Uniforms Uniforms Uniforms Pointer
    public partial class HableCurve
    {
        public float                                    WhitePoint                              { get; set; }
        public float                                    InverseWhitePoint                       { get; set; }
        public float                                    X0                                      { get; set; }
        public float                                    X1                                      { get; set; }
        public List<Segment>?                           M_Segments                              { get; set; }
        public Uniforms?                                Uniforms                                { get; set; }

        public static HableCurve? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HableCurve();

            value.WhitePoint                                = GetSingle(new IntPtr(p + 0x010)); // 0270DB41F4D0 0x10 WhitePoint                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InverseWhitePoint                         = GetSingle(new IntPtr(p + 0x014)); // 0270DB41F4F0 0x14 InverseWhitePoint           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.X0                                        = GetSingle(new IntPtr(p + 0x018)); // 0270DB41F510 0x18 X0                          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.X1                                        = GetSingle(new IntPtr(p + 0x01C)); // 0270DB41F530 0x1C X1                          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Segments                                = GetObjectList<Segment>(new IntPtr(p + 0x020), ReversePrism.DataModels.Segment.FromPointer); // 0270DB41F550 0x20 M_Segments                  ( 000185CBB6E8 ModelClassListType Segment[] Segment[] List<Segment> Pointer )
            value.Uniforms                                  = GetObject<Uniforms>(new IntPtr(p + 0x028), ReversePrism.DataModels.Uniforms.FromPointer); // 0270DB41F570 0x28 Uniforms                    ( 00018652E4B0 ModelClassType Uniforms Uniforms Uniforms Pointer )

            return value;
        }
    }
}
