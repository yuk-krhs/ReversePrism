using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 isAdv                                    bool IL2CPP_TYPE_BOOLEAN
    // 020 LeftCones                                000185CB7C78 ModelClassListType ConeInfo[] ConeInfo[] List<ConeInfo> Pointer
    // 028 RightCones                               000185CB7C78 ModelClassListType ConeInfo[] ConeInfo[] List<ConeInfo> Pointer
    // 030 CollideOn                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 BendOn                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 Lhand                                    0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 040 Rhand                                    0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 Hips                                     0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 ForeLen                                  0001866656B0 ModelPrimitiveType float float float Single
    // 054 UpperLen                                 0001866656B0 ModelPrimitiveType float float float Single
    // 058 LeftCollide                              0001866D16B0 ModelEnumType CalcCollidePos CalcCollidePos CalcCollidePos Int32
    // 0A0 RightCollide                             0001866D16B0 ModelEnumType CalcCollidePos CalcCollidePos CalcCollidePos Int32
    // 0E8 IsReset                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 treeL                                    string IL2CPP_TYPE_STRING
    // 000 treeR                                    string IL2CPP_TYPE_STRING
    // 000 treeHips                                 string IL2CPP_TYPE_STRING
    // 000 ConstLerpCount                           float IL2CPP_TYPE_R4
    public partial class ConeConstrain : DataModel
    {
        public List<ConeInfo>?                          LeftCones                               { get; set; }
        public List<ConeInfo>?                          RightCones                              { get; set; }
        public bool                                     CollideOn                               { get; set; }
        public bool                                     BendOn                                  { get; set; }
        public Transform?                               Lhand                                   { get; set; }
        public Transform?                               Rhand                                   { get; set; }
        public Transform?                               Hips                                    { get; set; }
        public float                                    ForeLen                                 { get; set; }
        public float                                    UpperLen                                { get; set; }
        public CalcCollidePos                           LeftCollide                             { get; set; }
        public CalcCollidePos                           RightCollide                            { get; set; }
        public bool                                     IsReset                                 { get; set; }

        public static ConeConstrain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConeConstrain() { Pointer= p0 };

            value.LeftCones                                 = GetObjectList<ConeInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.ConeInfo.FromPointer); // 0245A69997C8 0x20 LeftCones                   ( 000185CB7C78 ModelClassListType ConeInfo[] ConeInfo[] List<ConeInfo> Pointer )
            value.RightCones                                = GetObjectList<ConeInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.ConeInfo.FromPointer); // 0245A69997E8 0x28 RightCones                  ( 000185CB7C78 ModelClassListType ConeInfo[] ConeInfo[] List<ConeInfo> Pointer )
            value.CollideOn                                 = GetBool(new IntPtr(p + 0x030)); // 0245A6999808 0x30 CollideOn                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BendOn                                    = GetBool(new IntPtr(p + 0x031)); // 0245A6999828 0x31 BendOn                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Lhand                                     = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0245A6999848 0x38 Lhand                       ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Rhand                                     = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0245A6999868 0x40 Rhand                       ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Hips                                      = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0245A6999888 0x48 Hips                        ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ForeLen                                   = GetSingle(new IntPtr(p + 0x050)); // 0245A69998A8 0x50 ForeLen                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.UpperLen                                  = GetSingle(new IntPtr(p + 0x054)); // 0245A69998C8 0x54 UpperLen                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LeftCollide                               = (CalcCollidePos)GetInt32(new IntPtr(p + 0x058)); // 0245A69998E8 0x58 LeftCollide                 ( 0001866D16B0 ModelEnumType CalcCollidePos CalcCollidePos CalcCollidePos Int32 )
            value.RightCollide                              = (CalcCollidePos)GetInt32(new IntPtr(p + 0x0A0)); // 0245A6999908 0xA0 RightCollide                ( 0001866D16B0 ModelEnumType CalcCollidePos CalcCollidePos CalcCollidePos Int32 )
            value.IsReset                                   = GetBool(new IntPtr(p + 0x0E8)); // 0245A6999928 0xE8 IsReset                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
