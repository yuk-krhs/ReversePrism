using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Self                                   ModelPrimitiveType short short short Int16
    // 012 M_Parent                                 ModelPrimitiveType short short short Int16
    // 014 M_LeftChild                              ModelPrimitiveType short short short Int16
    // 016 M_RightChild                             ModelPrimitiveType short short short Int16
    // 018 M_FreelistNext                           ModelPrimitiveType short short short Int16
    // 01A M_Flags                                  ModelPrimitiveType ushort ushort ushort UInt16
    // 020 M_Rect                                   ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class AtlasNode : DataModel
    {
        public short                                    M_Self                                  { get; set; }
        public short                                    M_Parent                                { get; set; }
        public short                                    M_LeftChild                             { get; set; }
        public short                                    M_RightChild                            { get; set; }
        public short                                    M_FreelistNext                          { get; set; }
        public ushort                                   M_Flags                                 { get; set; }
        public Vector4                                  M_Rect                                  { get; set; }

        public static AtlasNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtlasNode() { Pointer= p0 };

            value.M_Self                                    = GetInt16(new IntPtr(p + 0x010)); // 0x10 M_Self                      ( ModelPrimitiveType short short short Int16 )
            value.M_Parent                                  = GetInt16(new IntPtr(p + 0x012)); // 0x12 M_Parent                    ( ModelPrimitiveType short short short Int16 )
            value.M_LeftChild                               = GetInt16(new IntPtr(p + 0x014)); // 0x14 M_LeftChild                 ( ModelPrimitiveType short short short Int16 )
            value.M_RightChild                              = GetInt16(new IntPtr(p + 0x016)); // 0x16 M_RightChild                ( ModelPrimitiveType short short short Int16 )
            value.M_FreelistNext                            = GetInt16(new IntPtr(p + 0x018)); // 0x18 M_FreelistNext              ( ModelPrimitiveType short short short Int16 )
            value.M_Flags                                   = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A M_Flags                     ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.M_Rect                                    = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Rect                      ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
