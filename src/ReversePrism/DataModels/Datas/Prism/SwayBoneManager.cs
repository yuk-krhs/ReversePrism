using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parallelCalc                             bool IL2CPP_TYPE_BOOLEAN
    // 001 parallelTransform                        bool IL2CPP_TYPE_BOOLEAN
    // 002 pauseFlag                                bool IL2CPP_TYPE_BOOLEAN
    // 003 isAdv                                    bool IL2CPP_TYPE_BOOLEAN
    // 000 EPS                                      float IL2CPP_TYPE_R4
    // 000 MoveAdjustRate                           float IL2CPP_TYPE_R4
    // 008 baseObject                               GameObject IL2CPP_TYPE_CLASS
    // 010 WindVector                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C TimeRate                                 ModelPrimitiveType float float float Single
    // 020 SetDeltaTime                             ModelPrimitiveType float float float Single
    // 020 DeltaTime                                ModelPrimitiveType float float float Single
    // 024 SkipFrame                                ModelPrimitiveType bool bool bool Bool
    // 028 SwayString                               ModelClassListType List`1<SwayString> List`1<SwayString> List<SwayString> Pointer
    // 030 colliderDic                              Dictionary`2<GameObject, int> IL2CPP_TYPE_GENERICINST
    // 028 StringNo                                 ModelPrimitiveType int int int Int32
    // 038 ChangeFlag                               ModelPrimitiveType bool bool bool Bool
    // 039 ParamChangeFlag                          ModelPrimitiveType bool bool bool Bool
    // 03A AllocFlag                                ModelPrimitiveType bool bool bool Bool
    // 030 ssd                                      NativeArray`1<SwayStringData> IL2CPP_TYPE_GENERICINST
    // 040 cf                                       NativeArray`1<ColliderFlag> IL2CPP_TYPE_GENERICINST
    // 050 cp                                       NativeArray`1<ColliderParam> IL2CPP_TYPE_GENERICINST
    // 060 bcp                                      NativeArray`1<BoneColliderParam> IL2CPP_TYPE_GENERICINST
    // 070 point                                    NativeArray`1<Point> IL2CPP_TYPE_GENERICINST
    // 080 idx                                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 090 Transforms                               ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32
    // 098 TransformList                            ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    public partial class SwayBoneManager : DataModel
    {
        public Vector3                                  WindVector                              { get; set; }
        public float                                    TimeRate                                { get; set; }
        public float                                    SetDeltaTime                            { get; set; }
        public float                                    DeltaTime                               { get; set; }
        public bool                                     SkipFrame                               { get; set; }
        public List<SwayString>?                        SwayString                              { get; set; }
        public int                                      StringNo                                { get; set; }
        public bool                                     ChangeFlag                              { get; set; }
        public bool                                     ParamChangeFlag                         { get; set; }
        public bool                                     AllocFlag                               { get; set; }
        public TransformAccessArray                     Transforms                              { get; set; }
        public List<Transform>?                         TransformList                           { get; set; }

        public static SwayBoneManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneManager() { Pointer= p0 };

            value.WindVector                                = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 WindVector                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TimeRate                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C TimeRate                    ( ModelPrimitiveType float float float Single )
            value.SetDeltaTime                              = GetSingle(new IntPtr(p + 0x020)); // 0x20 SetDeltaTime                ( ModelPrimitiveType float float float Single )
            value.DeltaTime                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 DeltaTime                   ( ModelPrimitiveType float float float Single )
            value.SkipFrame                                 = GetBool(new IntPtr(p + 0x024)); // 0x24 SkipFrame                   ( ModelPrimitiveType bool bool bool Bool )
            value.SwayString                                = GetObjectList<SwayString>(new IntPtr(p + 0x028), ReversePrism.DataModels.SwayString.FromPointer); // 0x28 SwayString                  ( ModelClassListType List`1<SwayString> List`1<SwayString> List<SwayString> Pointer )
            value.StringNo                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 StringNo                    ( ModelPrimitiveType int int int Int32 )
            value.ChangeFlag                                = GetBool(new IntPtr(p + 0x038)); // 0x38 ChangeFlag                  ( ModelPrimitiveType bool bool bool Bool )
            value.ParamChangeFlag                           = GetBool(new IntPtr(p + 0x039)); // 0x39 ParamChangeFlag             ( ModelPrimitiveType bool bool bool Bool )
            value.AllocFlag                                 = GetBool(new IntPtr(p + 0x03A)); // 0x3A AllocFlag                   ( ModelPrimitiveType bool bool bool Bool )
            value.Transforms                                = (TransformAccessArray)GetInt32(new IntPtr(p + 0x090)); // 0x90 Transforms                  ( ModelEnumType TransformAccessArray TransformAccessArray TransformAccessArray Int32 )
            value.TransformList                             = GetObjectList<Transform>(new IntPtr(p + 0x098), ReversePrism.DataModels.Transform.FromPointer); // 0x98 TransformList               ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )

            return value;
        }
    }
}
