using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewportTransform                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 ContentTransform                         000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 ItemHeight                               0001866656B0 ModelPrimitiveType float float float Single
    // 034 1OverItemHeight                          0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_viewportWidth                          0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_viewportHeight                         0001866656B0 ModelPrimitiveType float float float Single
    // 040 items                                    Dictionary`2<int, RecycledListItem> IL2CPP_TYPE_GENERICINST
    // 048 pooledItems                              Stack`1<RecycledListItem> IL2CPP_TYPE_GENERICINST
    // 050 Adapter                                  0001865929A0 ModelClassType IListViewAdapter IListViewAdapter IListViewAdapter Pointer
    // 058 IsDirty                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C CurrentTopIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 CurrentBottomIndex                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RecycledListView : DataModel
    {
        public RectTransform?                           ViewportTransform                       { get; set; }
        public RectTransform?                           ContentTransform                        { get; set; }
        public float                                    ItemHeight                              { get; set; }
        public float                                    1OverItemHeight                         { get; set; }
        public float                                    M_viewportWidth                         { get; set; }
        public float                                    M_viewportHeight                        { get; set; }
        public IListViewAdapter?                        Adapter                                 { get; set; }
        public bool                                     IsDirty                                 { get; set; }
        public int                                      CurrentTopIndex                         { get; set; }
        public int                                      CurrentBottomIndex                      { get; set; }

        public static RecycledListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecycledListView() { Pointer= p0 };

            value.ViewportTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B1E3FF0 0x20 ViewportTransform           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ContentTransform                          = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B1E4010 0x28 ContentTransform            ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ItemHeight                                = GetSingle(new IntPtr(p + 0x030)); // 02466B1E4030 0x30 ItemHeight                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.1OverItemHeight                           = GetSingle(new IntPtr(p + 0x034)); // 02466B1E4050 0x34 1OverItemHeight             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_viewportWidth                           = GetSingle(new IntPtr(p + 0x038)); // 02466B1E4070 0x38 M_viewportWidth             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_viewportHeight                          = GetSingle(new IntPtr(p + 0x03C)); // 02466B1E4090 0x3C M_viewportHeight            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Adapter                                   = GetObject<IListViewAdapter>(new IntPtr(p + 0x050), ReversePrism.DataModels.IListViewAdapter.FromPointer); // 02466B1E40F0 0x50 Adapter                     ( 0001865929A0 ModelClassType IListViewAdapter IListViewAdapter IListViewAdapter Pointer )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x058)); // 02466B1E4110 0x58 IsDirty                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentTopIndex                           = GetInt32(new IntPtr(p + 0x05C)); // 02466B1E4130 0x5C CurrentTopIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentBottomIndex                        = GetInt32(new IntPtr(p + 0x060)); // 02466B1E4150 0x60 CurrentBottomIndex          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
