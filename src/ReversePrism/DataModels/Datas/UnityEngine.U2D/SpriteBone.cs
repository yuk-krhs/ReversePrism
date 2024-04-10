using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   000186671910 ModelPrimitiveType string string string String
    // 018 M_Guid                                   000186671910 ModelPrimitiveType string string string String
    // 020 M_Position                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C M_Rotation                               000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 03C M_Length                                 0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_ParentId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_Color                                  0001865AC7C0 ModelEnumType Color32 Color32 Color32 Int32
    public partial class SpriteBone : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public string                                   M_Guid                                  { get; set; }
        public Vector3                                  M_Position                              { get; set; }
        public Quaternion                               M_Rotation                              { get; set; }
        public float                                    M_Length                                { get; set; }
        public int                                      M_ParentId                              { get; set; }
        public Color32                                  M_Color                                 { get; set; }

        public static SpriteBone? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteBone() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0245A24B5798 0x10 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Guid                                    = GetString(new IntPtr(p + 0x018)); // 0245A24B57B8 0x18 M_Guid                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Position                                = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0245A24B57D8 0x20 M_Position                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Rotation                                = (Quaternion)GetInt32(new IntPtr(p + 0x02C)); // 0245A24B57F8 0x2C M_Rotation                  ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_Length                                  = GetSingle(new IntPtr(p + 0x03C)); // 0245A24B5818 0x3C M_Length                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ParentId                                = GetInt32(new IntPtr(p + 0x040)); // 0245A24B5838 0x40 M_ParentId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Color                                   = (Color32)GetInt32(new IntPtr(p + 0x044)); // 0245A24B5858 0x44 M_Color                     ( 0001865AC7C0 ModelEnumType Color32 Color32 Color32 Int32 )

            return value;
        }
    }
}
