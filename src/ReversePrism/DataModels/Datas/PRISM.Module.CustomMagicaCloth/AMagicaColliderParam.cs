using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParentName                               ModelPrimitiveType string string string String
    // 018 LocalPosition                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 LocalRotation                            ModelEnumType Quaternion Quaternion Quaternion Int32
    // 034 LocalScale                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 040 Name                                     ModelPrimitiveType string string string String
    // 048 Category                                 ModelPrimitiveType string string string String
    // 050 BodyParamType                            ModelEnumType BodyParamType BodyParamType BodyParamType Int32
    // 054 MinBodyParamValue                        ModelPrimitiveType float float float Single
    // 058 MaxBodyParamValue                        ModelPrimitiveType float float float Single
    // 060 Center                                   ModelClassType BodyParamVector3Property BodyParamVector3Property BodyParamVector3Property Pointer
    public partial class AMagicaColliderParam : DataModel
    {
        public string                                   ParentName                              { get; set; }
        public Vector3                                  LocalPosition                           { get; set; }
        public Quaternion                               LocalRotation                           { get; set; }
        public Vector3                                  LocalScale                              { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Category                                { get; set; }
        public BodyParamType                            BodyParamType                           { get; set; }
        public float                                    MinBodyParamValue                       { get; set; }
        public float                                    MaxBodyParamValue                       { get; set; }
        public BodyParamVector3Property?                Center                                  { get; set; }

        public static AMagicaColliderParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AMagicaColliderParam() { Pointer= p0 };

            value.ParentName                                = GetString(new IntPtr(p + 0x010)); // 0x10 ParentName                  ( ModelPrimitiveType string string string String )
            value.LocalPosition                             = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 LocalPosition               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LocalRotation                             = (Quaternion)GetInt32(new IntPtr(p + 0x024)); // 0x24 LocalRotation               ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.LocalScale                                = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 0x34 LocalScale                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x040)); // 0x40 Name                        ( ModelPrimitiveType string string string String )
            value.Category                                  = GetString(new IntPtr(p + 0x048)); // 0x48 Category                    ( ModelPrimitiveType string string string String )
            value.BodyParamType                             = (BodyParamType)GetInt32(new IntPtr(p + 0x050)); // 0x50 BodyParamType               ( ModelEnumType BodyParamType BodyParamType BodyParamType Int32 )
            value.MinBodyParamValue                         = GetSingle(new IntPtr(p + 0x054)); // 0x54 MinBodyParamValue           ( ModelPrimitiveType float float float Single )
            value.MaxBodyParamValue                         = GetSingle(new IntPtr(p + 0x058)); // 0x58 MaxBodyParamValue           ( ModelPrimitiveType float float float Single )
            value.Center                                    = GetObject<BodyParamVector3Property>(new IntPtr(p + 0x060), ReversePrism.DataModels.BodyParamVector3Property.FromPointer); // 0x60 Center                      ( ModelClassType BodyParamVector3Property BodyParamVector3Property BodyParamVector3Property Pointer )

            return value;
        }
    }
}
