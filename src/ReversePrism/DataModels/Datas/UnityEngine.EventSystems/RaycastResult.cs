using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GameObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 018 Module                                   000186741970 ModelClassType BaseRaycaster BaseRaycaster BaseRaycaster Pointer
    // 020 Distance                                 000186666050 ModelPrimitiveType float float float Single
    // 024 Index                                    000186666050 ModelPrimitiveType float float float Single
    // 028 Depth                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C SortingGroupID                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 SortingGroupOrder                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 SortingLayer                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 SortingOrder                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C WorldPosition                            0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 WorldNormal                              0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 054 ScreenPosition                           0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 05C DisplayIndex                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class RaycastResult : DataModel
    {
        public GameObject?                              M_GameObject                            { get; set; }
        public BaseRaycaster?                           Module                                  { get; set; }
        public float                                    Distance                                { get; set; }
        public float                                    Index                                   { get; set; }
        public int                                      Depth                                   { get; set; }
        public int                                      SortingGroupID                          { get; set; }
        public int                                      SortingGroupOrder                       { get; set; }
        public int                                      SortingLayer                            { get; set; }
        public int                                      SortingOrder                            { get; set; }
        public Vector3                                  WorldPosition                           { get; set; }
        public Vector3                                  WorldNormal                             { get; set; }
        public Vector2                                  ScreenPosition                          { get; set; }
        public int                                      DisplayIndex                            { get; set; }

        public static RaycastResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RaycastResult() { Pointer= p0 };

            value.M_GameObject                              = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3EBCD98 0x10 M_GameObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Module                                    = GetObject<BaseRaycaster>(new IntPtr(p + 0x018), ReversePrism.DataModels.BaseRaycaster.FromPointer); // 0245A3EBCDB8 0x18 Module                      ( 000186741970 ModelClassType BaseRaycaster BaseRaycaster BaseRaycaster Pointer )
            value.Distance                                  = GetSingle(new IntPtr(p + 0x020)); // 0245A3EBCDD8 0x20 Distance                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Index                                     = GetSingle(new IntPtr(p + 0x024)); // 0245A3EBCDF8 0x24 Index                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x028)); // 0245A3EBCE18 0x28 Depth                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SortingGroupID                            = GetInt32(new IntPtr(p + 0x02C)); // 0245A3EBCE38 0x2C SortingGroupID              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SortingGroupOrder                         = GetInt32(new IntPtr(p + 0x030)); // 0245A3EBCE58 0x30 SortingGroupOrder           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SortingLayer                              = GetInt32(new IntPtr(p + 0x034)); // 0245A3EBCE78 0x34 SortingLayer                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x038)); // 0245A3EBCE98 0x38 SortingOrder                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.WorldPosition                             = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0245A3EBCEB8 0x3C WorldPosition               ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.WorldNormal                               = (Vector3)GetInt32(new IntPtr(p + 0x048)); // 0245A3EBCED8 0x48 WorldNormal                 ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ScreenPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x054)); // 0245A3EBCEF8 0x54 ScreenPosition              ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.DisplayIndex                              = GetInt32(new IntPtr(p + 0x05C)); // 0245A3EBCF18 0x5C DisplayIndex                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
