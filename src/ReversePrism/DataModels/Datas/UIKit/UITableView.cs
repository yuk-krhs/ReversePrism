using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DEFAULT_REACHABLE_EDGE_TOLERANCE         float IL2CPP_TYPE_R4
    // 020 DataSource                               0001866878A0 ModelClassType IUITableViewDataSource IUITableViewDataSource IUITableViewDataSource Pointer
    // 028 MarginDataSource                         000186688230 ModelClassType IUITableViewMargin IUITableViewMargin IUITableViewMargin Pointer
    // 030 Delegate                                 000186687D90 ModelClassType IUITableViewDelegate IUITableViewDelegate IUITableViewDelegate Pointer
    // 038 Reachable                                000186688740 ModelClassType IUITableViewReachable IUITableViewReachable IUITableViewReachable Pointer
    // 040 NumberOfCellsAtRowOrColumn               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 CellAlignment                            0001866F6F50 ModelEnumType UITableViewCellAlignment UITableViewCellAlignment UITableViewCellAlignment Int32
    // 048 Holders                                  000185D2FC38 ModelClassListType List`1<UITableViewCellHolder> List`1<UITableViewCellHolder> List<UITableViewCellHolder> Pointer
    // 050 _reusableCellQueues                      Dictionary`2<string, Queue`1<UITableViewCell>> IL2CPP_TYPE_GENERICINST
    // 058 _loadedHolders                           Dictionary`2<int, UITableViewCellHolder> IL2CPP_TYPE_GENERICINST
    // 060 Swapper                                  000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 068 CellsPool                                0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 070 AutoScroll                               000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer
    // 078 IsReloaded                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07C NormalizedPositionWhenReloaded           0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 084 IsReachingBottommostOrLeftmost           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 085 IsReachingTopmostOrRightmost             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 090 Viewport                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 Content                                  000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A0 Direction                                0001866F8B00 ModelEnumType UITableViewDirection UITableViewDirection UITableViewDirection Int32
    // 0A4 IgnoreCellLifeCycle                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 Tag                                      0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class UITableView
    {
        public IUITableViewDataSource?                  DataSource                              { get; set; }
        public IUITableViewMargin?                      MarginDataSource                        { get; set; }
        public IUITableViewDelegate?                    Delegate                                { get; set; }
        public IUITableViewReachable?                   Reachable                               { get; set; }
        public int                                      NumberOfCellsAtRowOrColumn              { get; set; }
        public UITableViewCellAlignment                 CellAlignment                           { get; set; }
        public List<UITableViewCellHolder>?             Holders                                 { get; set; }
        public List<int>?                               Swapper                                 { get; set; }
        public Transform?                               CellsPool                               { get; set; }
        public Coroutine?                               AutoScroll                              { get; set; }
        public bool                                     IsReloaded                              { get; set; }
        public Vector2                                  NormalizedPositionWhenReloaded          { get; set; }
        public bool                                     IsReachingBottommostOrLeftmost          { get; set; }
        public bool                                     IsReachingTopmostOrRightmost            { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public RectTransform?                           Viewport                                { get; set; }
        public RectTransform?                           Content                                 { get; set; }
        public UITableViewDirection                     Direction                               { get; set; }
        public bool                                     IgnoreCellLifeCycle                     { get; set; }
        public int                                      Tag                                     { get; set; }

        public static UITableView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITableView();

            value.DataSource                                = GetObject<IUITableViewDataSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUITableViewDataSource.FromPointer); // 0270D4B569A8 0x20 DataSource                  ( 0001866878A0 ModelClassType IUITableViewDataSource IUITableViewDataSource IUITableViewDataSource Pointer )
            value.MarginDataSource                          = GetObject<IUITableViewMargin>(new IntPtr(p + 0x028), ReversePrism.DataModels.IUITableViewMargin.FromPointer); // 0270D4B569C8 0x28 MarginDataSource            ( 000186688230 ModelClassType IUITableViewMargin IUITableViewMargin IUITableViewMargin Pointer )
            value.Delegate                                  = GetObject<IUITableViewDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.IUITableViewDelegate.FromPointer); // 0270D4B569E8 0x30 Delegate                    ( 000186687D90 ModelClassType IUITableViewDelegate IUITableViewDelegate IUITableViewDelegate Pointer )
            value.Reachable                                 = GetObject<IUITableViewReachable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IUITableViewReachable.FromPointer); // 0270D4B56A08 0x38 Reachable                   ( 000186688740 ModelClassType IUITableViewReachable IUITableViewReachable IUITableViewReachable Pointer )
            value.NumberOfCellsAtRowOrColumn                = GetInt32(new IntPtr(p + 0x040)); // 0270D4B56A28 0x40 NumberOfCellsAtRowOrColumn  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CellAlignment                             = (UITableViewCellAlignment)GetInt32(new IntPtr(p + 0x044)); // 0270D4B56A48 0x44 CellAlignment               ( 0001866F6F50 ModelEnumType UITableViewCellAlignment UITableViewCellAlignment UITableViewCellAlignment Int32 )
            value.Holders                                   = GetObjectList<UITableViewCellHolder>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITableViewCellHolder.FromPointer); // 0270D4B56A68 0x48 Holders                     ( 000185D2FC38 ModelClassListType List`1<UITableViewCellHolder> List`1<UITableViewCellHolder> List<UITableViewCellHolder> Pointer )
            value.Swapper                                   = GetInt32List(new IntPtr(p + 0x060)); // 0270D4B56AC8 0x60 Swapper                     ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.CellsPool                                 = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0270D4B56AE8 0x68 CellsPool                   ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.AutoScroll                                = GetObject<Coroutine>(new IntPtr(p + 0x070), ReversePrism.DataModels.Coroutine.FromPointer); // 0270D4B56B08 0x70 AutoScroll                  ( 000186626DC0 ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.IsReloaded                                = GetBool(new IntPtr(p + 0x078)); // 0270D4B56B28 0x78 IsReloaded                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NormalizedPositionWhenReloaded            = (Vector2)GetInt32(new IntPtr(p + 0x07C)); // 0270D4B56B48 0x7C NormalizedPositionWhenReloaded ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.IsReachingBottommostOrLeftmost            = GetBool(new IntPtr(p + 0x084)); // 0270D4B56B68 0x84 IsReachingBottommostOrLeftmost ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReachingTopmostOrRightmost              = GetBool(new IntPtr(p + 0x085)); // 0270D4B56B88 0x85 IsReachingTopmostOrRightmost ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D4B56BA8 0x88 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.Viewport                                  = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4B56BC8 0x90 Viewport                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Content                                   = GetObject<RectTransform>(new IntPtr(p + 0x098), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4B56BE8 0x98 Content                     ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Direction                                 = (UITableViewDirection)GetInt32(new IntPtr(p + 0x0A0)); // 0270D4B56C08 0xA0 Direction                   ( 0001866F8B00 ModelEnumType UITableViewDirection UITableViewDirection UITableViewDirection Int32 )
            value.IgnoreCellLifeCycle                       = GetBool(new IntPtr(p + 0x0A4)); // 0270D4B56C28 0xA4 IgnoreCellLifeCycle         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Tag                                       = GetInt32(new IntPtr(p + 0x0A8)); // 0270D4B56C48 0xA8 Tag                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
